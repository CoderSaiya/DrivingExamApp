using System;
using System.Drawing;
using System.Windows.Forms;

namespace FE
{
    public partial class ExamForm : Form
    {
        private Timer countdownTimer;
        private TimeSpan timeRemaining;

        string[] answers = { "Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4" };
        
        public ExamForm()
        {
            InitializeComponent();
            this.Resize += ExamForm_Resize;
            LoadData();
            StartCountdown();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            // Load data
            LoadAnswers(answers);
        }

        private void LoadAnswers(string[] answers)
        {
            pnlAnswers.Controls.Clear();
            int y = 0;
            int i = 0;
            int padding = 10;
            int maxWidth = pnlAnswers.Width + 200;
            foreach (var answer in answers)
            {
                Panel answerPanel = new Panel
                {
                    Location = new Point(10, y),
                    Width = maxWidth,
                    AutoSize = true
                };

                RadioButton rb = new RadioButton
                {
                    Location = new Point(0, 0),
                    Width = 20,
                    Height = 20,
                };

                Label lbl = new Label
                {
                    Text = answer,
                    Location = new Point(30, 0),
                    AutoSize = false,
                    Width = maxWidth - 30,
                    Font = new Font("Arial", 10),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                using (Graphics g = lbl.CreateGraphics())
                {
                    SizeF size = g.MeasureString(answer, lbl.Font, lbl.Width);
                    lbl.Height = (int)Math.Ceiling(size.Height) + 5; // +5 để tránh bị cắt chữ
                }

                answerPanel.Height = lbl.Height;

                answerPanel.Controls.Add(rb);
                answerPanel.Controls.Add(lbl);

                pnlAnswers.Controls.Add(answerPanel);

                y += answerPanel.Height + padding;
            }
        }

        private void ExamForm_Resize(object sender, EventArgs e)
        {
            UpdateComponentPositions();
        }

        private void UpdateComponentPositions()
        {
            lblTimer.Location = new Point(this.ClientSize.Width - 150, 20);
            lblQuestionCount.Location = new Point(this.ClientSize.Width - 150, 60);
            btnEndExam.Location = new Point(this.ClientSize.Width - 120, this.ClientSize.Height - 80);

            picQuestion.Width = this.ClientSize.Width - 200;
            pnlAnswers.Width = this.ClientSize.Width - 200;
            pnlAnswers.Height = this.ClientSize.Height - picQuestion.Height - 120;
        }

        private void StartCountdown()
        {
            timeRemaining = TimeSpan.FromMinutes(19);

            countdownTimer = new Timer
            {
                Interval = 1000 // 1 giây
            };
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = timeRemaining.ToString(@"mm\:ss");

            if (timeRemaining <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                MessageBox.Show("Hết thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
