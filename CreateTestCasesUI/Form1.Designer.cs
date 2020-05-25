namespace CreateTestCasesUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TestCaseLogging = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SelectOutputButton = new System.Windows.Forms.Button();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.CreateLoggingButton = new System.Windows.Forms.Button();
            this.OwnerTextBox = new System.Windows.Forms.TextBox();
            this.OwnerNameLabel = new System.Windows.Forms.Label();
            this.SelectTPTSButton = new System.Windows.Forms.Button();
            this.TPTSPathText = new System.Windows.Forms.TextBox();
            this.TestStepVerification = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonParseHTML = new System.Windows.Forms.Button();
            this.buttonTestStepOutput = new System.Windows.Forms.Button();
            this.textBoxTestStepOutput = new System.Windows.Forms.TextBox();
            this.HTMLResultPathButton = new System.Windows.Forms.Button();
            this.ResultPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectTPFromAgileButton = new System.Windows.Forms.Button();
            this.TPPath_TextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TPFromAgileOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogHTMLReport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTestStepOutput = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorkerTestStep = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.TestCaseLogging.SuspendLayout();
            this.TestStepVerification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TestCaseLogging);
            this.tabControl1.Controls.Add(this.TestStepVerification);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // TestCaseLogging
            // 
            this.TestCaseLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TestCaseLogging.Controls.Add(this.progressBar1);
            this.TestCaseLogging.Controls.Add(this.SelectOutputButton);
            this.TestCaseLogging.Controls.Add(this.OutputFileTextBox);
            this.TestCaseLogging.Controls.Add(this.CreateLoggingButton);
            this.TestCaseLogging.Controls.Add(this.OwnerTextBox);
            this.TestCaseLogging.Controls.Add(this.OwnerNameLabel);
            this.TestCaseLogging.Controls.Add(this.SelectTPTSButton);
            this.TestCaseLogging.Controls.Add(this.TPTSPathText);
            this.TestCaseLogging.Location = new System.Drawing.Point(4, 25);
            this.TestCaseLogging.Name = "TestCaseLogging";
            this.TestCaseLogging.Padding = new System.Windows.Forms.Padding(3);
            this.TestCaseLogging.Size = new System.Drawing.Size(664, 283);
            this.TestCaseLogging.TabIndex = 0;
            this.TestCaseLogging.Text = "Test Case Logging";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(33, 239);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 22);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // SelectOutputButton
            // 
            this.SelectOutputButton.BackColor = System.Drawing.Color.DimGray;
            this.SelectOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectOutputButton.ForeColor = System.Drawing.Color.White;
            this.SelectOutputButton.Location = new System.Drawing.Point(495, 104);
            this.SelectOutputButton.Name = "SelectOutputButton";
            this.SelectOutputButton.Size = new System.Drawing.Size(150, 32);
            this.SelectOutputButton.TabIndex = 6;
            this.SelectOutputButton.Text = "Select Output";
            this.SelectOutputButton.UseVisualStyleBackColor = false;
            this.SelectOutputButton.Click += new System.EventHandler(this.SelectOutputButton_Click);
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.BackColor = System.Drawing.Color.DimGray;
            this.OutputFileTextBox.ForeColor = System.Drawing.Color.White;
            this.OutputFileTextBox.Location = new System.Drawing.Point(33, 109);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(438, 22);
            this.OutputFileTextBox.TabIndex = 5;
            this.OutputFileTextBox.Click += new System.EventHandler(this.OutputFileTextBox_Click);
            // 
            // CreateLoggingButton
            // 
            this.CreateLoggingButton.BackColor = System.Drawing.Color.DimGray;
            this.CreateLoggingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateLoggingButton.ForeColor = System.Drawing.Color.White;
            this.CreateLoggingButton.Location = new System.Drawing.Point(495, 194);
            this.CreateLoggingButton.Name = "CreateLoggingButton";
            this.CreateLoggingButton.Size = new System.Drawing.Size(150, 32);
            this.CreateLoggingButton.TabIndex = 4;
            this.CreateLoggingButton.Text = "Create Logging";
            this.CreateLoggingButton.UseVisualStyleBackColor = false;
            this.CreateLoggingButton.Click += new System.EventHandler(this.CreateLoggingButton_Click);
            // 
            // OwnerTextBox
            // 
            this.OwnerTextBox.BackColor = System.Drawing.Color.DimGray;
            this.OwnerTextBox.ForeColor = System.Drawing.Color.White;
            this.OwnerTextBox.Location = new System.Drawing.Point(146, 57);
            this.OwnerTextBox.Name = "OwnerTextBox";
            this.OwnerTextBox.Size = new System.Drawing.Size(325, 22);
            this.OwnerTextBox.TabIndex = 3;
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.AutoSize = true;
            this.OwnerNameLabel.ForeColor = System.Drawing.Color.White;
            this.OwnerNameLabel.Location = new System.Drawing.Point(32, 59);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(115, 17);
            this.OwnerNameLabel.TabIndex = 2;
            this.OwnerNameLabel.Text = "Owner Name : ";
            // 
            // SelectTPTSButton
            // 
            this.SelectTPTSButton.BackColor = System.Drawing.Color.DimGray;
            this.SelectTPTSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectTPTSButton.ForeColor = System.Drawing.Color.White;
            this.SelectTPTSButton.Location = new System.Drawing.Point(495, 14);
            this.SelectTPTSButton.Name = "SelectTPTSButton";
            this.SelectTPTSButton.Size = new System.Drawing.Size(150, 32);
            this.SelectTPTSButton.TabIndex = 1;
            this.SelectTPTSButton.Text = "Select TPTS";
            this.SelectTPTSButton.UseVisualStyleBackColor = false;
            this.SelectTPTSButton.Click += new System.EventHandler(this.SelectTPTSButton_Click);
            // 
            // TPTSPathText
            // 
            this.TPTSPathText.BackColor = System.Drawing.Color.DimGray;
            this.TPTSPathText.ForeColor = System.Drawing.Color.White;
            this.TPTSPathText.Location = new System.Drawing.Point(33, 19);
            this.TPTSPathText.Name = "TPTSPathText";
            this.TPTSPathText.Size = new System.Drawing.Size(438, 22);
            this.TPTSPathText.TabIndex = 0;
            this.TPTSPathText.Click += new System.EventHandler(this.TPTSPathText_Click);
            // 
            // TestStepVerification
            // 
            this.TestStepVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TestStepVerification.Controls.Add(this.progressBar2);
            this.TestStepVerification.Controls.Add(this.buttonParseHTML);
            this.TestStepVerification.Controls.Add(this.buttonTestStepOutput);
            this.TestStepVerification.Controls.Add(this.textBoxTestStepOutput);
            this.TestStepVerification.Controls.Add(this.HTMLResultPathButton);
            this.TestStepVerification.Controls.Add(this.ResultPathTextBox);
            this.TestStepVerification.Controls.Add(this.SelectTPFromAgileButton);
            this.TestStepVerification.Controls.Add(this.TPPath_TextBox);
            this.TestStepVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestStepVerification.ForeColor = System.Drawing.Color.DimGray;
            this.TestStepVerification.Location = new System.Drawing.Point(4, 25);
            this.TestStepVerification.Name = "TestStepVerification";
            this.TestStepVerification.Padding = new System.Windows.Forms.Padding(3);
            this.TestStepVerification.Size = new System.Drawing.Size(664, 283);
            this.TestStepVerification.TabIndex = 1;
            this.TestStepVerification.Text = "Test Step Verification";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Lime;
            this.progressBar2.Location = new System.Drawing.Point(25, 236);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(411, 27);
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Visible = false;
            // 
            // buttonParseHTML
            // 
            this.buttonParseHTML.BackColor = System.Drawing.Color.DimGray;
            this.buttonParseHTML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonParseHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParseHTML.ForeColor = System.Drawing.Color.White;
            this.buttonParseHTML.Location = new System.Drawing.Point(462, 177);
            this.buttonParseHTML.Name = "buttonParseHTML";
            this.buttonParseHTML.Size = new System.Drawing.Size(175, 35);
            this.buttonParseHTML.TabIndex = 6;
            this.buttonParseHTML.Text = "Parse HTML";
            this.buttonParseHTML.UseVisualStyleBackColor = false;
            this.buttonParseHTML.Click += new System.EventHandler(this.buttonParseHTML_Click);
            // 
            // buttonTestStepOutput
            // 
            this.buttonTestStepOutput.BackColor = System.Drawing.Color.DimGray;
            this.buttonTestStepOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTestStepOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestStepOutput.ForeColor = System.Drawing.Color.White;
            this.buttonTestStepOutput.Location = new System.Drawing.Point(462, 116);
            this.buttonTestStepOutput.Name = "buttonTestStepOutput";
            this.buttonTestStepOutput.Size = new System.Drawing.Size(175, 35);
            this.buttonTestStepOutput.TabIndex = 5;
            this.buttonTestStepOutput.Text = "Select Output File";
            this.buttonTestStepOutput.UseVisualStyleBackColor = false;
            this.buttonTestStepOutput.Click += new System.EventHandler(this.buttonTestStepOutput_Click);
            // 
            // textBoxTestStepOutput
            // 
            this.textBoxTestStepOutput.BackColor = System.Drawing.Color.DimGray;
            this.textBoxTestStepOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxTestStepOutput.Location = new System.Drawing.Point(23, 122);
            this.textBoxTestStepOutput.Name = "textBoxTestStepOutput";
            this.textBoxTestStepOutput.Size = new System.Drawing.Size(412, 22);
            this.textBoxTestStepOutput.TabIndex = 4;
            this.textBoxTestStepOutput.Click += new System.EventHandler(this.textBoxTestStepOutput_Click);
            // 
            // HTMLResultPathButton
            // 
            this.HTMLResultPathButton.BackColor = System.Drawing.Color.DimGray;
            this.HTMLResultPathButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HTMLResultPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HTMLResultPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLResultPathButton.ForeColor = System.Drawing.Color.White;
            this.HTMLResultPathButton.Location = new System.Drawing.Point(462, 63);
            this.HTMLResultPathButton.Name = "HTMLResultPathButton";
            this.HTMLResultPathButton.Size = new System.Drawing.Size(175, 35);
            this.HTMLResultPathButton.TabIndex = 3;
            this.HTMLResultPathButton.Text = "Select HTML Report";
            this.HTMLResultPathButton.UseVisualStyleBackColor = false;
            this.HTMLResultPathButton.Click += new System.EventHandler(this.HTMLResultPathButton_Click);
            // 
            // ResultPathTextBox
            // 
            this.ResultPathTextBox.BackColor = System.Drawing.Color.DimGray;
            this.ResultPathTextBox.ForeColor = System.Drawing.Color.White;
            this.ResultPathTextBox.Location = new System.Drawing.Point(25, 69);
            this.ResultPathTextBox.Name = "ResultPathTextBox";
            this.ResultPathTextBox.Size = new System.Drawing.Size(411, 22);
            this.ResultPathTextBox.TabIndex = 2;
            this.ResultPathTextBox.Click += new System.EventHandler(this.ResultPathTextBox_Click);
            // 
            // SelectTPFromAgileButton
            // 
            this.SelectTPFromAgileButton.BackColor = System.Drawing.Color.DimGray;
            this.SelectTPFromAgileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectTPFromAgileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTPFromAgileButton.ForeColor = System.Drawing.Color.White;
            this.SelectTPFromAgileButton.Location = new System.Drawing.Point(462, 11);
            this.SelectTPFromAgileButton.Name = "SelectTPFromAgileButton";
            this.SelectTPFromAgileButton.Size = new System.Drawing.Size(175, 35);
            this.SelectTPFromAgileButton.TabIndex = 1;
            this.SelectTPFromAgileButton.Text = "Select TP from Agile";
            this.SelectTPFromAgileButton.UseVisualStyleBackColor = false;
            this.SelectTPFromAgileButton.Click += new System.EventHandler(this.SelectTPFromAgileButton_Click);
            // 
            // TPPath_TextBox
            // 
            this.TPPath_TextBox.BackColor = System.Drawing.Color.DimGray;
            this.TPPath_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPPath_TextBox.ForeColor = System.Drawing.Color.White;
            this.TPPath_TextBox.Location = new System.Drawing.Point(25, 17);
            this.TPPath_TextBox.Name = "TPPath_TextBox";
            this.TPPath_TextBox.Size = new System.Drawing.Size(411, 22);
            this.TPPath_TextBox.TabIndex = 0;
            this.TPPath_TextBox.Click += new System.EventHandler(this.TPPath_TextBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.xlsx";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "TestCases.cs";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // TPFromAgileOpenFile
            // 
            this.TPFromAgileOpenFile.DefaultExt = "*.xlsx";
            // 
            // openFileDialogHTMLReport
            // 
            this.openFileDialogHTMLReport.DefaultExt = "*.html";
            // 
            // saveFileDialogTestStepOutput
            // 
            this.saveFileDialogTestStepOutput.FileName = "TestStep_Output.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 334);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoScript App";
            this.tabControl1.ResumeLayout(false);
            this.TestCaseLogging.ResumeLayout(false);
            this.TestCaseLogging.PerformLayout();
            this.TestStepVerification.ResumeLayout(false);
            this.TestStepVerification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TestCaseLogging;
        private System.Windows.Forms.TabPage TestStepVerification;
        private System.Windows.Forms.Button SelectTPTSButton;
        private System.Windows.Forms.TextBox TPTSPathText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CreateLoggingButton;
        private System.Windows.Forms.TextBox OwnerTextBox;
        private System.Windows.Forms.Label OwnerNameLabel;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.Button SelectOutputButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SelectTPFromAgileButton;
        private System.Windows.Forms.TextBox TPPath_TextBox;
        private System.Windows.Forms.OpenFileDialog TPFromAgileOpenFile;
        private System.Windows.Forms.Button HTMLResultPathButton;
        private System.Windows.Forms.TextBox ResultPathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogHTMLReport;
        private System.Windows.Forms.Button buttonTestStepOutput;
        private System.Windows.Forms.TextBox textBoxTestStepOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTestStepOutput;
        private System.Windows.Forms.Button buttonParseHTML;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTestStep;
    }
}

