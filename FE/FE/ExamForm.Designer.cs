using System.Drawing;
using System.Windows.Forms;

namespace FE
{
    partial class ExamForm
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
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.btnEndExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuestion
            // 
            this.picQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQuestion.Location = new System.Drawing.Point(20, 20);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(600, 300);
            this.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuestion.TabIndex = 0;
            this.picQuestion.TabStop = false;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Location = new System.Drawing.Point(20, 340);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(600, 200);
            this.pnlAnswers.TabIndex = 1;
            this.pnlAnswers.AutoScroll = true;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(700, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 30);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "19:00";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQuestionCount.Location = new System.Drawing.Point(700, 60);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(100, 30);
            this.lblQuestionCount.TabIndex = 3;
            this.lblQuestionCount.Text = "Câu: 1/20";
            // 
            // btnEndExam
            // 
            this.btnEndExam.ForeColor = System.Drawing.Color.Red;
            this.btnEndExam.Location = new System.Drawing.Point(700, 500);
            this.btnEndExam.Name = "btnEndExam";
            this.btnEndExam.Size = new System.Drawing.Size(100, 45);
            this.btnEndExam.TabIndex = 4;
            this.btnEndExam.Text = "Kết thúc";
            this.btnEndExam.UseVisualStyleBackColor = true;
            // 
            // ExamForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnEndExam);
            this.Controls.Add(this.picQuestion);
            this.Controls.Add(this.pnlAnswers);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestionCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thi sát hạch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private PictureBox picQuestion;
        private Panel pnlAnswers;
        private Label lblTimer;
        private Label lblQuestionCount;
        private Button btnEndExam;
    }
}