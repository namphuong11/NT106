using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidFormat(string scores)
        {
            try
            {
                Array.ConvertAll(scores.Split(), float.Parse);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void DisplayScores(string scores)
        {
            var scoresList = scores.Split();
            groupBox1.Controls.Clear();
            for (int i = 0; i < scoresList.Length; i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = $"Môn {i + 1}: {scoresList[i]}";
                label.AutoSize = true;
                groupBox1.Controls.Add(label);
                label.Location = new Point(10, 20 + i * 20);
                groupBox1.Controls.Add(label);
            }
        }
        private float CalculateAverage(string scores)
        {
            var scoresList = Array.ConvertAll(scores.Split(), float.Parse);
            return scoresList.Average();
        }
        private (float, float) FindMaxMin(string scores)
        {
            var scoresList = Array.ConvertAll(scores.Split(), float.Parse);
            return (scoresList.Max(), scoresList.Min());
        }
        private (int, int) CountPassedFailed(string scores)
        {
            var scoresList = Array.ConvertAll(scores.Split(), float.Parse);
            int passedSubjects = scoresList.Count(score => score >= 5);
            int failedSubjects = scoresList.Length - passedSubjects;
            return (passedSubjects, failedSubjects);
        }
        private string ClassifyStudent(string scores, float averageScore)
        {
            var scoresList = Array.ConvertAll(scores.Split(), float.Parse);
            if (averageScore >= 8 && scoresList.All(score => score >= 6.5))
            {
                return "Giỏi";
            }
            else if (averageScore >= 6.5 && scoresList.All(score => score >= 5))
            {
                return "Khá";
            }
            else if (averageScore >= 5 && scoresList.All(score => score >= 3.5))
            {
                return "TB";
            }
            else if (averageScore >= 3.5 && scoresList.All(score => score >= 2))
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != ' ')
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string scores = textBox1.Text.Trim();
            if (IsValidFormat(scores))
            {
                DisplayScores(scores);

                float averageScore = CalculateAverage(scores);
                label3.Text = "Điểm trung bình: " + averageScore.ToString();

                (float maxScore, float minScore) = FindMaxMin(scores);
                label5.Text = "Điểm cao nhất: " + maxScore.ToString();
                label6.Text = "Điểm thấp nhất: " + minScore.ToString();

                (int passedSubjects, int failedSubjects) = CountPassedFailed(scores);
                label7.Text = "Số môn đậu: " + passedSubjects.ToString();
                label8.Text = "Số môn không đậu: " + failedSubjects.ToString();

                string classification = ClassifyStudent(scores, averageScore);
                label4.Text = "Xếp loại học lực: " + classification;
            }
            else
            {
                MessageBox.Show("Sai format. Vui lòng nhập lại.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsAllDigits(((TextBox)sender).Text))
            {
                textBox1.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }
    }
}
