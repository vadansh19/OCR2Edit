
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHunspell;
using OCRProcessing;
using Org.BouncyCastle.Crypto.Engines;
using sun.security.util;
using sun.security.x509;
using sun.swing;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static javax.jws.soap.SOAPBinding;
using Word = Microsoft.Office.Interop.Word;

namespace LetsTextify
{
    public partial class FrmTeching : Form
    {
        public static bool IS_Grab_offline_1_CB;
        public static string Offline_Simulator_Image_Path_1_CB = "";
        Offline_Simulator Offline_simulator;
        Rectangle g_ROI_Rect;
        Bitmap org = null;
        Bitmap preproc = null;
        bool IsCompareOCR = false;

        int Tp_pct_Width = 586;
        int Tp_pct_Height = 383;

        int ImageWidth = 0;
        int ImageHeight = 0;

        System.Drawing.Rectangle M_Rect;
        System.Drawing.Rectangle M_Rect_Actual;
        System.Drawing.Rectangle LT_Rect;
        System.Drawing.Rectangle RT_Rect;
        System.Drawing.Rectangle LB_Rect;
        System.Drawing.Rectangle RB_Rect;
        System.Drawing.Rectangle L_Rect;
        System.Drawing.Rectangle R_Rect;
        System.Drawing.Rectangle T_Rect;
        System.Drawing.Rectangle B_Rect;
        bool flg_M, flg_LT, flg_LB, flg_RB, flg_RT;
        bool flg_T, flg_L, flg_R, flg_B;
        int tempX, tempY;
        bool IS_ROI_Start;
        int Rect_Size = 10;

        System.Drawing.Point PointLT, PointLB, PointRT, PointRB;
        System.Drawing.Point PointL, PointT, PointR, PointB;

        float LocationX;
        float LocationY;

        //Save to Word

        Word.Document wordDoc;
        Word.Application wordApp;
        public string getOCRResult()
        {
            OCRProc objOcr = new OCRProc();

            objOcr.PreProcessImage(Offline_Simulator_Image_Path_1_CB, g_ROI_Rect,
                clsGlobalDefinations.objstructRecipeParams.ScaleFactor, clsGlobalDefinations.objstructRecipeParams.Erode,
                clsGlobalDefinations.objstructRecipeParams.Dilate, clsGlobalDefinations.objstructRecipeParams.Smooth,
                clsGlobalDefinations.objstructRecipeParams.ThresholdMethod, clsGlobalDefinations.objstructRecipeParams.ThresholdMin,
                clsGlobalDefinations.objstructRecipeParams.ThresholdMax, clsGlobalDefinations.objstructRecipeParams.CharMinWidth,
                clsGlobalDefinations.objstructRecipeParams.CharMinHight, clsGlobalDefinations.objstructRecipeParams.CharMaxWidth,
                clsGlobalDefinations.objstructRecipeParams.CharMaxHeight, clsGlobalDefinations.objstructRecipeParams.IsWhiteOnBlack);
            string strWhiteList = getWhiteListAplhabets(cmbDataTypes.SelectedItem.ToString());

                string Result = objOcr.ImageToText("1.bmp", clsGlobalDefinations.objstructRecipeParams.PSMValue,
                clsGlobalDefinations.objstructRecipeParams.OEMValue, clsGlobalDefinations.objstructRecipeParams.TrainFile, 
                strWhiteList);

            if(clsGlobalDefinations.isPreviewStarted)
                txtPostProcessPreview.Text = getPreProcessedData(Result);
            else
                txtResultPostProcessed.Text = getPreProcessedData(Result);

            if (IsCompareOCR)
            {
                string orgResult = objOcr.ImageToText("tmp.bmp", clsGlobalDefinations.objstructRecipeParams.PSMValue,
               clsGlobalDefinations.objstructRecipeParams.OEMValue, clsGlobalDefinations.objstructRecipeParams.TrainFile,
               strWhiteList);

               
                OriginalPicture.BackgroundImage = null;
                PreProcessedImage.BackgroundImage = null;
                if (org != null && org.Width > 0 && org.Height > 0)
                    org.Dispose();
                if (preproc != null && preproc.Width > 0 && preproc.Height > 0)
                    preproc.Dispose();
                if (File.Exists("org.bmp"))
                    File.Delete("org.bmp");
                if (File.Exists("imgproc.bmp"))
                    File.Delete("imgproc.bmp");
                File.Copy("tmp.bmp", "org.bmp");
                File.Copy("1.bmp", "imgproc.bmp");

                byte[] imageData = File.ReadAllBytes("org.bmp");
                byte[] imageData2 = File.ReadAllBytes("imgproc.bmp");
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    org = new Bitmap(memoryStream);
                }
                using (MemoryStream memoryStream = new MemoryStream(imageData2))
                {
                    preproc = new Bitmap(memoryStream);
                }

                OriginalPicture.BackgroundImage = org;
                PreProcessedImage.BackgroundImage = preproc;
                
                OriginalImgText.Text = orgResult;
                PreprocessedImgText.Text = Result;
            }

            return Result;
        }
        public void CreateWordDocument()
        {
            // Create a new Word application
            wordApp = new Word.Application();

            // Create a new document
            wordDoc = wordApp.Documents.Add();

            //AddPage(wordDoc, "Page 1 Content");
        }
        public void SaveWordDocument(string filepath)
        {
            wordDoc.SaveAs2(filepath);
            wordDoc.Close();
            wordApp.Quit();
        }

        private void AddPage(Word.Document document, string content)
        {
            // Create a new page
            Word.Paragraph paragraph = document.Content.Paragraphs.Add();

            // Add the content to the page
            paragraph.Range.Text = content;

            // Add a page break after the content
            paragraph.Range.InsertParagraphAfter();
            paragraph.Range.InsertBreak(Word.WdBreakType.wdPageBreak);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if(Offline_Simulator_Image_Path_1_CB!=string.Empty)
            {
                btnStartPreview.Enabled = true;
                SaveDataToStructure();
                g_ROI_Rect = getROIRact(M_Rect);

                txtResult.Text = getOCRResult();
                btnSaveRecipeTeach.Enabled = true;
            }
            else
            {
                    MessageBox.Show("Please choose Image first.", "Let's Textify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Rectangle getROIRact(Rectangle M_Rect)
        {
            Rectangle ROI_Rect = new Rectangle(0,0,0,0);
            double factor_x = (double)ImageWidth / (double)pnl_cam_1_create_receipe.Width;
            double factor_y = (double)ImageHeight / (double)pnl_cam_1_create_receipe.Height;
            ROI_Rect.X = (int)((double)M_Rect.X * (double)factor_x);
            ROI_Rect.Y = (int)((double)M_Rect.Y * (double)factor_y);
            ROI_Rect.Width = (int)((double)M_Rect.Width * (double)factor_x);
            ROI_Rect.Height = (int)((double)M_Rect.Height * (double)factor_y);
            return ROI_Rect;
        }
        private void SaveDataToStructure()
        {
            if (clsGlobalDefinations.isEditRecipe)
                clsGlobalDefinations.objstructRecipeParams.RecipeId = clsGlobalDefinations.iArrRecipeIdList[dgvRecipeList.SelectedRows[0].Index];

            pnl_cam_1_create_receipe.Width = Tp_pct_Width + (Zoom_TP_Val * 100);
            pnl_cam_1_create_receipe.Height = Tp_pct_Height + (Zoom_TP_Val * 60);
            Rectangle rectangle = M_Rect;

            double factor_x = (double)ImageWidth / (double)pnl_cam_1_create_receipe.Width;
            double factor_y = (double)ImageHeight / (double)pnl_cam_1_create_receipe.Height;
            rectangle.X = (int)((double)M_Rect.X / (double)factor_x);
            rectangle.Y = (int)((double)M_Rect.Y / (double)factor_y);
            rectangle.Width = (int)((double)M_Rect.Width / (double)factor_x);
            rectangle.Height = (int)((double)M_Rect.Height / (double)factor_y);

            clsGlobalDefinations.objstructRecipeParams.ROI_Rect = M_Rect;

            //PreProcess Params
            clsGlobalDefinations.objstructRecipeParams.TrainFile = cmbTrainFile.SelectedItem.ToString();
            clsGlobalDefinations.objstructRecipeParams.Datatype = cmbDataTypes.SelectedItem.ToString();
            clsGlobalDefinations.objstructRecipeParams.PSMValue = Convert.ToInt32(cmbPsmValue.SelectedItem.ToString());
            clsGlobalDefinations.objstructRecipeParams.OEMValue = Convert.ToInt32(cmbOEMValue.SelectedItem.ToString());
            clsGlobalDefinations.objstructRecipeParams.ScaleFactor = Convert.ToInt32(cmbScaleFactor.SelectedItem);
            // clsGlobalDefinations.objstructRecipeParams.strFilterName = "";
            clsGlobalDefinations.objstructRecipeParams.Erode = Convert.ToInt32(cmbErode.SelectedItem);
            clsGlobalDefinations.objstructRecipeParams.Dilate = Convert.ToInt32(cmbDilate.SelectedItem);
            clsGlobalDefinations.objstructRecipeParams.Smooth = Convert.ToInt32(cmbSmooth.SelectedItem);
            
            clsGlobalDefinations.objstructRecipeParams.ThresholdMethod = cmbThreshMethod.SelectedIndex;
            clsGlobalDefinations.objstructRecipeParams.ThresholdMin = Convert.ToInt32(txtThreshMin.Text);
            clsGlobalDefinations.objstructRecipeParams.ThresholdMax = Convert.ToInt32(txtThreshMax.Text);
            clsGlobalDefinations.objstructRecipeParams.CharMinWidth = Convert.ToInt32(txtCharMinWidth.Text);
            clsGlobalDefinations.objstructRecipeParams.CharMinHight = Convert.ToInt32(txtCharMinHeight.Text);
            clsGlobalDefinations.objstructRecipeParams.CharMaxWidth = Convert.ToInt32(txtCharMaxWidth.Text);
            clsGlobalDefinations.objstructRecipeParams.CharMaxHeight = Convert.ToInt32(txtCharMaxHeight.Text);
            clsGlobalDefinations.objstructRecipeParams.IsWhiteOnBlack = chkWhiteOnBlack.Checked;
        }


        public FrmTeching()
        {
            InitializeComponent();
        }

        private void loadDefaultParam()
        {
            //PreProcessing Params
            cmbScaleFactor.SelectedItem = "0";
            cmbErode.SelectedItem = "0";
            cmbDilate.SelectedItem = "0";
            cmbSmooth.SelectedItem = "0";
            cmbThreshMethod.SelectedItem = "Binary";
            txtThreshMin.Text = "100";
            txtThreshMax.Text = "255";
            txtCharMinWidth.Text = "5";
            txtCharMinHeight.Text = "15";
            txtCharMaxWidth.Text = "5";
            txtCharMaxHeight.Text = "15";

            //Recognition Params (OCR)
            cmbPsmValue.SelectedItem = "3";
            cmbOEMValue.SelectedItem = "3";
            cmbTrainFile.SelectedItem = "eng";
            cmbDataTypes.SelectedItem = "ASCII";
        }

        int Zoom_TP_Val = 0;

 


        private void btnCompareOCR_Click(object sender, EventArgs e)
        {
            pnlPreview.Visible = false;
            pnlCompareOCR.Visible = true;
            pnlCompareOCR.BringToFront();
            clsGlobalDefinations.stCurrentScreenName = "CompareOCR";
            IsCompareOCR = true;
        }

        private void btnCancelRecipeCreate_Click(object sender, EventArgs e)
        {
            pnlRecipeNamePopUp.Visible = false;
            txtRecipeName.Text = string.Empty;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            pnlRecipeNamePopUp.Visible = true;
            pnlRecipeNamePopUp.BringToFront();
            txtRecipeName.Text = string.Empty;
            txtRecipeName.Focus();
        }

        private void btnSaveRecipeTeach_Click(object sender, EventArgs e)
        {
            clsGlobalDefinations.OpenConnection();
            if(clsGlobalDefinations.isEditRecipe)
                clsGlobalDefinations.RecipeDataDML(1);
            else
                clsGlobalDefinations.RecipeDataDML(0);
            clsGlobalDefinations.CloseConnection();

            pnlTeaching.Visible = false;
            pnlRecipe.Visible = true;
            pnlRecipe.BringToFront();
            unloadOfflineSimulator();
            loadProductFromDB();
            clsGlobalDefinations.RecipeCreateOrEditStarted = false;
        }

        private void btnStartPreview_Click(object sender, EventArgs e)
        {
            // Offline_simulator.index_1_image = 0;
            Offline_simulator.btn_Reset_trigger_1_OS.PerformClick();
             clsGlobalDefinations.stCurrentScreenName = "Preview";
            pnlTeaching.Visible = false;
            pnlPreview.Visible = true;
            pnlPreview.BringToFront();
            clsGlobalDefinations.isPreviewStarted = true;
            CreateWordDocument();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "Teach Recipe";
            loadOfflineSimulator();
            clsGlobalDefinations.isEditRecipe = true;
            pnlRecipe.Visible = false;
            pnlTeaching.Visible = true;
            pnlTeaching.BringToFront();
            DataRow dr = loadSingleFromDB(clsGlobalDefinations.iArrRecipeIdList[dgvRecipeList.SelectedRows[0].Index]);
            loadParamToForm(dr);
            clsGlobalDefinations.RecipeCreateOrEditStarted = true;
        }

        private void loadParamToForm(DataRow dr)
        {
            IS_ROI_Start = true;
            int X = Convert.ToInt32(dr[2]);
            int Y = Convert.ToInt32(dr[3]);
            int Width = Convert.ToInt32(dr[4]);
            int Height = Convert.ToInt32(dr[5]);
            initRect2(X, Y, Width, Height);
            clsGlobalDefinations.objstructRecipeParams.RecipeId = Convert.ToInt32(dr[0]);
            clsGlobalDefinations.objstructRecipeParams.RecipeName = dr[1].ToString();
            //PreProcess Params
            cmbTrainFile.SelectedItem = dr[6].ToString();
            cmbDataTypes.SelectedItem = dr[7].ToString();
            cmbPsmValue.SelectedItem = dr[8].ToString();
            cmbOEMValue.SelectedItem = dr[9].ToString();
            cmbScaleFactor.SelectedItem = dr[10].ToString();
            cmbErode.SelectedItem = dr[11].ToString();
            cmbDilate.SelectedItem = dr[12].ToString();
            cmbSmooth.SelectedItem = dr[13].ToString();
            cmbThreshMethod.SelectedItem = dr[14].ToString();
            txtThreshMin.Text = dr[15].ToString();
            txtThreshMax.Text = dr[16].ToString();
            txtCharMinWidth.Text = dr[17].ToString();
            txtCharMinHeight.Text = dr[18].ToString();
            txtCharMaxWidth.Text = dr[19].ToString();
            txtCharMaxHeight.Text = dr[20].ToString();
            chkWhiteOnBlack.Checked = Convert.ToBoolean(dr[21]);
            SaveDataToStructure();
            g_ROI_Rect = getROIRact(M_Rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsGlobalDefinations.OpenConnection();
            if (clsGlobalDefinations.isEditRecipe)
                clsGlobalDefinations.RecipeDataDML(1);
            else
                clsGlobalDefinations.RecipeDataDML(0);
            clsGlobalDefinations.CloseConnection();

            pnlPreview.Visible = false;
            pnlRecipe.BringToFront();
        }

        private void btnSaveRecipePreview_Click(object sender, EventArgs e)
        {
            clsGlobalDefinations.OpenConnection();
            if (clsGlobalDefinations.isEditRecipe)
                clsGlobalDefinations.RecipeDataDML(1);
            else
                clsGlobalDefinations.RecipeDataDML(0);
            clsGlobalDefinations.CloseConnection();

            pnlPreview.Visible = false;
            pnlRecipe.Visible = true;
            pnlRecipe.BringToFront();
            loadProductFromDB();
        }

        private void btnStopPreview_Click(object sender, EventArgs e)
        {
            pnlPreview.Visible = false;
            pnlTeaching.Visible = true;
            pnlTeaching.BringToFront();
            clsGlobalDefinations.isPreviewStarted = false;
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\PreviewData.Docx");
            SaveWordDocument(AppDomain.CurrentDomain.BaseDirectory+"\\PreviewData.Docx");
        }
        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            if (txtRecipeName.Text != String.Empty)
            {
                if (checkDuplicateRecipeName(txtRecipeName.Text))
                {
                    clsGlobalDefinations.stCurrentScreenName = "Teach Recipe";
                    pnlRecipeNamePopUp.Visible = false;

                    pnlRecipe.Visible = false;
                    pnlTeaching.Visible = true;
                    pnlTeaching.BringToFront();
                    clsGlobalDefinations.objstructRecipeParams.RecipeName = txtRecipeName.Text;
                    txtRecipeName.Text = string.Empty;
                    clsGlobalDefinations.isEditRecipe = false;
                    loadOfflineSimulator();
                    clsGlobalDefinations.RecipeCreateOrEditStarted = true;
                }
                else
                {
                    MessageBox.Show("Recipe alredy exists.", "Let's Textify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Recipe Name can not be blank.", "Let's Textify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkDuplicateRecipeName(string text)
        {
            bool result = true;
            for (int i = 0; i < clsGlobalDefinations.strArrRecipeNameList.Length; i++)
            {
                if(clsGlobalDefinations.strArrRecipeNameList[i] == text)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private void pnl_cam_1_create_receipe_MouseClick(object sender, MouseEventArgs e)
        {
            LocationX = e.Location.X;
            LocationY = e.Location.Y;
        }

        private void pnl_cam_1_create_receipe_MouseDown(object sender, MouseEventArgs e)
        {
            if (IS_ROI_Start)
            {
                if (e.Location.X >= LT_Rect.X && e.Location.Y >= LT_Rect.Y && e.Location.X <= (LT_Rect.X + LT_Rect.Width) && e.Location.Y <= (LT_Rect.Y + LT_Rect.Height))
                    flg_LT = true;
                else if (e.Location.X >= RT_Rect.X && e.Location.Y >= RT_Rect.Y && e.Location.X <= (RT_Rect.X + RT_Rect.Width) && e.Location.Y <= (RT_Rect.Y + RT_Rect.Height))
                    flg_RT = true;
                else if (e.Location.X >= LB_Rect.X && e.Location.Y >= LB_Rect.Y && e.Location.X <= (LB_Rect.X + LB_Rect.Width) && e.Location.Y <= (LB_Rect.Y + LB_Rect.Height))
                    flg_LB = true;
                else if (e.Location.X >= RB_Rect.X && e.Location.Y >= RB_Rect.Y && e.Location.X <= (RB_Rect.X + RB_Rect.Width) && e.Location.Y <= (RB_Rect.Y + RB_Rect.Height))
                    flg_RB = true;
                else if (e.Location.X >= B_Rect.X && e.Location.Y >= B_Rect.Y && e.Location.X <= (B_Rect.X + B_Rect.Width) && e.Location.Y <= (B_Rect.Y + B_Rect.Height))
                    flg_B = true;
                else if (e.Location.X >= R_Rect.X && e.Location.Y >= R_Rect.Y && e.Location.X <= (R_Rect.X + R_Rect.Width) && e.Location.Y <= (R_Rect.Y + R_Rect.Height))
                    flg_R = true;
                else if (e.Location.X >= T_Rect.X && e.Location.Y >= T_Rect.Y && e.Location.X <= (T_Rect.X + T_Rect.Width) && e.Location.Y <= (T_Rect.Y + T_Rect.Height))
                    flg_T = true;
                else if (e.Location.X >= L_Rect.X && e.Location.Y >= L_Rect.Y && e.Location.X <= (L_Rect.X + L_Rect.Width) && e.Location.Y <= (L_Rect.Y + L_Rect.Height))
                    flg_L = true;
                else if (e.Location.X >= (LT_Rect.X + LT_Rect.Width) && e.Location.Y >= (LT_Rect.Y + LT_Rect.Height) && e.Location.X <= (RB_Rect.X + RB_Rect.Width) && e.Location.Y <= (RB_Rect.Y + RB_Rect.Height))
                    flg_M = true;

                tempX = e.Location.X; tempY = e.Location.Y;

                PointL.X = L_Rect.X; PointT.X = T_Rect.X; PointB.X = B_Rect.X; PointR.X = R_Rect.X;
                PointL.Y = L_Rect.Y; PointT.Y = T_Rect.Y; PointB.Y = B_Rect.Y; PointR.Y = R_Rect.Y;
                PointLT.X = LT_Rect.X; PointLB.X = LB_Rect.X; PointRT.X = RT_Rect.X; PointRB.X = RB_Rect.X;
                PointLT.Y = LT_Rect.Y; PointLB.Y = LB_Rect.Y; PointRT.Y = RT_Rect.Y; PointRB.Y = RB_Rect.Y;
                this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeAll;
            }
        }

       
        private void txtRecipeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnCreateRecipe.PerformClick();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteRecipe(clsGlobalDefinations.iArrRecipeIdList[dgvRecipeList.SelectedRows[0].Index]);
        }

        private void deleteRecipe(int RecipeId)
        {
            clsGlobalDefinations.OpenConnection();
            clsGlobalDefinations.objstructRecipeParams.RecipeId= RecipeId;
            clsGlobalDefinations.RecipeDataDML(2);
            clsGlobalDefinations.CloseConnection();
            loadProductFromDB();
        }

        private void closeCompareOCR_Click(object sender, EventArgs e)
        {
            pnlCompareOCR.Visible = false;
            pnlPreview.Visible = true;
            pnlPreview.BringToFront();

            IsCompareOCR = false;
        }

        private void pnl_cam_1_create_receipe_MouseMove(object sender, MouseEventArgs e)
        {
            
                if (IS_ROI_Start)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if (flg_LT)
                        {
                            int tempx_chk = LT_Rect.X - (tempX - e.Location.X);
                            int tempy_chk = LT_Rect.Y - (tempY - e.Location.Y);
                            int tempx1_chk = RB_Rect.X;
                            int tempy1_chk = RB_Rect.Y;
                            if (tempx_chk < tempx1_chk - 5 && tempy_chk < tempy1_chk - 5 && tempx_chk > 0 && tempy_chk > 0)
                            {
                                LT_Rect.X = LT_Rect.X - (tempX - e.Location.X);
                                LT_Rect.Y = LT_Rect.Y - (tempY - e.Location.Y);
                                tempX = e.Location.X;
                                tempY = e.Location.Y;
                                LB_Rect.X = LT_Rect.X;
                                RT_Rect.Y = LT_Rect.Y;

                                L_Rect.X = LT_Rect.X;
                                L_Rect.Y = (LT_Rect.Y + LB_Rect.Y) / 2;

                                T_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;
                                T_Rect.Y = LT_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_LB)
                        {
                            int tempx_chk = LB_Rect.X - (tempX - e.Location.X);
                            int tempy_chk = LT_Rect.Y;
                            int tempx1_chk = RB_Rect.X;
                            int tempy1_chk = LB_Rect.Y - (tempY - e.Location.Y);
                            if (tempx_chk < tempx1_chk - 5 && tempy_chk < tempy1_chk - 5 && tempx_chk > 0 && tempy_chk > 0 && (tempy1_chk + Rect_Size) < pnl_cam_1_create_receipe.Height)
                            {
                                LB_Rect.X = LB_Rect.X - (tempX - e.Location.X);
                                LB_Rect.Y = LB_Rect.Y - (tempY - e.Location.Y);
                                tempX = e.Location.X;
                                tempY = e.Location.Y;
                                LT_Rect.X = LB_Rect.X;
                                RB_Rect.Y = LB_Rect.Y;

                                L_Rect.X = LT_Rect.X;
                                L_Rect.Y = (LT_Rect.Y + LB_Rect.Y) / 2;

                                B_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;
                                B_Rect.Y = RB_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_RB)
                        {
                            int tempx_chk = LT_Rect.X;
                            int tempy_chk = LT_Rect.Y;
                            int tempx1_chk = RB_Rect.X - (tempX - e.Location.X);
                            int tempy1_chk = RB_Rect.Y - (tempY - e.Location.Y);
                            if (tempx_chk < tempx1_chk - 5 && tempy_chk < tempy1_chk - 5 && tempx_chk > 0 && tempy_chk > 0 && (tempx1_chk + Rect_Size) < pnl_cam_1_create_receipe.Width && (tempy1_chk + Rect_Size) < pnl_cam_1_create_receipe.Height)
                            {
                                RB_Rect.X = RB_Rect.X - (tempX - e.Location.X);
                                RB_Rect.Y = RB_Rect.Y - (tempY - e.Location.Y);
                                tempX = e.Location.X;
                                tempY = e.Location.Y;
                                RT_Rect.X = RB_Rect.X;
                                LB_Rect.Y = RB_Rect.Y;

                                R_Rect.X = RT_Rect.X;
                                R_Rect.Y = (RT_Rect.Y + RB_Rect.Y) / 2;

                                B_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;
                                B_Rect.Y = RB_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_RT)
                        {
                            int tempx_chk = LT_Rect.X;
                            int tempy_chk = RT_Rect.Y - (tempY - e.Location.Y);
                            int tempx1_chk = RT_Rect.X - (tempX - e.Location.X);
                            int tempy1_chk = RB_Rect.Y;
                            if (tempx_chk < tempx1_chk - 5 && tempy_chk < tempy1_chk - 5 && tempx_chk > 0 && tempy_chk > 0 && (tempx1_chk + Rect_Size) < pnl_cam_1_create_receipe.Width)
                            {
                                RT_Rect.X = RT_Rect.X - (tempX - e.Location.X);
                                RT_Rect.Y = RT_Rect.Y - (tempY - e.Location.Y);
                                tempX = e.Location.X;
                                tempY = e.Location.Y;
                                RB_Rect.X = RT_Rect.X;
                                LT_Rect.Y = RT_Rect.Y;

                                R_Rect.X = RT_Rect.X;
                                R_Rect.Y = (RT_Rect.Y + RB_Rect.Y) / 2;

                                T_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;
                                T_Rect.Y = RT_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_T)
                        {
                            int tempy_chk = T_Rect.Y - (tempY - e.Location.Y);
                            int tempy1_chk = B_Rect.Y;
                            if (tempy_chk < tempy1_chk - 5 && tempy_chk > 0)
                            {
                                T_Rect.Y = T_Rect.Y - (tempY - e.Location.Y);
                                tempY = e.Location.Y;
                                LT_Rect.Y = T_Rect.Y;
                                RT_Rect.Y = T_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_R)
                        {
                            int tempx_chk = L_Rect.X;
                            int tempx1_chk = R_Rect.X - (tempX - e.Location.X);
                            if (tempx_chk < tempx1_chk - 5 && tempx_chk > 0)
                            {
                                R_Rect.X = R_Rect.X - (tempX - e.Location.X);
                                tempX = e.Location.X;
                                RT_Rect.X = R_Rect.X;
                                RB_Rect.X = R_Rect.X;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_L)
                        {
                            int tempx_chk = L_Rect.X - (tempX - e.Location.X);
                            int tempx1_chk = R_Rect.X;
                            if (tempx_chk < tempx1_chk - 5 && tempx_chk > 0)
                            {
                                L_Rect.X = L_Rect.X - (tempX - e.Location.X);
                                tempX = e.Location.X;
                                LT_Rect.X = L_Rect.X;
                                LB_Rect.X = L_Rect.X;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_B)
                        {
                            int tempy_chk = T_Rect.Y;
                            int tempy1_chk = B_Rect.Y - (tempY - e.Location.Y);
                            if (tempy_chk < tempy1_chk - 5 && tempy_chk > 0)
                            {
                                B_Rect.Y = B_Rect.Y - (tempY - e.Location.Y);
                                tempY = e.Location.Y;
                                LB_Rect.Y = B_Rect.Y;
                                RB_Rect.Y = B_Rect.Y;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }
                        else if (flg_M)
                        {
                            int tempx_chk = M_Rect.X - (tempX - e.Location.X) - (Rect_Size / 2);
                            int tempy_chk = M_Rect.Y - (tempY - e.Location.Y) - (Rect_Size / 2);
                            int tempx1_chk = tempx_chk + M_Rect.Width - (Rect_Size / 2);
                            int tempy1_chk = tempy_chk + M_Rect.Height - (Rect_Size / 2);
                            if (tempx_chk < tempx1_chk - 5 && tempy_chk < tempy1_chk - 5 && tempx_chk > 0 && tempy_chk > 0 && (tempx1_chk + Rect_Size) < pnl_cam_1_create_receipe.Width - (Rect_Size / 2) && (tempy1_chk + Rect_Size) < pnl_cam_1_create_receipe.Height - (Rect_Size / 2))
                            {
                                M_Rect.X = M_Rect.X - (tempX - e.Location.X);
                                M_Rect.Y = M_Rect.Y - (tempY - e.Location.Y);
                                tempX = e.Location.X;
                                tempY = e.Location.Y;
                                LT_Rect.X = M_Rect.X - (Rect_Size / 2);
                                LT_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                                RT_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                                RT_Rect.Y = LT_Rect.Y;

                                LB_Rect.X = LT_Rect.X;
                                LB_Rect.Y = M_Rect.Y + M_Rect.Height - (Rect_Size / 2);

                                RB_Rect.X = RT_Rect.X;
                                RB_Rect.Y = LB_Rect.Y;

                                L_Rect.X = M_Rect.X - (Rect_Size / 2);
                                L_Rect.Y = M_Rect.Y + (M_Rect.Height / 2) - (Rect_Size / 2);

                                T_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                                T_Rect.Y = M_Rect.Y - (Rect_Size / 2);

                                R_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                                R_Rect.Y = M_Rect.Y - (Rect_Size / 2) + (M_Rect.Height / 2);

                                B_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                                B_Rect.Y = M_Rect.Y - (Rect_Size / 2) + M_Rect.Height;
                                pnl_cam_1_create_receipe.Refresh();
                            }
                        }

                        T_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;
                        L_Rect.Y = (LT_Rect.Y + LB_Rect.Y) / 2;
                        R_Rect.Y = (LT_Rect.Y + LB_Rect.Y) / 2;
                        B_Rect.X = (LT_Rect.X + RB_Rect.X) / 2;


                        pnl_cam_1_create_receipe.Invalidate();
                    }

                    if (e.Location.X >= LT_Rect.X && e.Location.Y >= LT_Rect.Y && e.Location.X <= (LT_Rect.X + LT_Rect.Width) && e.Location.Y <= (LT_Rect.Y + LT_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
                    else if (e.Location.X >= RT_Rect.X && e.Location.Y >= RT_Rect.Y && e.Location.X <= (RT_Rect.X + RT_Rect.Width) && e.Location.Y <= (RT_Rect.Y + RT_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNESW;
                    else if (e.Location.X >= LB_Rect.X && e.Location.Y >= LB_Rect.Y && e.Location.X <= (LB_Rect.X + LB_Rect.Width) && e.Location.Y <= (LB_Rect.Y + LB_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNESW;
                    else if (e.Location.X >= RB_Rect.X && e.Location.Y >= RB_Rect.Y && e.Location.X <= (RB_Rect.X + RB_Rect.Width) && e.Location.Y <= (RB_Rect.Y + RB_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
                    else if (e.Location.X >= B_Rect.X && e.Location.Y >= B_Rect.Y && e.Location.X <= (B_Rect.X + B_Rect.Width) && e.Location.Y <= (B_Rect.Y + B_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNS;
                    else if (e.Location.X >= R_Rect.X && e.Location.Y >= R_Rect.Y && e.Location.X <= (R_Rect.X + R_Rect.Width) && e.Location.Y <= (R_Rect.Y + R_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeWE;
                    else if (e.Location.X >= T_Rect.X && e.Location.Y >= T_Rect.Y && e.Location.X <= (T_Rect.X + T_Rect.Width) && e.Location.Y <= (T_Rect.Y + T_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeNS;
                    else if (e.Location.X >= L_Rect.X && e.Location.Y >= L_Rect.Y && e.Location.X <= (L_Rect.X + L_Rect.Width) && e.Location.Y <= (L_Rect.Y + L_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeWE;
                    else if (e.Location.X >= (LT_Rect.X + LT_Rect.Width) && e.Location.Y >= (LT_Rect.Y + LT_Rect.Height) && e.Location.X <= (RB_Rect.X + RB_Rect.Width) && e.Location.Y <= (RB_Rect.Y + RB_Rect.Height))
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.SizeAll;
                    else
                        this.pnl_cam_1_create_receipe.Cursor = System.Windows.Forms.Cursors.Default;

            }
        }

        private void pnl_cam_1_create_receipe_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {

                if (IS_ROI_Start)
                {
                    flg_LB = false;
                    flg_RB = false;
                    flg_LT = false;
                    flg_RT = false;
                    flg_M = false;
                    flg_B = false;
                    flg_L = false;
                    flg_R = false;
                    flg_T = false;

                    tempX = 0;
                    tempY = 0;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Crash : " + e1.Message);
            }
        }

        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (trkZoomLevel.Value < 30)
                {
                    trkZoomLevel.Value = trkZoomLevel.Value + 1;
                    trkZoomLevel_Scroll(this, e);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(" pnl_ZoomIN_MouseClick Crash : " + e1.Message);
            }
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (trkZoomLevel.Value > 0)
                {
                    trkZoomLevel.Value = trkZoomLevel.Value - 1;
                    trkZoomLevel_Scroll(this, e);
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("pnl_ZoomOUT_MouseClick Crash : " + e1.Message);
            }
        }

        private void trkZoomLevel_Scroll(object sender, EventArgs e)
        {
            Zoom_TP_Val = trkZoomLevel.Value;
            pnl_cam_1_create_receipe.Width = Tp_pct_Width + (Zoom_TP_Val * 100);
            pnl_cam_1_create_receipe.Height = Tp_pct_Height + (Zoom_TP_Val * 60);
           
        }

        private void FrmTeching_Load(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "RecipeManagement";

            string[] filePaths = Directory.GetFiles(Application.StartupPath + "\\tessdata\\", "*.traineddata");
            cmbTrainFile.Items.Clear();
            for (int i = 0; i < filePaths.Length; ++i)
            {
                cmbTrainFile.Items.Add(filePaths[i].Substring((Application.StartupPath + "\\tessdata\\").Length, 3));
            }
            tmr_offline_Capture.Start();
            initRect();
            loadDefaultParam();
            loadProductFromDB();

            //DataSet ds = clsGlobalDefinations.getRecipeData();

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    MessageBox.Show(ds.Tables[0].Rows[i]["RecipeName"].ToString() );
            //}

        }

        public void loadOfflineSimulator()
        {
            if (!clsGlobalDefinations.IsOfflineSimOpen)
            {
                Offline_simulator = new Offline_Simulator();
                Offline_simulator.Visible = true;
                Offline_simulator.BringToFront();
                clsGlobalDefinations.IsOfflineSimOpen = true;
            }
        }

        public void unloadOfflineSimulator()
        {
            if (clsGlobalDefinations.IsOfflineSimOpen)
            {
                clsGlobalDefinations.IsOfflineSimOpen = false;
                Offline_simulator.Visible = false;
                Offline_simulator.SendToBack();
                Offline_simulator.Dispose();                
            }
        }
        public DataRow loadSingleFromDB(int RecipeId)
        {
            clsGlobalDefinations.OpenConnection();
            DataSet ds = clsGlobalDefinations.getRecipeData(RecipeId);
            clsGlobalDefinations.CloseConnection();
            return ds.Tables[0].Rows[0];
        }
        public void loadProductFromDB()
        {
            clsGlobalDefinations.iRecipeSRnoCount = 0;
            dgvRecipeList.ClearSelection();
            dgvRecipeList.Rows.Clear();
            clsGlobalDefinations.OpenConnection();
            DataSet ds = clsGlobalDefinations.getRecipeData();
            clsGlobalDefinations.iArrRecipeIdList = new int[ds.Tables[0].Rows.Count];
            clsGlobalDefinations.strArrRecipeNameList = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvRecipeList.Rows.Add(++clsGlobalDefinations.iRecipeSRnoCount, ds.Tables[0].Rows[i]["RecipeName"].ToString(),ds.Tables[0].Rows[i]["UpdatedDate"].ToString());
                clsGlobalDefinations.iArrRecipeIdList[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["RecipeId"]);
                clsGlobalDefinations.strArrRecipeNameList[i] = ds.Tables[0].Rows[i]["RecipeName"].ToString();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                clsGlobalDefinations.objstructRecipeParams.RecipeId = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["RecipeId"]);
                clsGlobalDefinations.objstructRecipeParams.RecipeId++;
            }
            
            clsGlobalDefinations.CloseConnection();
        }

        public void tmr_offline_Capture_Tick(object sender, EventArgs e)
        {
            if (IS_Grab_offline_1_CB )
            {
                IS_Grab_offline_1_CB = false;
                Bitmap b = (Bitmap)System.Drawing.Image.FromFile(Offline_Simulator_Image_Path_1_CB).Clone();
                if (clsGlobalDefinations.isPreviewStarted)
                {
                    if (Offline_simulator.index_1_image+1 == Offline_simulator.Total_index_1_image)
                    {
                        unloadOfflineSimulator();
                        btnStopPreview.PerformClick();
                        btnSaveRecipeTeach.PerformClick();
                        MessageBox.Show("Preview Autocompleted and saved recipe automatically!", "Let's Textify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    pbPreviewImage.Image = b;
                    txtPreviewResult.Text = getOCRResult();
                    AddPage(wordDoc, txtPreviewResult.Text);
                }
                else
                {
                    pnl_cam_1_create_receipe.Image = b;
                }
                ImageWidth = b.Width;
                ImageHeight = b.Height;
                pnl_cam_1_create_receipe.Refresh();
                //tmr_offline_Capture.Stop();
            }
        }

        private void pnl_cam_1_create_receipe_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (IS_ROI_Start)
                {
                    M_Rect.X = LT_Rect.X + (Rect_Size / 2);
                    M_Rect.Y = LT_Rect.Y + (Rect_Size / 2);
                    M_Rect.Width = RB_Rect.X - LT_Rect.X;
                    M_Rect.Height = RB_Rect.Y - LT_Rect.Y;

                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(LT_Rect.X, LT_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(RB_Rect.X, RB_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(RT_Rect.X, RT_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(LB_Rect.X, LB_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Red, new System.Drawing.Rectangle(M_Rect.X, M_Rect.Y, M_Rect.Width, M_Rect.Height));

                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(L_Rect.X, L_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(R_Rect.X, R_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(T_Rect.X, T_Rect.Y, Rect_Size, Rect_Size));
                    e.Graphics.DrawRectangle(Pens.Blue, new System.Drawing.Rectangle(B_Rect.X, B_Rect.Y, Rect_Size, Rect_Size));

                    e.Graphics.FillRectangle(Brushes.Blue, LT_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, RB_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, RT_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, LB_Rect);

                    e.Graphics.FillRectangle(Brushes.Blue, L_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, R_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, T_Rect);
                    e.Graphics.FillRectangle(Brushes.Blue, B_Rect);

                    //int BlockWidth = M_Rect.Width / 4;
                    //int BlockHeight = M_Rect.Height / 4;
                    //for (int i = 1; i < 4; ++i)
                    //{
                    //    e.Graphics.DrawLine(Pens.Blue, new System.Drawing.Point(M_Rect.X + (BlockWidth * i), M_Rect.Y), new System.Drawing.Point(M_Rect.X + (BlockWidth * i), M_Rect.Y + M_Rect.Height));
                    //}
                    //for (int j = 1; j < 4; ++j)
                    //{
                    //    e.Graphics.DrawLine(Pens.Blue, new System.Drawing.Point(M_Rect.X, M_Rect.Y + (BlockHeight * j)), new System.Drawing.Point(M_Rect.X + M_Rect.Width, M_Rect.Y + (BlockHeight * j)));
                    //}
                }
            }
            catch (Exception e1)
            {
                //MessageBox.Show("Crash : " + e1.Message);
            }
        }
        void initRect()
        {
            

            try
            {
                IS_ROI_Start = true;
                flg_M = false;
                flg_LT = false;
                flg_RB = false;
                flg_LB = false;
                flg_RT = false;
                flg_L = false;
                flg_R = false;
                flg_B = false;
                flg_T = false;

                M_Rect.X = (pnl_cam_1_create_receipe.Width / 2) - 200;
                M_Rect.Y = (pnl_cam_1_create_receipe.Height / 2) - 150;
                M_Rect.Width = 400;
                M_Rect.Height = 300;

                LT_Rect.X = M_Rect.X - (Rect_Size / 2);
                LT_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                LT_Rect.Width = Rect_Size;
                LT_Rect.Height = Rect_Size;

                RT_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                RT_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                RT_Rect.Width = Rect_Size;
                RT_Rect.Height = Rect_Size;

                LB_Rect.X = M_Rect.X - (Rect_Size / 2);
                LB_Rect.Y = M_Rect.Y + M_Rect.Height - (Rect_Size / 2);
                LB_Rect.Width = Rect_Size;
                LB_Rect.Height = Rect_Size;

                RB_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                RB_Rect.Y = M_Rect.Y + M_Rect.Height - (Rect_Size / 2);
                RB_Rect.Width = Rect_Size;
                RB_Rect.Height = Rect_Size;

                L_Rect.X = M_Rect.X - (Rect_Size / 2);
                L_Rect.Y = M_Rect.Y + (M_Rect.Height / 2) - (Rect_Size / 2);
                L_Rect.Width = Rect_Size;
                L_Rect.Height = Rect_Size;

                T_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                T_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                T_Rect.Width = Rect_Size;
                T_Rect.Height = Rect_Size;

                R_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                R_Rect.Y = M_Rect.Y - (Rect_Size / 2) + (M_Rect.Height / 2);
                R_Rect.Width = Rect_Size;
                R_Rect.Height = Rect_Size;

                B_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                B_Rect.Y = M_Rect.Y - (Rect_Size / 2) + M_Rect.Height;
                B_Rect.Width = Rect_Size;
                B_Rect.Height = Rect_Size;

                tempX = 0;
                tempY = 0;
            }
            catch (Exception ex)
            {
               
            }
            
        }
        void initRect2(int x, int y, int widht, int height)
        {


            try
            {
                IS_ROI_Start = true;
                flg_M = false;
                flg_LT = false;
                flg_RB = false;
                flg_LB = false;
                flg_RT = false;
                flg_L = false;
                flg_R = false;
                flg_B = false;
                flg_T = false;

                M_Rect.X = x;
                M_Rect.Y = y;
                M_Rect.Width = widht;
                M_Rect.Height = height;

                LT_Rect.X = M_Rect.X - (Rect_Size / 2);
                LT_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                LT_Rect.Width = Rect_Size;
                LT_Rect.Height = Rect_Size;

                RT_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                RT_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                RT_Rect.Width = Rect_Size;
                RT_Rect.Height = Rect_Size;

                LB_Rect.X = M_Rect.X - (Rect_Size / 2);
                LB_Rect.Y = M_Rect.Y + M_Rect.Height - (Rect_Size / 2);
                LB_Rect.Width = Rect_Size;
                LB_Rect.Height = Rect_Size;

                RB_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                RB_Rect.Y = M_Rect.Y + M_Rect.Height - (Rect_Size / 2);
                RB_Rect.Width = Rect_Size;
                RB_Rect.Height = Rect_Size;

                L_Rect.X = M_Rect.X - (Rect_Size / 2);
                L_Rect.Y = M_Rect.Y + (M_Rect.Height / 2) - (Rect_Size / 2);
                L_Rect.Width = Rect_Size;
                L_Rect.Height = Rect_Size;

                T_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                T_Rect.Y = M_Rect.Y - (Rect_Size / 2);
                T_Rect.Width = Rect_Size;
                T_Rect.Height = Rect_Size;

                R_Rect.X = M_Rect.X + M_Rect.Width - (Rect_Size / 2);
                R_Rect.Y = M_Rect.Y - (Rect_Size / 2) + (M_Rect.Height / 2);
                R_Rect.Width = Rect_Size;
                R_Rect.Height = Rect_Size;

                B_Rect.X = M_Rect.X - (Rect_Size / 2) + (M_Rect.Width / 2);
                B_Rect.Y = M_Rect.Y - (Rect_Size / 2) + M_Rect.Height;
                B_Rect.Width = Rect_Size;
                B_Rect.Height = Rect_Size;

                tempX = 0;
                tempY = 0;
            }
            catch (Exception ex)
            {

            }

        }
        public string getWhiteListAplhabets(string DataType)
        {
            if (DataType == "Int")
            {
                return "0123456789";
            }
            else if (DataType == "UInt")
            {
                return "0123456789-";
            }
            else if (DataType == "Float")
            {
                return "0123456789.";
            }
            else if (DataType == "UFloat")
            {
                return "0123456789.-";
            }
            else if (DataType == "Capital-Letters")
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ.";
            }
            else if (DataType == "Small-Letters")
            {
                return "abcdefghijklmnopqrstuvwxyz.";
            }
            else if (DataType == "Capital-Small-Letters")
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ.abcdefghijklmnopqrstuvwxyz";
            }
            else if (DataType == "Special-Chars")
            {
                return ".~`!@#$%^&*()_+-?={[]};:'\",/|\\";
            }
            else if (DataType == "ASCII")
            {
                return " ABCDEFGHIJKLMNOPQRSTUVWXYZ.abcdefghijklmnopqrstuvwxyz~`!@#$%^&*()_+-={[]};:'\",/?|\\ \n";
            }
            else if (DataType == "Custom")
            {
                return "";
            }
            else
            {
                return " \nABCDEFGHIJKLMNOPQRSTUVWXYZ.abcdefghijklmnopqrstuvwxyz~`!@#$%^&*()_+-={[]};:'\",/?|\\";
            }

        }
        public string getPreProcessedData(string OldResult)
        {
            string recognizedText = OldResult;

            // Remove non-alphanumeric characters and leading/trailing whitespaces
            recognizedText = Regex.Replace(recognizedText, "[^a-zA-Z0-9]", "");
            recognizedText = recognizedText.Trim();

            // Spell checking (using NHunspell)
            using (Hunspell hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                string[] words = recognizedText.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (!hunspell.Spell(words[i]))
                    {
                        List<string> suggestions = hunspell.Suggest(words[i]);
                        if (suggestions.Count > 0)
                        {
                            words[i] = suggestions[0]; // Replace with the first suggested word
                        }
                    }
                }
                recognizedText = string.Join(" ", words);
                return recognizedText;//AddPunctuation(recognizedText);
            }
        }
        public string AddPunctuation(string str)
        {
            // Input string
            var input = "This is a sentence without punctuation";

            // Specify the punctuation marks you want to add
            var punctuationMarks = new[] { ".", ",", "!" };

            // Split the input string into words
            var words = input.Split(' ');

            // Process each word and add punctuation
            var processedWords = new List<string>();
            foreach (var word in words)
            {
                var modifiedWord = word;

                // Add punctuation to the modified word
                foreach (var punctuation in punctuationMarks)
                {
                    var modifiedWordWithPunctuation = word + punctuation;
                    if (!string.Equals(modifiedWordWithPunctuation, word, StringComparison.OrdinalIgnoreCase))
                    {
                        modifiedWord = modifiedWordWithPunctuation;
                        break;
                    }
                }

                processedWords.Add(modifiedWord);
            }

            // Reconstruct the string with added punctuation
            return string.Join(" ", processedWords);

        }
    }
}
