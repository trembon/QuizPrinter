using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPrinter
{
    public partial class MainWindow : Form
    {
        private const int A4_WIDTH = 595;
        private const int A4_HEIGHT = 842;

        private object renderLock = new object();

        public MainWindow()
        {
            InitializeComponent();
            
            pbPreview.Image = new Bitmap(A4_WIDTH, A4_HEIGHT);
            ResetAnswerSheetValues();
            ResetQuestionTexts();
        }

        #region Questions

        private object renderQuestionsLock = new object();

        #region Control events
        /// <summary>
        /// Handles the TextChanged event of the txtTitle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateQuestionPreview();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtQuestion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            UpdateQuestionPreview();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtAnswer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            UpdateQuestionPreview();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtAnswerX control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtAnswerX_TextChanged(object sender, EventArgs e)
        {
            UpdateQuestionPreview();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtAnswer2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            UpdateQuestionPreview();
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnQuestionsReset_Click(object sender, EventArgs e)
        {
            ResetQuestionTexts();
        }

        /// <summary>
        /// Handles the Click event of the btnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnQuestionsClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuestion.Text = "";
            txtAnswer1.Text = "";
            txtAnswerX.Text = "";
            txtAnswer2.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocumentQuestions;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
                MessageBox.Show("Question was sent to the printer!", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the PrintPage event of the printDocument control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Drawing.Printing.PrintPageEventArgs"/> instance containing the event data.</param>
        private void printDocumentQuestions_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            lock (renderQuestionsLock)
            {
                DrawQuestions(e.Graphics, e.PageBounds.Height, e.PageBounds.Width);
            }
        }
        #endregion

        #region Logic
        private void ResetQuestionTexts()
        {
            txtTitle.Text = "Question 1";
            txtQuestion.Text = "Example on how a question will be placed on the page, with a questionmark?";
            txtAnswer1.Text = "The current year, is the right one";
            txtAnswerX.Text = "The last year is of course the correct answer, just to tell you that!";
            txtAnswer2.Text = "Pff, next year if the right answer!";
        }

        private void UpdateQuestionPreview()
        {
            lock (renderLock)
            {
                lock (renderQuestionsLock)
                {
                    Bitmap img = new Bitmap(pbPreview.Image);
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        DrawQuestions(g, img.Height, img.Width);
                    }
                    pbPreview.Image = img;
                }
            }
        }

        private void DrawQuestions(Graphics g, float height, float width)
        {
            g.Clear(Color.White);

            using (Font bold = new Font("Tahoma", width * 0.0385F, FontStyle.Bold))
            {
                float fromTop = height * 0.1F;
                float leftPos = (width - g.MeasureString(txtTitle.Text, bold).Width) / 2F;
                
                g.DrawString(txtTitle.Text, bold, Brushes.Black, new PointF(leftPos, fromTop));
            }

            using (Font standard = new Font("Tahoma", width * 0.027F, FontStyle.Regular))
            {
                // calculate base information about the question text
                float eightyProcent = width * 0.8F;
                float tenProcent = width * 0.1F;

                // calculate on how many lines the question should be on
                string question = txtQuestion.Text.Replace(Environment.NewLine, "");
                List<string> lines = CalculateStringToLines(question, g, standard, eightyProcent);

                // render all the lines of the question
                float startPos = height * 0.25F;
                foreach (string line in lines)
                {
                    SizeF lineSize = g.MeasureString(line, standard);
                    float leftPos = (width - lineSize.Width) / 2F;
                    g.DrawString(line, standard, Brushes.Black, new PointF(leftPos, startPos));

                    startPos += lineSize.Height;
                }

                // render the answers
                Dictionary<string, string> answers = new Dictionary<string, string>(3);
                answers.Add("1.", txtAnswer1.Text);
                answers.Add("X.", txtAnswerX.Text);
                answers.Add("2.", txtAnswer2.Text);

                float answerDistance = height * 0.045F;
                float numberToAnswerDistance = width * 0.01F;
                float answerStartPos = height * 0.5F;
                foreach (var kvp in answers)
                {
                    SizeF numberSize = g.MeasureString(kvp.Key, standard);
                    List<string> answerLines = CalculateStringToLines(kvp.Value, g, standard, eightyProcent - numberSize.Width - numberToAnswerDistance);

                    string answer = string.Join(Environment.NewLine, answerLines);
                    SizeF answerSize = g.MeasureString(answer, standard);

                    g.DrawString(kvp.Key, standard, Brushes.Black, new PointF(tenProcent, answerStartPos + ((answerSize.Height - numberSize.Height) / 2F)));
                    g.DrawString(answer, standard, Brushes.Black, new PointF(tenProcent + numberSize.Width + numberToAnswerDistance, answerStartPos));

                    answerStartPos = answerStartPos + answerSize.Height + answerDistance;
                }
            }
        }
        
        private List<string> CalculateStringToLines(string line, Graphics g, Font font, float maxWidth)
        {
            List<string> lines = new List<string>();
            if (g.MeasureString(line, font).Width > maxWidth)
            {
                string[] words = line.Split(' ');

                int lastBreak = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    float length = g.MeasureString(string.Join(" ", words.Skip(lastBreak).Take(i + 1 - lastBreak)), font).Width;
                    if (length > maxWidth)
                    {
                        lines.Add(string.Join(" ", words.Skip(lastBreak).Take(i - lastBreak)));
                        lastBreak = i;
                    }

                    if (i == words.Length - 1)
                        lines.Add(string.Join(" ", words.Skip(lastBreak)));
                }
            }
            else
            {
                // if the whole question can be placed on one line, no calculation is needed
                lines.Add(line);
            }

            return lines;
        }
        #endregion

        #endregion

        
        private object renderSheetsLock = new object();

        private void nmrSheetsPerPage_ValueChanged(object sender, EventArgs e)
        {
            UpdateAnswerSheetPreview();
        }

        private void nmrQuestionCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateAnswerSheetPreview();
        }

        private void btnSheetPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocumentSheets;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
                MessageBox.Show("Answer sheet was sent to the printer!", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocumentSheets_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            lock (renderSheetsLock)
            {
                DrawSheets(e.Graphics, (int)nmrSheetsPerPage.Value, e.PageBounds.Height, e.PageBounds.Width);
            }
        }

        private void ResetAnswerSheetValues()
        {
            txtNameText.Text = "Name";
            nmrQuestionCount.Value = 1;
            nmrSheetsPerPage.Value = 1;
        }

        private void UpdateAnswerSheetPreview()
        {
            lock (renderLock)
            {
                lock (renderSheetsLock)
                {
                    Bitmap img = new Bitmap(pbPreview.Image);
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        DrawSheets(g, (int)nmrSheetsPerPage.Value, img.Height, img.Width);
                    }
                    pbPreview.Image = img;
                }
            }
        }

        private void DrawSheets(Graphics g, int count, float height, float width)
        {
            g.Clear(Color.White);


            int sheetWidth = (int)width;
            int sheetHeight = (int)height;

            switch (count)
            {
                default:
                case 1:
                    DrawSheet(g, sheetHeight, sheetWidth);
                    break;

                case 2:
                    sheetHeight = sheetWidth;
                    sheetWidth = (int)height / 2;

                    using(Bitmap img = new Bitmap((int)width, (int)height))
                    {
                        using(Graphics imgGraphic = Graphics.FromImage(img))
                        {
                            DrawSheet(imgGraphic, img.Height, img.Width);
                        }

                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        
                        g.DrawImage(img, new Rectangle(0, 0, sheetHeight, sheetWidth), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(0, sheetWidth, sheetHeight, sheetWidth), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                    }

                    using (Pen dottedPen = CreateDottedPen())
                    {
                        g.DrawLine(dottedPen, new Point(0, sheetWidth), new Point(sheetHeight, sheetWidth));
                    }
                    break;

                case 3:
                    sheetHeight = sheetWidth;
                    sheetWidth = (int)height / 3;

                    using (Bitmap img = new Bitmap((int)width, (int)height))
                    {
                        using (Graphics imgGraphic = Graphics.FromImage(img))
                        {
                            DrawSheet(imgGraphic, img.Height, img.Width);
                        }

                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);

                        g.DrawImage(img, new Rectangle(0, 0, sheetHeight, sheetWidth), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(0, sheetWidth, sheetHeight, sheetWidth), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(0, sheetWidth * 2, sheetHeight, sheetWidth), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                    }

                    using (Pen dottedPen = CreateDottedPen())
                    {
                        g.DrawLine(dottedPen, new Point(0, sheetWidth), new Point(sheetHeight, sheetWidth));
                        g.DrawLine(dottedPen, new Point(0, sheetWidth * 2), new Point(sheetHeight, sheetWidth * 2));
                    }
                    break;

                case 4:
                    sheetHeight = sheetHeight / 2;
                    sheetWidth = sheetWidth / 2;

                    using (Bitmap img = new Bitmap((int)width, (int)height))
                    {
                        using (Graphics imgGraphic = Graphics.FromImage(img))
                        {
                            DrawSheet(imgGraphic, img.Height, img.Width);
                        }

                        g.DrawImage(img, new Rectangle(0, 0, sheetWidth, sheetHeight), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(sheetWidth, 0, sheetWidth, sheetHeight), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(0, sheetHeight, sheetWidth, sheetHeight), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                        g.DrawImage(img, new Rectangle(sheetWidth, sheetHeight, sheetWidth, sheetHeight), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                    }

                    using (Pen dottedPen = CreateDottedPen())
                    {
                        g.DrawLine(dottedPen, new Point(0, sheetHeight), new Point((int)width, sheetHeight));
                        g.DrawLine(dottedPen, new Point(sheetWidth, 0), new Point(sheetWidth, (int)height));
                    }
                    break;
            }
        }

        private Pen CreateDottedPen()
        {
            float[] dashValues = { 5, 5 };
            Pen dottedPen = Pens.LightGray.Clone() as Pen;
            dottedPen.DashPattern = dashValues;
            return dottedPen;
        }

        private void DrawSheet(Graphics g, float height, float width)
        {
            float fiveProcentWidth = width * 0.05F;

            using (Font standard = new Font("Calibri", width * 0.025F, FontStyle.Regular))
            {
                string nameText = $"{txtNameText.Text}: _____________________________";

                SizeF nameTextSize = g.MeasureString(nameText, standard);
                g.DrawString(nameText, standard, Brushes.Black, new PointF(fiveProcentWidth, fiveProcentWidth));

                float gridStartY = fiveProcentWidth + nameTextSize.Height + (height * 0.03F);

                float gridWidth = width - (fiveProcentWidth * 2F);
                float gridHeight = height - gridStartY - fiveProcentWidth;

                float gridColumnWidth = (gridWidth / 4F);
                float gridColumnHeight = (gridHeight / ((float)nmrQuestionCount.Maximum + 1F));

                int yLineWidth = (int)(4 * gridColumnWidth);
                for (int x = 0; x <= nmrQuestionCount.Value; x++)
                {
                    int linePositionY = (int)(gridStartY + ((x + 1) * gridColumnHeight));
                    g.DrawLine(Pens.Black, new Point((int)fiveProcentWidth, linePositionY), new Point((int)(fiveProcentWidth + yLineWidth), linePositionY));

                    if (x >= 1)
                    {
                        // calculate the center of the left column to place the question number
                        float columnCenterY = linePositionY - (gridColumnHeight / 2F);
                        float columnCenterX = fiveProcentWidth + (gridColumnWidth / 2F);

                        string columnText = $"{x}.";
                        SizeF columnTextSize = g.MeasureString(columnText, standard);

                        g.DrawString(columnText, standard, Brushes.Black, new PointF(columnCenterX - (columnTextSize.Width / 2F), columnCenterY - (columnTextSize.Height / 2F)));
                    }
                }

                int yLineHeight = (int)((float)(nmrQuestionCount.Value + 1) * gridColumnHeight);
                for (int y = 0; y < 4; y++)
                {
                    int linePositionX = (int)(fiveProcentWidth + (gridColumnWidth * (y + 1)));
                    g.DrawLine(Pens.Black, new Point(linePositionX, (int)gridStartY), new Point(linePositionX, (int)(gridStartY + yLineHeight)));

                    if (y >= 1)
                    {
                        string columnText = "";
                        switch (y)
                        {
                            case 1:
                                columnText = "1";
                                break;
                            case 2:
                                columnText = "X";
                                break;
                            case 3:
                                columnText = "2";
                                break;
                        }

                        // calculate the center of the left column to place the question number
                        float columnCenterY = gridStartY + (gridColumnHeight / 2F);
                        float columnCenterX = linePositionX - (gridColumnWidth / 2F);
                        
                        SizeF columnTextSize = g.MeasureString(columnText, standard);

                        g.DrawString(columnText, standard, Brushes.Black, new PointF(columnCenterX - (columnTextSize.Width / 2F), columnCenterY - (columnTextSize.Height / 2F)));
                    }
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    UpdateQuestionPreview();
                    break;

                case 1:
                    UpdateAnswerSheetPreview();
                    break;
            }
        }

        private void txtNameText_TextChanged(object sender, EventArgs e)
        {
            UpdateAnswerSheetPreview();
        }

        private void btnAnswersReset_Click(object sender, EventArgs e)
        {
            ResetAnswerSheetValues();
        }
    }
}
