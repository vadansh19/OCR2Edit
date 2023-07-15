namespace LetsTextify
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.PreprocessedImg = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreprocessedImg
            // 
            this.PreprocessedImg.AutoSize = true;
            this.PreprocessedImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreprocessedImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.PreprocessedImg.Location = new System.Drawing.Point(124, 63);
            this.PreprocessedImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreprocessedImg.Name = "PreprocessedImg";
            this.PreprocessedImg.Size = new System.Drawing.Size(113, 20);
            this.PreprocessedImg.TabIndex = 11;
            this.PreprocessedImg.Text = "Let\'s Textify";
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Location = new System.Drawing.Point(128, 125);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(957, 388);
            this.pnlAbout.TabIndex = 12;
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(12, 11);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(933, 368);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 640);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.PreprocessedImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.pnlAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label PreprocessedImg;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lblAbout;
    }
}