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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c!='-')
                    return false;
            }
            return true;
        }
        private void TinhTong_Click(object sender, EventArgs e)
        {
            int num1 =0, num2=0;
            long sum = 0;
            num1 = Int32.Parse(songuyen1.Text.Trim());
            num2 = Int32.Parse(songuyen2.Text.Trim());
            sum = num1 + num2;
            tong.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            songuyen1.Text = "";
            songuyen2.Text = "";
            tong.Text = "";
        }

        private void songuyen1_TextChanged(object sender, EventArgs e)
        {
            if (!IsAllDigits(((TextBox)sender).Text)) 
            {
                songuyen1.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void songuyen2_TextChanged(object sender, EventArgs e)
        {
            if (!IsAllDigits(((TextBox)sender).Text))
            {
                songuyen2.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
