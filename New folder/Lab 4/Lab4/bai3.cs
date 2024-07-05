using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void bai3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string path = textBox2.Text;
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(url, path);
                    MessageBox.Show("Dowload Success");
                    using (Stream respon = client.OpenRead(url))
                    {
                        StreamReader sr = new StreamReader(respon);
                        string result = sr.ReadToEnd();
                        richTextBox1.Text = result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
