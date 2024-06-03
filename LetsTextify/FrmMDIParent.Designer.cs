namespace LetsTextify
{
    partial class FrmMDIParent
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDIParent));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pnlmenustrip = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnImageToText = new System.Windows.Forms.Button();
            this.btnPDFToWord = new System.Windows.Forms.Button();
            this.btnQRCodeReader = new System.Windows.Forms.Button();
            this.tmrTimeStamp = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.pnlHeader.Controls.Add(this.lblScreenName);
            this.pnlHeader.Controls.Add(this.ptbLogo);
            this.pnlHeader.Controls.Add(this.lblTimeStamp);
            this.pnlHeader.Controls.Add(this.lblusername);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Coral;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1365, 82);
            this.pnlHeader.TabIndex = 326;
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenName.ForeColor = System.Drawing.Color.White;
            this.lblScreenName.Location = new System.Drawing.Point(255, 32);
            this.lblScreenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(149, 37);
            this.lblScreenName.TabIndex = 331;
            this.lblScreenName.Text = "Dashboard";
            this.lblScreenName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLogo.BackgroundImage")));
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(7, 6);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(227, 72);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 330;
            this.ptbLogo.TabStop = false;
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTimeStamp.ForeColor = System.Drawing.Color.White;
            this.lblTimeStamp.Location = new System.Drawing.Point(1165, 45);
            this.lblTimeStamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(0, 24);
            this.lblTimeStamp.TabIndex = 330;
            this.lblTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(1165, 9);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(92, 24);
            this.lblusername.TabIndex = 328;
            this.lblusername.Text = "Welcome,";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlmenustrip
            // 
            this.pnlmenustrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.pnlmenustrip.Controls.Add(this.btnExit);
            this.pnlmenustrip.Controls.Add(this.btnAbout);
            this.pnlmenustrip.Controls.Add(this.btnImageToText);
            this.pnlmenustrip.Controls.Add(this.btnPDFToWord);
            this.pnlmenustrip.Controls.Add(this.btnQRCodeReader);
            this.pnlmenustrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenustrip.Location = new System.Drawing.Point(0, 82);
            this.pnlmenustrip.Margin = new System.Windows.Forms.Padding(4);
            this.pnlmenustrip.Name = "pnlmenustrip";
            this.pnlmenustrip.Size = new System.Drawing.Size(234, 674);
            this.pnlmenustrip.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnExit.Location = new System.Drawing.Point(5, 593);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 75);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnAbout.Location = new System.Drawing.Point(4, 510);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(223, 75);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnImageToText
            // 
            this.btnImageToText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnImageToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnImageToText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnImageToText.Location = new System.Drawing.Point(7, 6);
            this.btnImageToText.Margin = new System.Windows.Forms.Padding(4);
            this.btnImageToText.Name = "btnImageToText";
            this.btnImageToText.Size = new System.Drawing.Size(223, 75);
            this.btnImageToText.TabIndex = 0;
            this.btnImageToText.Text = "Image To Text";
            this.btnImageToText.UseVisualStyleBackColor = false;
            this.btnImageToText.Click += new System.EventHandler(this.btnImageToText_Click);
            // 
            // btnPDFToWord
            // 
            this.btnPDFToWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPDFToWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPDFToWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnPDFToWord.Location = new System.Drawing.Point(7, 91);
            this.btnPDFToWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDFToWord.Name = "btnPDFToWord";
            this.btnPDFToWord.Size = new System.Drawing.Size(223, 75);
            this.btnPDFToWord.TabIndex = 3;
            this.btnPDFToWord.Text = "PDF To Word";
            this.btnPDFToWord.UseVisualStyleBackColor = false;
            this.btnPDFToWord.Click += new System.EventHandler(this.btnPDFToWord_Click);
            // 
            // btnQRCodeReader
            // 
            this.btnQRCodeReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQRCodeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnQRCodeReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnQRCodeReader.Location = new System.Drawing.Point(7, 176);
            this.btnQRCodeReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnQRCodeReader.Name = "btnQRCodeReader";
            this.btnQRCodeReader.Size = new System.Drawing.Size(223, 75);
            this.btnQRCodeReader.TabIndex = 1;
            this.btnQRCodeReader.Text = "QR Code Reader";
            this.btnQRCodeReader.UseVisualStyleBackColor = false;
            this.btnQRCodeReader.Click += new System.EventHandler(this.btnQRCodeReader_Click);
            // 
            // tmrTimeStamp
            // 
            this.tmrTimeStamp.Enabled = true;
            this.tmrTimeStamp.Interval = 1000;
            this.tmrTimeStamp.Tick += new System.EventHandler(this.tmrTimeStamp_Tick);
            // 
            // FrmMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 756);
            this.Controls.Add(this.pnlmenustrip);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SealAccura";
            this.Load += new System.EventHandler(this.frmMDIParent_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel pnlmenustrip;
        internal System.Windows.Forms.Label lblusername;
        internal System.Windows.Forms.Label lblTimeStamp;
        public System.Windows.Forms.Panel pnlHeader;
        internal System.Windows.Forms.PictureBox ptbLogo;
        public System.Windows.Forms.Button btnPDFToWord;
        public System.Windows.Forms.Button btnQRCodeReader;
        public System.Windows.Forms.Button btnImageToText;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrTimeStamp;
        internal System.Windows.Forms.Label lblScreenName;
    }
}



