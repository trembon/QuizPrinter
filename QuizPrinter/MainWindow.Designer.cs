namespace QuizPrinter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.btnQuestionsClear = new System.Windows.Forms.Button();
            this.btnQuestionsReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswerX = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswerX = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabAnswerSheet = new System.Windows.Forms.TabPage();
            this.btnAnswersReset = new System.Windows.Forms.Button();
            this.txtNameText = new System.Windows.Forms.TextBox();
            this.lblNameText = new System.Windows.Forms.Label();
            this.btnSheetPrint = new System.Windows.Forms.Button();
            this.nmrSheetsPerPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.nmrQuestionCount = new System.Windows.Forms.NumericUpDown();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.printDocumentQuestions = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocumentSheets = new System.Drawing.Printing.PrintDocument();
            this.tabControl.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.tabAnswerSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSheetsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuestionCount)).BeginInit();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuestion);
            this.tabControl.Controls.Add(this.tabAnswerSheet);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(357, 374);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabQuestion
            // 
            this.tabQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.tabQuestion.Controls.Add(this.btnQuestionsClear);
            this.tabQuestion.Controls.Add(this.btnQuestionsReset);
            this.tabQuestion.Controls.Add(this.btnPrint);
            this.tabQuestion.Controls.Add(this.lblAnswer2);
            this.tabQuestion.Controls.Add(this.lblAnswerX);
            this.tabQuestion.Controls.Add(this.lblAnswer1);
            this.tabQuestion.Controls.Add(this.lblQuestion);
            this.tabQuestion.Controls.Add(this.lblTitle);
            this.tabQuestion.Controls.Add(this.txtQuestion);
            this.tabQuestion.Controls.Add(this.txtAnswer2);
            this.tabQuestion.Controls.Add(this.txtAnswerX);
            this.tabQuestion.Controls.Add(this.txtAnswer1);
            this.tabQuestion.Controls.Add(this.txtTitle);
            this.tabQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(349, 348);
            this.tabQuestion.TabIndex = 0;
            this.tabQuestion.Text = "Question";
            // 
            // btnQuestionsClear
            // 
            this.btnQuestionsClear.Location = new System.Drawing.Point(90, 319);
            this.btnQuestionsClear.Name = "btnQuestionsClear";
            this.btnQuestionsClear.Size = new System.Drawing.Size(75, 23);
            this.btnQuestionsClear.TabIndex = 8;
            this.btnQuestionsClear.Text = "Clear";
            this.btnQuestionsClear.UseVisualStyleBackColor = true;
            this.btnQuestionsClear.Click += new System.EventHandler(this.btnQuestionsClear_Click);
            // 
            // btnQuestionsReset
            // 
            this.btnQuestionsReset.Location = new System.Drawing.Point(9, 319);
            this.btnQuestionsReset.Name = "btnQuestionsReset";
            this.btnQuestionsReset.Size = new System.Drawing.Size(75, 23);
            this.btnQuestionsReset.TabIndex = 7;
            this.btnQuestionsReset.Text = "Reset";
            this.btnQuestionsReset.UseVisualStyleBackColor = true;
            this.btnQuestionsReset.Click += new System.EventHandler(this.btnQuestionsReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(268, 319);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(6, 244);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer2.TabIndex = 9;
            this.lblAnswer2.Text = "Answer 2";
            // 
            // lblAnswerX
            // 
            this.lblAnswerX.AutoSize = true;
            this.lblAnswerX.Location = new System.Drawing.Point(6, 205);
            this.lblAnswerX.Name = "lblAnswerX";
            this.lblAnswerX.Size = new System.Drawing.Size(52, 13);
            this.lblAnswerX.TabIndex = 8;
            this.lblAnswerX.Text = "Answer X";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(6, 166);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer1.TabIndex = 7;
            this.lblAnswer1.Text = "Answer 1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 55);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Question";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(9, 71);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(334, 68);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(9, 260);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer2.TabIndex = 5;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // txtAnswerX
            // 
            this.txtAnswerX.Location = new System.Drawing.Point(9, 221);
            this.txtAnswerX.Name = "txtAnswerX";
            this.txtAnswerX.Size = new System.Drawing.Size(334, 20);
            this.txtAnswerX.TabIndex = 4;
            this.txtAnswerX.TextChanged += new System.EventHandler(this.txtAnswerX_TextChanged);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(9, 182);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(334, 20);
            this.txtAnswer1.TabIndex = 3;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(334, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // tabAnswerSheet
            // 
            this.tabAnswerSheet.BackColor = System.Drawing.SystemColors.Control;
            this.tabAnswerSheet.Controls.Add(this.btnAnswersReset);
            this.tabAnswerSheet.Controls.Add(this.txtNameText);
            this.tabAnswerSheet.Controls.Add(this.lblNameText);
            this.tabAnswerSheet.Controls.Add(this.btnSheetPrint);
            this.tabAnswerSheet.Controls.Add(this.nmrSheetsPerPage);
            this.tabAnswerSheet.Controls.Add(this.label1);
            this.tabAnswerSheet.Controls.Add(this.lblQuestionCount);
            this.tabAnswerSheet.Controls.Add(this.nmrQuestionCount);
            this.tabAnswerSheet.Location = new System.Drawing.Point(4, 22);
            this.tabAnswerSheet.Name = "tabAnswerSheet";
            this.tabAnswerSheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnswerSheet.Size = new System.Drawing.Size(349, 348);
            this.tabAnswerSheet.TabIndex = 1;
            this.tabAnswerSheet.Text = "Answer Sheet";
            // 
            // btnAnswersReset
            // 
            this.btnAnswersReset.Location = new System.Drawing.Point(9, 319);
            this.btnAnswersReset.Name = "btnAnswersReset";
            this.btnAnswersReset.Size = new System.Drawing.Size(75, 23);
            this.btnAnswersReset.TabIndex = 5;
            this.btnAnswersReset.Text = "Reset";
            this.btnAnswersReset.UseVisualStyleBackColor = true;
            this.btnAnswersReset.Click += new System.EventHandler(this.btnAnswersReset_Click);
            // 
            // txtNameText
            // 
            this.txtNameText.Location = new System.Drawing.Point(9, 21);
            this.txtNameText.Name = "txtNameText";
            this.txtNameText.Size = new System.Drawing.Size(334, 20);
            this.txtNameText.TabIndex = 1;
            this.txtNameText.TextChanged += new System.EventHandler(this.txtNameText_TextChanged);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(6, 5);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(55, 13);
            this.lblNameText.TabIndex = 5;
            this.lblNameText.Text = "Name text";
            // 
            // btnSheetPrint
            // 
            this.btnSheetPrint.Location = new System.Drawing.Point(268, 319);
            this.btnSheetPrint.Name = "btnSheetPrint";
            this.btnSheetPrint.Size = new System.Drawing.Size(75, 23);
            this.btnSheetPrint.TabIndex = 4;
            this.btnSheetPrint.Text = "Print";
            this.btnSheetPrint.UseVisualStyleBackColor = true;
            this.btnSheetPrint.Click += new System.EventHandler(this.btnSheetPrint_Click);
            // 
            // nmrSheetsPerPage
            // 
            this.nmrSheetsPerPage.Location = new System.Drawing.Point(9, 129);
            this.nmrSheetsPerPage.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrSheetsPerPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSheetsPerPage.Name = "nmrSheetsPerPage";
            this.nmrSheetsPerPage.Size = new System.Drawing.Size(167, 20);
            this.nmrSheetsPerPage.TabIndex = 3;
            this.nmrSheetsPerPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSheetsPerPage.ValueChanged += new System.EventHandler(this.nmrSheetsPerPage_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sheets per page";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(6, 55);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(104, 13);
            this.lblQuestionCount.TabIndex = 1;
            this.lblQuestionCount.Text = "Number of questions";
            // 
            // nmrQuestionCount
            // 
            this.nmrQuestionCount.Location = new System.Drawing.Point(9, 75);
            this.nmrQuestionCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrQuestionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuestionCount.Name = "nmrQuestionCount";
            this.nmrQuestionCount.Size = new System.Drawing.Size(167, 20);
            this.nmrQuestionCount.TabIndex = 2;
            this.nmrQuestionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuestionCount.ValueChanged += new System.EventHandler(this.nmrQuestionCount_ValueChanged);
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.pbPreview);
            this.gbPreview.Location = new System.Drawing.Point(375, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(320, 374);
            this.gbPreview.TabIndex = 1;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Preview";
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.Location = new System.Drawing.Point(6, 19);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(308, 349);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // printDocumentQuestions
            // 
            this.printDocumentQuestions.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentQuestions_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocumentSheets
            // 
            this.printDocumentSheets.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSheets_PrintPage);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 398);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Printer";
            this.tabControl.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.tabAnswerSheet.ResumeLayout(false);
            this.tabAnswerSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSheetsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuestionCount)).EndInit();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.TabPage tabAnswerSheet;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswerX;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswerX;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuestionsReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQuestionsClear;
        private System.Drawing.Printing.PrintDocument printDocumentQuestions;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.NumericUpDown nmrSheetsPerPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.NumericUpDown nmrQuestionCount;
        private System.Windows.Forms.Button btnSheetPrint;
        private System.Drawing.Printing.PrintDocument printDocumentSheets;
        private System.Windows.Forms.TextBox txtNameText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Button btnAnswersReset;
    }
}

