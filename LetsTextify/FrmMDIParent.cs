
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace LetsTextify
{
    partial class FrmMDIParent : Form
    {
        Offline_Simulator Offline_simulator;

        public FrmMDIParent()
        {
            InitializeComponent();
        }
        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "Dashboard";
        }

        private void tmrTimeStamp_Tick(object sender, EventArgs e)
        {
            string txt = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            lblTimeStamp.Text = txt.Replace("-", "/");

            if (clsGlobalDefinations.stCurrentScreenName != lblScreenName.Text)
                lblScreenName.Text = clsGlobalDefinations.stCurrentScreenName;
        }


        private void pnlRunMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnImageToText_Click(object sender, EventArgs e)
        {
           
                FrmTeching IT = new FrmTeching();
                // SetCurrentActionInMDI("Batch Startup");
                IT.MdiParent = this;

                IT.Dock = DockStyle.Fill;
                IT.Show();
              
        }

        private void btnQRCodeReader_Click(object sender, EventArgs e)
        {
            FrmQRCodeReader frmQR = new FrmQRCodeReader();
            // SetCurrentActionInMDI("Batch Startup");
            frmQR.MdiParent = this;
            frmQR.Dock = DockStyle.Fill;
            frmQR.Show();
        }

        private void btnPDFToWord_Click(object sender, EventArgs e)
        {
            FrmPDFToWord frmPDFToWord = new FrmPDFToWord();
            // SetCurrentActionInMDI("Batch Startup");
            frmPDFToWord.MdiParent = this;
            frmPDFToWord.Dock = DockStyle.Fill;
            frmPDFToWord.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            // SetCurrentActionInMDI("Batch Startup");
            frmAbout.MdiParent = this;
            frmAbout.Dock = DockStyle.Fill;
            frmAbout.Show();
        }
    }
}
