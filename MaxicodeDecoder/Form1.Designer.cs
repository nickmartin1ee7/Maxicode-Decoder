namespace MaxicodeDecoder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maxicodeTextBox = new System.Windows.Forms.TextBox();
            this.trackingNumTextBox = new System.Windows.Forms.TextBox();
            this.trackingNumLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.maxicodeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.maxicodePictureBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxicodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maxicodeTextBox
            // 
            this.maxicodeTextBox.Location = new System.Drawing.Point(124, 27);
            this.maxicodeTextBox.Name = "maxicodeTextBox";
            this.maxicodeTextBox.Size = new System.Drawing.Size(418, 20);
            this.maxicodeTextBox.TabIndex = 0;
            this.maxicodeTextBox.TextChanged += new System.EventHandler(this.maxicodeTextBox_TextChanged);
            // 
            // trackingNumTextBox
            // 
            this.trackingNumTextBox.Location = new System.Drawing.Point(124, 75);
            this.trackingNumTextBox.Name = "trackingNumTextBox";
            this.trackingNumTextBox.ReadOnly = true;
            this.trackingNumTextBox.Size = new System.Drawing.Size(418, 20);
            this.trackingNumTextBox.TabIndex = 2;
            // 
            // trackingNumLabel
            // 
            this.trackingNumLabel.AutoSize = true;
            this.trackingNumLabel.Location = new System.Drawing.Point(12, 78);
            this.trackingNumLabel.Name = "trackingNumLabel";
            this.trackingNumLabel.Size = new System.Drawing.Size(106, 13);
            this.trackingNumLabel.TabIndex = 5;
            this.trackingNumLabel.Text = "1Z Tracking number:";
            // 
            // infoButton
            // 
            this.infoButton.Enabled = false;
            this.infoButton.Location = new System.Drawing.Point(124, 108);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(74, 29);
            this.infoButton.TabIndex = 3;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // maxicodeLinkLabel
            // 
            this.maxicodeLinkLabel.AutoSize = true;
            this.maxicodeLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.maxicodeLinkLabel.Location = new System.Drawing.Point(62, 27);
            this.maxicodeLinkLabel.Name = "maxicodeLinkLabel";
            this.maxicodeLinkLabel.Size = new System.Drawing.Size(56, 13);
            this.maxicodeLinkLabel.TabIndex = 6;
            this.maxicodeLinkLabel.TabStop = true;
            this.maxicodeLinkLabel.Text = "Maxicode:";
            this.maxicodeLinkLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maxicodeLinkLabel_MouseClick);
            this.maxicodeLinkLabel.MouseLeave += new System.EventHandler(this.maxicodeLinkLabel_MouseLeave);
            // 
            // maxicodePictureBox
            // 
            this.maxicodePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("maxicodePictureBox.Image")));
            this.maxicodePictureBox.Location = new System.Drawing.Point(124, 12);
            this.maxicodePictureBox.Name = "maxicodePictureBox";
            this.maxicodePictureBox.Size = new System.Drawing.Size(100, 100);
            this.maxicodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxicodePictureBox.TabIndex = 7;
            this.maxicodePictureBox.TabStop = false;
            this.maxicodePictureBox.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(468, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 29);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.infoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(561, 149);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.maxicodePictureBox);
            this.Controls.Add(this.maxicodeLinkLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.trackingNumTextBox);
            this.Controls.Add(this.trackingNumLabel);
            this.Controls.Add(this.maxicodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Maxicode Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.maxicodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maxicodeTextBox;
        private System.Windows.Forms.TextBox trackingNumTextBox;
        private System.Windows.Forms.Label trackingNumLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.LinkLabel maxicodeLinkLabel;
        private System.Windows.Forms.PictureBox maxicodePictureBox;
        private System.Windows.Forms.Button clearButton;
    }
}

