using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LetsTextify
{
    public static class clsGlobalDefinations
    {
       
        public struct structRecipeParams
        {
            public int RecipeId;
            public string RecipeName;
            public Rectangle ROI_Rect;
            public string TrainFile;
            public string Datatype;
            public int PSMValue;
            public int OEMValue;
            public int ScaleFactor;
            public int Erode;
            public int Dilate;
            public int Smooth;
            public int ThresholdMethod;
            public int ThresholdMin;
            public int ThresholdMax;
            public int CharMinWidth;
            public int CharMinHight;
            public int CharMaxWidth;
            public int CharMaxHeight;
            public bool IsWhiteOnBlack;

        }
        public static structRecipeParams objstructRecipeParams;
        public static bool isFormAlreadyOpened = false;
        public static bool isFormAlreadyOpenedPreview = false;
        public static MySqlConnection objDbConn;
        public static MySqlCommand objDbCommand;
        public static string strConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public static MySqlDataAdapter objDbAdapter;
        public static int iRecipeSRnoCount = 0;
        public static bool isEditRecipe = false;
        public static int []iArrRecipeIdList;

        public static bool isPreviewStarted = false;
        public static bool IsOfflineSimOpen = false;
        public static string stCurrentScreenName = "Dashboard";

        public static void OpenConnection()
        {
        
            try
            {   
                objDbConn = new MySqlConnection();
                objDbConn.ConnectionString = clsGlobalDefinations.strConnectionString;
                objDbConn.Open();
               // MessageBox.Show("Connected.....");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("not  Connected.....");
            }
           
        }

        public static void CloseConnection()
        {

            try
            {
                objDbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Close connection error.....");
            }

        }


        public static DataSet getDataset(string SpName, Hashtable SpParam)
        {
            try
            {
                int iRetValue = 0;
                //iRetValue = OpenConnection();
                if (iRetValue != 0)
                {
                    return null;
                }
                objDbCommand = new MySqlCommand();
                objDbCommand.Connection = objDbConn;
                objDbCommand.CommandText = SpName;
                objDbCommand.CommandType = CommandType.StoredProcedure;
                objDbCommand.CommandTimeout = 0;
                if (SpParam.Count > 0)
                {
                    foreach (string paramValue in SpParam.Keys)
                    {

                        //MessageBox.Show(paramValue);
                        objDbCommand.Parameters.AddWithValue(paramValue, SpParam[paramValue]);
                    }
                }
                DataSet objDs = new DataSet();
                //MessageBox.Show(objDbCommand.ToString());
                objDbAdapter = new MySqlDataAdapter(objDbCommand);
                objDbAdapter.Fill(objDs);
                //iRetValue = CloseConnection();
                if (iRetValue != 0)
                {
                    return null;
                }
                // objDs.WriteXml("/home/t13/Shubham/test.xml");
                return objDs;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString()+ Environment.NewLine + ex.StackTrace +Environment.NewLine + ex.Message   );
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                //objclsGlobal.LogEvent(-1, "clsSQLHelper : getDataset : ErrorCode : -77, ErrorMessage : " + ex.Message + ", StackTrace : " + ex.StackTrace);
                return null;
            }
        }

        //public static DataSet getData(int RecipeID, string RecipeName, int ROIx, int ROIy, int ROIWidth, int ROIHeight, string TrainFile, string DataType, int PSMValue, int OEMValue, int ScaleFactor, int Erode, int Dilate, int smooth, string ThresholdMethod, int ThresholdMin, int ThresholdMax, int CharMinWidth, int CharMinHeight, int CharMaxWidth, int CharMaxHeight, int IsWhiteOnBlack, bool OpreationMode   )
        //{
        //    DataSet ds;
        //    Hashtable objHashtable = new Hashtable();
        //    objHashtable.Add("@RecipeId", RecipeID);
        //    objHashtable.Add("@RecipeName", RecipeName);
        //    objHashtable.Add("@ROIx", ROIx);
        //    objHashtable.Add("@ROIy", ROIy);
        //    objHashtable.Add("@ROIWidth", ROIWidth);
        //    objHashtable.Add("@ROIHeight", ROIHeight);
        //    objHashtable.Add("@TrainFile", TrainFile);
        //    objHashtable.Add("@DataType", DataType);
        //    objHashtable.Add("@PSMValue", PSMValue);
        //    objHashtable.Add("@OEMValue", OEMValue);
        //    objHashtable.Add("@ScaleFactor", ScaleFactor);
        //    objHashtable.Add("@Erode", Erode);
        //    objHashtable.Add("@Dilate", Dilate);
        //    objHashtable.Add("@smooth", smooth);
        //    objHashtable.Add("@ThresholdMethod", ThresholdMethod);
        //    objHashtable.Add("@ThresholdMin", ThresholdMin);
        //    objHashtable.Add("@ThresholdMax", ThresholdMax);
        //    objHashtable.Add("@CharMinWidth", CharMinWidth);
        //    objHashtable.Add("@CharMinHeight", CharMinHeight);
        //    objHashtable.Add("@CharMaxWidth", CharMaxWidth);
        //    objHashtable.Add("@CharMaxHeight", CharMaxHeight);
        //    objHashtable.Add("@IsWhiteOnBlack", IsWhiteOnBlack);
        //    objHashtable.Add("@OpreationMode", OpreationMode);
        //    ds = getDataset("SP_Recipe_Getdata", objHashtable);
        //    return ds;
        //}

        public static DataSet getRecipeData(int RecipeID=0)
        {
            DataSet ds;
            Hashtable objHashtable = new Hashtable();
            objHashtable.Add("@In_RecipeId", RecipeID);
            ds = getDataset("SP_Recipe_Getdata", objHashtable);
            return ds;
        }

        public static void ExecuteStoredProcedure(string SpName, Hashtable SpParam)
        {

            try
            {
               
                    objDbCommand = new MySqlCommand();
                    objDbCommand.Connection = objDbConn;
                    objDbCommand.CommandText = SpName;
                    objDbCommand.CommandType = CommandType.StoredProcedure;
                    objDbCommand.CommandTimeout = 0;
                    if (SpParam.Count > 0)
                    {
                        foreach (string paramValue in SpParam.Keys)
                    { 
                            objDbCommand.Parameters.AddWithValue(paramValue, SpParam[paramValue]);
                        }
                    }
                   
                    objDbCommand.ExecuteNonQuery();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
              
            }

        }

        public static void RecipeDataDML(int OpreationMode)
        {

            Hashtable objHashtable = new Hashtable();
            objHashtable.Add("@In_RecipeId", clsGlobalDefinations.objstructRecipeParams.RecipeId);
            objHashtable.Add("@In_RecipeName", clsGlobalDefinations.objstructRecipeParams.RecipeName);
            objHashtable.Add("@In_ROIx", clsGlobalDefinations.objstructRecipeParams.ROI_Rect.X);
            objHashtable.Add("@In_ROIy", clsGlobalDefinations.objstructRecipeParams.ROI_Rect.Y);
            objHashtable.Add("@In_ROIWidth", clsGlobalDefinations.objstructRecipeParams.ROI_Rect.Width);
            objHashtable.Add("@In_ROIHeight", clsGlobalDefinations.objstructRecipeParams.ROI_Rect.Height);
            objHashtable.Add("@In_TrainFile", clsGlobalDefinations.objstructRecipeParams.TrainFile);
            objHashtable.Add("@In_DataType", clsGlobalDefinations.objstructRecipeParams.Datatype);
            objHashtable.Add("@In_PSMValue", clsGlobalDefinations.objstructRecipeParams.PSMValue);
            objHashtable.Add("@In_OEMValue", clsGlobalDefinations.objstructRecipeParams.OEMValue);
            objHashtable.Add("@In_ScaleFactor", clsGlobalDefinations.objstructRecipeParams.ScaleFactor);
            objHashtable.Add("@In_Erode", clsGlobalDefinations.objstructRecipeParams.Erode);
            objHashtable.Add("@In_Dilate", clsGlobalDefinations.objstructRecipeParams.Dilate);
            objHashtable.Add("@In_smooth", clsGlobalDefinations.objstructRecipeParams.Smooth);
            objHashtable.Add("@In_ThresholdMethod", clsGlobalDefinations.objstructRecipeParams.ThresholdMethod);
            objHashtable.Add("@In_ThresholdMin", clsGlobalDefinations.objstructRecipeParams.ThresholdMin);
            objHashtable.Add("@In_ThresholdMax", clsGlobalDefinations.objstructRecipeParams.ThresholdMax);
            objHashtable.Add("@In_CharMinWidth", clsGlobalDefinations.objstructRecipeParams.CharMinWidth);
            objHashtable.Add("@In_CharMinHight", clsGlobalDefinations.objstructRecipeParams.CharMinHight);
            objHashtable.Add("@In_CharMaxWidth", clsGlobalDefinations.objstructRecipeParams.CharMaxWidth);
            objHashtable.Add("@In_CharMaxHeight", clsGlobalDefinations.objstructRecipeParams.CharMaxHeight);
            objHashtable.Add("@In_IsWhiteOnBlack", clsGlobalDefinations.objstructRecipeParams.IsWhiteOnBlack);
            objHashtable.Add("@In_OperationMode", OpreationMode); 
            ExecuteStoredProcedure("SP_Recipe_DML", objHashtable);
        }

    }
}
