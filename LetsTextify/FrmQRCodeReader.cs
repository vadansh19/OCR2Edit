using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LetsTextify
{
    public partial class FrmQRCodeReader : Form
    {
        public FrmQRCodeReader()
        {
            InitializeComponent();
        }

        private void btnGenerateResult_Click(object sender, EventArgs e)
        {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            try
            {
                Bitmap bitmap = new Bitmap(pbQRCodeImage.Image);
                BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
                Result result = reader.Decode(bitmap);
                string decoded = (result == null ? "No QRCode Found " : result.ToString().Trim());
                txtQRCodeResult.Text = decoded;
            }
            catch (Exception)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();

            // Set the filter to show only image files
            dialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            // Show the dialog and get the result
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Load the selected image file into a Bitmap object
                Bitmap image = new Bitmap(dialog.FileName);

                // Do something with the image, such as displaying it in a PictureBox control
                pbQRCodeImage.Image = image;
            }
        }

        private void FrmQRCodeReader_Load(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "QRCodeReader";
        }
    }
}
