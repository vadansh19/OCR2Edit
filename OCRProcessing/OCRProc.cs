using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using Emgu.CV;
using System.Security.Cryptography;
using System.Threading;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using OpenTK.Graphics.ES11;

namespace OCRProcessing
{
    public class OCRProc
    {
        //Global Variables
        private TesseractEngine tesseractEngine;
      
        public int PreProcessImage(string strImagePath,Rectangle rect,int iScaleFactor,
            int iErodeValue, int iDilateValue, int iSmoothValue,int iThreshType, int iThreshMinValue, int iThreshMaxValue, int iCharMinWidth, 
            int iCharMinHeight, int iCharMaxWidth, int iCharMaxHeight, bool IsWhiteOnBlack)
        {
            int iRetValue = 0;

            Bitmap b = cropImage((Bitmap)Image.FromFile(strImagePath), rect);
            
            b.Save("tmp.bmp");
            Mat lImg = CvInvoke.Imread("tmp.bmp", LoadImageType.Grayscale);
            Mat lOutImage = CvInvoke.Imread(strImagePath, LoadImageType.Grayscale);

            int iImageWidth = lImg.Width;
            int iImageHeight = lImg.Height;
            double multipleFactor = MultipleFactorValue(iScaleFactor);

            Size outputSize = new Size(Convert.ToInt32(iImageWidth* multipleFactor), Convert.ToInt32(iImageHeight * multipleFactor));

            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(outputSize);
            CvInvoke.Resize(lImg, outputImage, outputSize);

            //Smooth
            if (iSmoothValue > 0)
                CvInvoke.GaussianBlur(outputImage, outputImage, new Size(iSmoothValue, iSmoothValue), 0, 0);
            
            //Threshold
            if(iThreshType == 0)
                CvInvoke.Threshold(outputImage, lOutImage, iThreshMinValue, iThreshMaxValue, ThresholdType.Binary);
            else
                CvInvoke.AdaptiveThreshold(outputImage, lOutImage, 255, AdaptiveThresholdType.MeanC,ThresholdType.Binary,3,0);

            //Erode
            Mat se = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            MCvScalar borderValue = new MCvScalar(255);
            if(iErodeValue > 0)
            CvInvoke.Erode(lOutImage, lOutImage, se, new Point(-1,-1),iErodeValue,0, borderValue);

            //Dilate
            if (iDilateValue > 0)
                CvInvoke.Dilate(lOutImage, lOutImage, se, new Point(-1, -1), iDilateValue, 0, borderValue);

            if (IsWhiteOnBlack)
                CvInvoke.BitwiseNot(lOutImage, lOutImage);
            CvInvoke.Imwrite("1.bmp", lOutImage);
            return iRetValue;
        }

        double MultipleFactorValue (int iScaleFactor)
        {
            double multipleFactor = 1;

            if (iScaleFactor == -2)
                multipleFactor = 0.5;
            else if (iScaleFactor == -1)
                multipleFactor = 0.75;
            else if (iScaleFactor == 0)
                multipleFactor = 1;
            else if (iScaleFactor == 1)
                multipleFactor = 1.5;
            else if (iScaleFactor == 2)
                multipleFactor = 2;
            else if (iScaleFactor == 3)
                multipleFactor = 3;
            else if (iScaleFactor == 4)
                multipleFactor = 4;
            else if (iScaleFactor == 5)
                multipleFactor = 5;
            else if (iScaleFactor == 6)
                multipleFactor = 6;
            else if (iScaleFactor == 7)
                multipleFactor = 7;
            else if (iScaleFactor == 8)
                multipleFactor = 8;

            return multipleFactor;
        }

        public string ImageToText(string strImagePath, int iPSMMode, int iOEMType, string strTrainFile, string strWhitelistAlphabets)
        {
            string retString = "";

            EngineMode engineMode = getEngineMode(iOEMType);
            tesseractEngine = new TesseractEngine("", strTrainFile, engineMode);
            tesseractEngine.SetVariable("tessedit_char_whitelist", strWhitelistAlphabets);
            tesseractEngine.SetVariable("tessedit_image_border", "2");

            tesseractEngine.DefaultPageSegMode = getTesseractGetSegementMode(iPSMMode);

            var l_PixImage = Pix.LoadFromFile(strImagePath);
            var tessProcess = tesseractEngine.Process(l_PixImage);
            retString = tessProcess.GetText(); 
            tessProcess.Dispose();

            return retString;
        }

        public EngineMode getEngineMode(int engineMode)
        {
            try
            {
                EngineMode retengineMode = EngineMode.Default;

                if (engineMode == 0)
                    retengineMode = EngineMode.TesseractOnly;
                else if (engineMode == 1)
                    retengineMode = EngineMode.LstmOnly;
                else if (engineMode == 2)
                    retengineMode = EngineMode.TesseractAndLstm;
                else if (engineMode == 3)
                    retengineMode = EngineMode.Default;
                else
                    retengineMode = EngineMode.Default;
                return retengineMode;
            }
            catch (Exception e)
            {
                return EngineMode.Default;
            }
        }

        public PageSegMode getTesseractGetSegementMode(int selectedItem)
        {
            if (selectedItem == 0)
                return PageSegMode.OsdOnly;
            else if (selectedItem == 1)
                return PageSegMode.AutoOsd;
            else if (selectedItem == 2)
                return PageSegMode.AutoOnly;
            else if (selectedItem == 3)
                return PageSegMode.Auto;
            else if (selectedItem == 4)
                return PageSegMode.SingleColumn;
            else if (selectedItem == 5)
                return PageSegMode.SingleBlockVertText;
            else if (selectedItem == 6)
                return PageSegMode.SingleBlock;
            else if (selectedItem == 7)
                return PageSegMode.SingleLine;
            else if (selectedItem == 8)
                return PageSegMode.SingleWord;
            else if (selectedItem == 9)
                return PageSegMode.CircleWord;
            else if (selectedItem == 10)
                return PageSegMode.SingleChar;
            else if (selectedItem == 11)
                return PageSegMode.SparseText;
            else if (selectedItem == 12)
                return PageSegMode.SparseTextOsd;
            else if (selectedItem == 13)
                return PageSegMode.RawLine;
            else
                return PageSegMode.Auto;
        }

        public int RoateWholeImage(string strImagePath, int iRotateDegrees)
        {
            int iRetValue = 0;
            return iRetValue;
        }
        private Bitmap cropImage(Bitmap img, Rectangle cropArea)
        {
            try
            {
                return img.Clone(cropArea, img.PixelFormat);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }
    }
}
