namespace LetsTextify
{
    partial class FrmQRCodeReader
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnGenerateResult = new System.Windows.Forms.Button();
            this.txtQRCodeResult = new System.Windows.Forms.TextBox();
            this.pbQRCodeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(850, 190);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(189, 74);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnGenerateResult
            // 
            this.btnGenerateResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnGenerateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateResult.ForeColor = System.Drawing.Color.White;
            this.btnGenerateResult.Location = new System.Drawing.Point(850, 317);
            this.btnGenerateResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateResult.Name = "btnGenerateResult";
            this.btnGenerateResult.Size = new System.Drawing.Size(189, 74);
            this.btnGenerateResult.TabIndex = 8;
            this.btnGenerateResult.Text = "Generate Result";
            this.btnGenerateResult.UseVisualStyleBackColor = false;
            this.btnGenerateResult.Click += new System.EventHandler(this.btnGenerateResult_Click);
            // 
            // txtQRCodeResult
            // 
            this.txtQRCodeResult.Location = new System.Drawing.Point(771, 446);
            this.txtQRCodeResult.Multiline = true;
            this.txtQRCodeResult.Name = "txtQRCodeResult";
            this.txtQRCodeResult.Size = new System.Drawing.Size(335, 124);
            this.txtQRCodeResult.TabIndex = 9;
            // 
            // pbQRCodeImage
            // 
            this.pbQRCodeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQRCodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQRCodeImage.Location = new System.Drawing.Point(12, 39);
            this.pbQRCodeImage.Name = "pbQRCodeImage";
            this.pbQRCodeImage.Size = new System.Drawing.Size(742, 531);
            this.pbQRCodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCodeImage.TabIndex = 10;
            this.pbQRCodeImage.TabStop = false;
            // 
            // FrmQRCodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 640);
            this.Controls.Add(this.pbQRCodeImage);
            this.Controls.Add(this.txtQRCodeResult);
            this.Controls.Add(this.btnGenerateResult);
            this.Controls.Add(this.btnChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQRCodeReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCodeReader";
            this.Load += new System.EventHandler(this.FrmQRCodeReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnGenerateResult;
        private System.Windows.Forms.TextBox txtQRCodeResult;
        private System.Windows.Forms.PictureBox pbQRCodeImage;
    }
}