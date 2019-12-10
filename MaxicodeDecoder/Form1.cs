/**
 *  Author: Nicholas Martin
 *  Date:   12/10/2019
 *  Description:    Parses Maxicode into a 1Z tracking code and displays additional information
 **/

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CsvHelper;

namespace MaxicodeDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global variables
        // ________________
        // Minimum string length for maxicode
        const int MIN_LENGTH = 42;

        // UPS header of maxicode format
        const string UPS_HEADER = "[)>0196";

        // Beginning of tracking code
        const string POS_1 = "1Z";

        // Midpoint of tracking code
        const string POS_2 = "UPSN";

        // US country code
        const string US_COUNTRY_CODE = "840";

        bool valid = false;
        DataTable zipTable = new DataTable();
        string maxicode;

        // Debug autofill
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            maxicodeTextBox.Text = "[)>01963360910628400021Z14647438UPSN410E1W1951/1Y123RoadTAMPAFL";   // Sample Maxicode
        }

        // TextBox text change: update result textbox
        private void maxicodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((maxicodeTextBox.Text.Length >= MIN_LENGTH && maxicodeTextBox.Text.StartsWith(UPS_HEADER) && maxicodeTextBox.Text.Contains(POS_1) && maxicodeTextBox.Text.Contains(POS_2)))
            {
                maxicode = maxicodeTextBox.Text;
                trackingCodeParser(maxicode, out string trackingCode);
                valid = true;
                trackingNumTextBox.Text = trackingCode;
                infoButton.Enabled = true;
            }
            else
            {
                valid = false;
                trackingNumTextBox.Text = "";
                infoButton.Enabled = false;
            }
        }

        // Button click: show details for tracking number
        private void infoButton_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                addDetails(maxicode, out string location, out string serviceCode, out string shipperNum, out string zipCode, out string city, out string state);
                MessageBox.Show($"Label type:\t{location}\n" +
                    $"Service code:\t{serviceCode}\nShipper #:\t{shipperNum}\n" +
                    $"Zipcode:\t\t{zipCode}\n" +
                    $"City:\t\t{city}\n" +
                    $"State:\t\t{state}",
                    "Additional information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //Additional detail method
        private void addDetails(string maxicode, out string location, out string serviceCode, out string shipperNum, out string zipCode, out string city, out string state)
        {
            IsDomestic(maxicode, out bool domestic);
            // Country
            if (domestic)
            {
                location = "Domestic";
            }
            else
            {
                location = "International";
            }
            serviceCode = maxicode.Substring(maxicode.IndexOf(POS_1) - 2, 2);
            shipperNum = maxicode.Substring(maxicode.IndexOf(POS_2) + 4, 6);
            // Zipcode
            if (domestic)
            {
                zipCode = maxicode.Substring(7, 5);
                queryZip(zipTable, zipCode, out city, out state);
            }
            else
            {
                zipCode = "N/A";
                city = "N/A";
                state = "N/A";
            }
        }

        // Parse the tracking code
        private void trackingCodeParser(string maxicode, out string trackingCode) // Out strings
        {
            try
            {
                trackingCode = maxicode.Substring(maxicode.IndexOf(POS_1), 2) + maxicode.Substring(maxicode.IndexOf(POS_2) + 4, 6) + maxicode.Substring(maxicode.IndexOf(POS_1) - 2, 2) + maxicode.Substring(maxicode.IndexOf(POS_1) + 2, 8);

            }
            catch (Exception)
            {
                trackingCode = "";
            }
        }

        //Queries database for city and state
        private void queryZip(DataTable dataTable, string zipCode, out string city, out string state)
        {
            city = $"{zipTable.Rows.Find(zipCode).Field<string>("city")}";
            state = $"{zipTable.Rows.Find(zipCode).Field<string>("state_name")}";
        }

        // Determines if tracking code is domestic
        private void IsDomestic(string maxicode, out bool domestic)
        {
            if (maxicode.Contains(US_COUNTRY_CODE))
            {
                domestic = true;
            }
            else
            {
                domestic = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load resources
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("usZips.csv"));
            Console.WriteLine("Trying to load resource: " + resourceName);
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    using (CsvReader csvReader = new CsvReader(reader))
                    {
                        {
                            //Console.WriteLine("Printing resources below:");
                            //foreach (string s in assembly.GetManifestResourceNames())
                            //  System.Diagnostics.Debug.WriteLine(s);
                            using (CsvDataReader csvDataReader = new CsvDataReader(csvReader))
                            {
                                zipTable.Load(csvDataReader);
                                zipTable.PrimaryKey = new DataColumn[] { zipTable.Columns["zip"] };
                            }
                        }
                    }
                }
            }
        }

        private void maxicodeLinkLabel_MouseClick(object sender, MouseEventArgs e) => maxicodePictureBox.Visible = true;

        private void maxicodeLinkLabel_MouseLeave(object sender, EventArgs e) => maxicodePictureBox.Visible = false;

        private void clearButton_Click(object sender, EventArgs e)
        {
            maxicodeTextBox.Text = "";
            maxicodeTextBox.Select();
        }
    }
}
