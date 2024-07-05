using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NT106.M21._1_20520924_LAB2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        OpenFileDialog opd;
        private void btnReadInput_Click(object sender, EventArgs e)
        {
            try
            {
                opd = new OpenFileDialog();
                opd.Filter = "Text Files |*.txt";
                opd.ShowDialog();
                FileStream fs = new FileStream(opd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                tbInput.Text = sr.ReadToEnd();
                sr.BaseStream.Position = 0;
                btnCalc.Enabled = true;
                tbPathInput.Text = fs.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            File.WriteAllText("..\\output.txt", "");
            FileStream fsw = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fsw, Encoding.UTF8);

            FileStream fsr = new FileStream(opd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);

            string[] res = Calc(sr);
            foreach (var item in res)
            {
                sw.WriteLine(item);
            }
            sw.Close();
            tbOuput.Text = File.ReadAllText(fsw.Name);
            tbPathOutput.Text = fsw.Name;
            fsw.Close();
            fsr.Close();
        }
        private string[] Calc(StreamReader sr)
        {
            try
            {
                var content = sr.ReadToEnd();
                var Lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i].Contains('+')|| Lines[i].Contains('-'))
                    {
                        string temp = Lines[i];
                        var calc = Lines[i].Split(new char[] { '-','+' }); ;
                        float res = 0;
                        for (int j = 0; j < calc.Length; j++)
                        {

                            if (Lines[i].IndexOf('-') != -1 && Lines[i].IndexOf('-')-Lines[i].IndexOf(calc[j]) ==-1 )
                            {
                                
                                int indexOfSo = Lines[i].IndexOf(calc[j]);


                                int indexOfDau = Lines[i].IndexOf('-');

                                if (indexOfSo != -1 )
                                {
                                    int lengthofSo = calc[j].Length;
                                    Lines[i] = Lines[i].Remove(indexOfSo, lengthofSo);
                                }


                                if (indexOfDau != -1 && indexOfDau - (indexOfSo) == -1)
                                {
                                    indexOfSo = Lines[i].IndexOf(calc[j]);
                                    Lines[i] = Lines[i].Remove(indexOfDau, 1);
                                }


                                res -= float.Parse(calc[j]);
                            }
                            else 
                            {

                                
                                int indexOfSo = Lines[i].IndexOf(calc[j]);
                                

                                int indexOfDau = Lines[i].IndexOf('+');

                                if (indexOfSo != -1)
                                {
                                    int lengthofSo = calc[j].Length;
                                    Lines[i] = Lines[i].Remove(indexOfSo, lengthofSo);                                  
                                }
                                
                                
                                if (indexOfDau != -1 && indexOfDau-(indexOfSo) ==-1)
                                {
                                    indexOfSo = Lines[i].IndexOf(calc[j]);
                                    Lines[i] = Lines[i].Remove(indexOfDau, 1);
                                }


                                    res += float.Parse(calc[j]);
                            }

                        }
                        Lines[i] = temp + " = " + res.ToString();
                    }

                    else
                    if (Lines[i].Contains('*'))
                    {
                        var calc = Lines[i].Split('*');
                        float res = 1;
                        for (int j = 0; j < calc.Length; j++)
                        {
                            res *= float.Parse(calc[j]);
                        }
                        Lines[i] = Lines[i] + " = " + res.ToString();
                    }
                    else
                   if (Lines[i].Contains('/'))
                    {
                        var calc = Lines[i].Split('/');
                        float res = 1;
                        for (int j = 0; j < calc.Length; j++)
                        {
                            res /= float.Parse(calc[j]);
                        }
                        Lines[i] = Lines[i] + " = " + res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input!");
                    }
                }
                return Lines;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return new string[] { "Nothing" };
            }

        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            btnCalc.Enabled = false;
        }
    }
}
