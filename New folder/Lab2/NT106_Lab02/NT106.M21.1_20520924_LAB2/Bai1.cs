using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NT106.M21._1_20520924_LAB2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Txt Files| *.txt"
                };
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                richTB.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                MessageBox.Show("Read Successfully to  :\r\n" + fs.Name);
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("..\\output.txt", "");
                FileStream fs = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                if (richTB.Text != "")
                {
                    sw.Write(richTB.Text.ToUpper());
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Write Successfully to:\r\n" + fs.Name + " \r\n with Content is:\r\n " + File.ReadAllText(fs.Name));
                }
                else
                {
                    MessageBox.Show("Nothing in Text Box, Write something to Write");
                }
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }
        }
    }

}
