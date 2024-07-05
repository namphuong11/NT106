using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NT106.M21._1_20520924_LAB2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void bntRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Txt Files|*.txt";
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                tbFileName.Text = ofd.SafeFileName.ToString();
                tbUrl.Text = fs.Name.ToString();
                var content = sr.ReadToEnd();
                sr.BaseStream.Position = 0;
                tbNumL.Text = CountLine(sr).ToString();
                tbNumC.Text = content.Length.ToString();

                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                tbNumW.Text = source.Count().ToString();
                richtbContent.Text = content;
                fs.Close();
                sr.Close();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }
        private int CountLine(StreamReader sr)
        {
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            return lineCount;
        }
    }
}
