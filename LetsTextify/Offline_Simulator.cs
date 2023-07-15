using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LetsTextify
{
    public partial class Offline_Simulator : Form
    {
        String[] Offline_Image_Path_1;
        Boolean Single_Trigger_On_1;  
        String Image_Path_1;
        int index_1_image;
        int Total_index_1_image;
        public Offline_Simulator()
        {
            InitializeComponent();
        }

       

        private void pct_Load_Folder_1_OS_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Image Files|*.*";
            OpenFileDialog1.Title = "Select all image file";
            OpenFileDialog1.Multiselect = true;

            if( OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                Offline_Image_Path_1 = OpenFileDialog1.FileNames;
                Total_index_1_image = Offline_Image_Path_1.Length;
                index_1_image = -1;
                lbl_Image_Received_Count_1_OS.Text = (index_1_image + 1).ToString();
                btn_Continuous_trigger_1_OS.Enabled = true;
                btn_Single_trigger_1_OS.Enabled = true;
                btn_Reset_trigger_1_OS.Enabled = true;
            }
        }

        private void btn_Single_trigger_1_OS_Click(object sender, EventArgs e)
        {
            //'If Single_Trigger_On_1 = False Then
            FrmTeching frmTeach = new FrmTeching();
            index_1_image += 1;
            if(index_1_image == Total_index_1_image )
                index_1_image = 0;
            Single_Trigger_On_1 = true;
            Image_Path_1 = Offline_Image_Path_1[index_1_image];
            FrmTeching.IS_Grab_offline_1_CB = true;
            FrmTeching.Offline_Simulator_Image_Path_1_CB = Image_Path_1;
            lbl_Image_Received_Count_1_OS.Text = (index_1_image + 1).ToString();
           // ' End If
        }

        private void btn_Continuous_trigger_1_OS_Click(object sender, EventArgs e)
        {
            if (Timer1_IS_Start == false)
            {
                Timer1.Interval = Convert.ToInt32(txt_Trigger_Delay_1_OS.Text);
                Timer1.Start();
                Timer1_IS_Start = true;
            }
            else
            {
                Timer1.Stop();
                Timer1_IS_Start = false;
            }     
        }
        Boolean Timer1_IS_Start;
        private void btn_Reset_trigger_1_OS_Click(object sender, EventArgs e)
        {
             index_1_image = -1;
             lbl_Image_Received_Count_1_OS.Text = (index_1_image + 1).ToString();
             FrmTeching.IS_Grab_offline_1_CB = false;
             FrmTeching.Offline_Simulator_Image_Path_1_CB = Image_Path_1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
              if( btn_Single_trigger_1_OS.Enabled == true )
                btn_Single_trigger_1_OS_Click(this, e);
        }
    }
}
