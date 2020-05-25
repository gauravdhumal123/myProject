using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreateTestCasesUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += new DoWorkEventHandler(createLogging);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorkerTestStep.DoWork += new DoWorkEventHandler(FindMissingSteps);
            backgroundWorkerTestStep.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerTestStep_ProgressChanged);
            backgroundWorkerTestStep.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerTestStep_RunWorkerCompleted);
            backgroundWorkerTestStep.WorkerReportsProgress = true;

            
        }

        private void SelectTPTSButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TPTSPathText.Text = openFileDialog1.FileName;
        }



        private void TPTSPathText_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TPTSPathText.Text = openFileDialog1.FileName;
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        void createLogging(object sender, DoWorkEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(OutputFileTextBox.Text);
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook ExcelWorkbook = Excel.Workbooks.Open(TPTSPathText.Text);
                Worksheet TPTSSheet = ExcelWorkbook.Sheets[1];

                int TotalRows = TPTSSheet.UsedRange.Rows.Count;
                for (int i = 5; i <= TotalRows; i++)
                {
                    backgroundWorker1.ReportProgress(i * 100 / TotalRows);
                    string TestCaseNumber = TPTSSheet.Cells[i, 1].Text;
                    int k = 0;
                    if (int.TryParse(TestCaseNumber, out k))
                    {
                        string SRS = TPTSSheet.Cells[i, 3].Text;
                        writer.WriteLine("[TestMethod]");
                        writer.WriteLine("[TestCategory()]");
                        writer.WriteLine("[Description(@\"" + TPTSSheet.Cells[i, 2].Text + " : " + SRS.Replace("\n", "").Replace("\"", "'") + "\")]");
                        writer.WriteLine("[Owner(\"" + OwnerTextBox.Text + "\")]");
                        writer.WriteLine("public void TC_" + TestCaseNumber + "()");
                        writer.WriteLine("{");
                        writer.WriteLine("\ttry");
                        writer.WriteLine("\t{");
                        int j;
                        for (j = i; (TPTSSheet.Cells[j, 1].Text.Equals(String.Empty) || j == i) && (j <= TotalRows); j++)
                        {
                            writer.WriteLine("\t\tCommonFunction.LogStatusForReport(Status.Pass, @\"Test Step Id:: " + TPTSSheet.Cells[j, 4].Text + " :: " + TPTSSheet.Cells[j, 6].Text.Replace("\n", "").Replace("\"", "'") + " " + TPTSSheet.Cells[j, 7].Text.Replace("\n", "").Replace("\"", "'") + "\");\n");
                        }
                        writer.WriteLine("\t\tCommonFunction.LogStatusForReport(Status.Pass, @\"Expected : " + SRS.Replace("\n", "").Replace("\"", "'") + "<br>\"");
                        writer.WriteLine("\t\t\t+@\"Actual : " + SRS.Replace("\n", "").Replace("\"", "'") + "\");");
                        writer.WriteLine("\t}");
                        writer.WriteLine("\tcatch (Exception e)");
                        writer.WriteLine("\t{");
                        writer.WriteLine("\t\tLogging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);");
                        writer.WriteLine("\t\tAssert.Fail(e.Message);");
                        writer.WriteLine("\t}");
                        writer.WriteLine("}");

                        i = j - 1;
                    }
                }
                writer.Close();
                ExcelWorkbook.Close(0);
                Excel.Quit();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message,"I am MAd at You!!!",MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
        }

        private void CreateLoggingButton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync();

        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            Process process = new Process();
            process.StartInfo.FileName = saveFileDialog1.FileName;
            //process.StartInfo.Arguments = ..... //your parameters
            process.Start();
        }

        private void SelectOutputButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            OutputFileTextBox.Text = saveFileDialog1.FileName;
        }

        private void OutputFileTextBox_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            OutputFileTextBox.Text = saveFileDialog1.FileName;


        }

        private void SelectTPFromAgileButton_Click(object sender, EventArgs e)
        {
            TPFromAgileOpenFile.ShowDialog();
            TPPath_TextBox.Text = TPFromAgileOpenFile.FileName;
        }

        private void HTMLResultPathButton_Click(object sender, EventArgs e)
        {
            openFileDialogHTMLReport.ShowDialog();
            ResultPathTextBox.Text = openFileDialogHTMLReport.FileName;
        }

        private void TPPath_TextBox_Click(object sender, EventArgs e)
        {
            TPFromAgileOpenFile.ShowDialog();
            TPPath_TextBox.Text = TPFromAgileOpenFile.FileName;
        }

        private void ResultPathTextBox_Click(object sender, EventArgs e)
        {
            openFileDialogHTMLReport.ShowDialog();
            ResultPathTextBox.Text = openFileDialogHTMLReport.FileName;
        }

        private void buttonTestStepOutput_Click(object sender, EventArgs e)
        {
            saveFileDialogTestStepOutput.ShowDialog();
            textBoxTestStepOutput.Text = saveFileDialogTestStepOutput.FileName;
        }

        private void textBoxTestStepOutput_Click(object sender, EventArgs e)
        {
            saveFileDialogTestStepOutput.ShowDialog();
            textBoxTestStepOutput.Text = saveFileDialogTestStepOutput.FileName;
        }

        private void buttonParseHTML_Click(object sender, EventArgs e)
        {
            progressBar2.Visible = true;
            progressBar2.Value = 0;
            backgroundWorkerTestStep.RunWorkerAsync();
        }

        public void FindMissingSteps(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<string> Output = new List<string>();

                int k = 0;
                bool Automated = false;
                string ExtentReport = ResultPathTextBox.Text;
                string TPTS = TPPath_TextBox.Text;

                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook ExcelWorkbook = Excel.Workbooks.Open(TPTS);
                Worksheet TPTSSheet = ExcelWorkbook.Sheets[1];

                int TotalRows = TPTSSheet.UsedRange.Rows.Count;
                string[] token = { "<script>" };
                string ExtentReportText = File.ReadAllText(ExtentReport).Split(token, StringSplitOptions.RemoveEmptyEntries)[0];
                for (int i = 2; i <= TotalRows; i++)
                {
                    backgroundWorkerTestStep.ReportProgress(i * 100 / TotalRows);
                    string TestCaseNumber = TPTSSheet.Cells[i, 4].Text;

                    if (TestCaseNumber.Equals(string.Empty))
                    {
                        TestCaseNumber = k.ToString();
                    }
                    else
                    {
                        Automated = TPTSSheet.Cells[i, 6].Text.Equals("Automation") ? true : false;
                    }

                    if (Automated)
                    {
                        if (int.TryParse(TestCaseNumber, out k))
                        {

                            if (ExtentReportText.Contains(TestCaseNumber))
                            {
                                string TestStepNumber = TPTSSheet.Cells[i, 8].Text;
                                if (ExtentReportText.Split(new String[] { TestStepNumber }, StringSplitOptions.RemoveEmptyEntries).Count() == 2)
                                {

                                }
                                else if (ExtentReportText.Split(new String[] { TestStepNumber }, StringSplitOptions.RemoveEmptyEntries).Count() < 2)
                                {
                                    Output.Add("Test Case No: " + TestCaseNumber + " : " + TestStepNumber);
                                }
                                else if (ExtentReportText.Split(new String[] { TestStepNumber }, StringSplitOptions.RemoveEmptyEntries).Count() > 2)
                                {
                                    Output.Add("Test Case No: " + TestCaseNumber + " : " + TestStepNumber + " (present multiple times)");
                                }
                            }
                            else
                            {
                                Output.Add("Test Case No: " + TestCaseNumber);
                            }
                        }
                    }
                }
                using (StreamWriter outputFile = new StreamWriter(textBoxTestStepOutput.Text))
                {
                    Output.Distinct().All(S => { outputFile.WriteLine(S); return true; });
                }
                ExcelWorkbook.Close(0);
                Excel.Quit();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "I AM MAD AT YOU!!!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
        }

        void backgroundWorkerTestStep_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar2.Value = e.ProgressPercentage;
        }

        void backgroundWorkerTestStep_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.Visible = false;
            Process process = new Process();
            process.StartInfo.FileName = saveFileDialogTestStepOutput.FileName;
            //process.StartInfo.Arguments = ..... //your parameters
            process.Start();
        }
    }
}
