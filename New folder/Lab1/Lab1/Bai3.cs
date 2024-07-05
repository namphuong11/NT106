using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            songuyen.Text = "";
        }
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void songuyen_TextChanged(object sender, EventArgs e)
        {
            if (!IsAllDigits(((TextBox)sender).Text))
            {
                songuyen.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }
        private string ConvertNumberToWords(int number)
        {
            // Một số code để chuyển đổi số thành chữ cái ở đây
            // Ví dụ: một số cách tiếp cận phổ biến là sử dụng một mảng chứa các từ tương ứng với các chữ số
            // Và sử dụng các phép toán để trích xuất chữ số từ số nguyên và xây dựng từ kết quả
            // Ví dụ đơn giản ở dưới
            switch (number)
            {
                case 0:
                    return "Không";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "Unknown";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(songuyen.Text, out int number))
            {
                // Kiểm tra giá trị số
                switch (number)
                {
                    case 0:
                        MessageBox.Show("Chữ cái của số là: Không");
                        break;
                    case 1:
                        MessageBox.Show("Chữ cái của số là: Một");
                        break;
                    case 2:
                        MessageBox.Show("Chữ cái của số là: Hai");
                        break;
                    case 3:
                        MessageBox.Show("Chữ cái của số là: Ba");
                        break;
                    case 4:
                        MessageBox.Show("Chữ cái của số là: Bốn");
                        break;
                    case 5:
                        MessageBox.Show("Chữ cái của số là: Năm");
                        break;
                    case 6:
                        MessageBox.Show("Chữ cái của số là: Sáu");
                        break;
                    case 7:
                        MessageBox.Show("Chữ cái của số là: Bảy");
                        break;
                    case 8:
                        MessageBox.Show("Chữ cái của số là: Tám");
                        break;
                    case 9:
                        MessageBox.Show("Chữ cái của số là: Chín");
                        break;
                    default:
                        MessageBox.Show("Số không hợp lệ!");
                        break;
                }
            }
        }
    }
}
