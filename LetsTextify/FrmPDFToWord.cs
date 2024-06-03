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
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
//using Novacode;
using System.Diagnostics;
using Xceed.Words.NET;
using Path = System.IO.Path;
using sun.swing;

namespace LetsTextify
{
    public partial class FrmPDFToWord : Form
    {
        public FrmPDFToWord()
        {
            InitializeComponent();
        }

        string fileName = "tmp";
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            //  convertPDFToWord();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.Title = "Select a PDF File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                fileName = Path.GetFileName(selectedFilePath).Split('.')[0];
                fileName+= "_converted.doc";
                ConvertPdfToWord(selectedFilePath, fileName);
            }
        }

        public void ConvertPdfToWord(string inputPdfPath, string outputWordPath)
        {
            // Read the PDF file
            PdfReader reader = new PdfReader(inputPdfPath);

            // Create a StringBuilder object to store the text content
            StringBuilder textContent = new StringBuilder();

            // Loop through each page of the PDF and extract the text content
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                // Extract the text from the current page using PdfTextExtractor
                textContent.Append(PdfTextExtractor.GetTextFromPage(reader, page));
            }

            // Close the reader
            reader.Close();

            // Write the text content to a Word document
            File.WriteAllText(outputWordPath, textContent.ToString());
        }

        private void convertPDFToWord()
        {
            //reading the pdf file data in a string

            PDDocument doc = null;

            doc = PDDocument.load(@"C:\Users\AjayPandya\Desktop\clg Presentation\LetsTextifyFinal.pdf");
            PDFTextStripper textStrip = new PDFTextStripper();

        string strPDFText = textStrip.getText(doc);

        doc.close();

        //define the path where you want to save the doc file
        string fn = @"C:\Users\AjayPandya\Desktop\clg Presentation\sample.docx";
            

            var wordDoc = DocX.Create(fn);

            //insert data in it
            wordDoc.InsertParagraph(strPDFText);

            //save the word file
            wordDoc.Save();

            //open the word file
            Process.Start("WINWORD.EXE", fn);

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

        private void FrmPDFToWord_Load(object sender, EventArgs e)
        {
            clsGlobalDefinations.stCurrentScreenName = "PDFToWord";
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    string filePath = fileName; // Replace with the actual file path

                    try
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationPath = Path.Combine(selectedFolderPath, fileName);
                        File.Copy(filePath, destinationPath);

                        MessageBox.Show($"File saved successfully to '{destinationPath}'.");
                        File.Delete(fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the file:\n{ex.Message}");
                    }
                }
            }
        }
    }
}
