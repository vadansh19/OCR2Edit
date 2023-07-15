using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using iTextSharp.text;

namespace LetsTextify
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            convertPDFToWord();
        }

        private void convertPDFToWord()
        {
            //PdfReader reader = new PdfReader("path/to/pdf/file.pdf");

            //// Initialize a string builder to store the extracted text
            //StringBuilder sb = new StringBuilder();

            //// Extract text from each page of the PDF file
            //for (int i = 1; i <= reader.NumberOfPages; i++)
            //{
            //    string text = PdfTextExtractor.GetTextFromPage(reader, i);

            //    // Remove any unwanted characters
            //    text = Regex.Replace(text, @"[\n\r]+", " ");

            //    sb.Append(text);
            //}

            //// Create a new Word document
            //Application app = new Application();
            //Document doc = app.Documents.Add();

            //// Insert the extracted text into the Word document
            //Range range = doc.Range(0, 0);
            //range.Text = sb.ToString();

            //// Save the Word document as a DOCX file
            //doc.SaveAs2("path/to/word/file.docx", WdSaveFormat.wdFormatDocumentDefault);

            //// Close the Word document and release resources
            //doc.Close();
            //app.Quit();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "PDFToWord";
        }
    }
}
