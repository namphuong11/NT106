using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace NT106.M21._1_20520924_LAB2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }



        private void Bai4_Load(object sender, EventArgs e)
        {
            tbMSSV.Enabled = false;
            tbHoTen.Enabled = false;
            tbDienThoai.Enabled = false;
            tbDiemVan.Enabled = false;
            tbDiemToan.Enabled = false;
            tbInput.Enabled = false;
            tbOuput.Enabled = false;
            btnWriteInput.Enabled = false;
            btnRead.Enabled = false;
        }

        private void Nhap()
        {

        }
        private bool CheckInput()
        {
            return float.TryParse(tbDiemToan.Text, out _)
        && float.TryParse(tbDiemVan.Text, out _)
        && tbDienThoai.Text != ""
        && tbHoTen.Text != ""
        && tbMSSV.Text != ""
        && CheckScores();
        }
        private void btnWriteInput_Click(object sender, EventArgs e)
        {

            if (CheckInput())
            {
                string[] content = { tbMSSV.Text, tbHoTen.Text, tbDienThoai.Text, tbDiemToan.Text, tbDiemVan.Text, "\r\n" };


                FileStream fsw = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                tbPathInput.Text = fsw.Name;
                fsw.Close();

                File.AppendAllLines(fsw.Name, content);

                FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
                tbInput.Text = sr.ReadToEnd();
                sr.Close();
                fsr.Close();

                tbNumOfSV.Text = (int.Parse(tbNumOfSV.Text) - 1).ToString();
                BeNothing();
            }
            else
            {
                MessageBox.Show("Xin Nhập đủ và đúng định dạng thông tin");
                return;
            }
            if (tbNumOfSV.Text == "0")
            {
                bntBatDauNhap.Enabled = true;

                tbNumOfSV.Enabled = true;
                tbMSSV.Enabled = false;
                tbHoTen.Enabled = false;
                tbDienThoai.Enabled = false;
                tbDiemVan.Enabled = false;
                tbDiemToan.Enabled = false;

                btnWriteInput.Enabled = false;
                btnRead.Enabled = true;
                BeNothing();
            }

        }
        private void BeNothing()
        {
            tbDiemToan.Text = "";
            tbDiemVan.Text = "";
            tbDienThoai.Text = "";
            tbHoTen.Text = "";
            tbMSSV.Text = "";

        }
        private void bntBatDauNhap_Click(object sender, EventArgs e)
        {


            if (int.TryParse(tbNumOfSV.Text, out _))
            {
                bntBatDauNhap.Enabled = false;
                tbNumOfSV.Enabled = true;
                tbMSSV.Enabled = true;
                tbHoTen.Enabled = true;
                tbDienThoai.Enabled = true;
                tbDiemVan.Enabled = true;
                tbDiemToan.Enabled = true;
                tbInput.Enabled = true;
                tbOuput.Enabled = true;
                btnWriteInput.Enabled = true;
                btnRead.Enabled = false;
                tbNumOfSV.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xin Nhập số lượng sinh viên");
            }
            if (tbNumOfSV.Text == "0")
            {
                bntBatDauNhap.Enabled = true;

                tbNumOfSV.Enabled = true;
                tbMSSV.Enabled = false;
                tbHoTen.Enabled = false;
                tbDienThoai.Enabled = false;
                tbDiemVan.Enabled = false;
                tbDiemToan.Enabled = false;

                btnWriteInput.Enabled = false;
                btnRead.Enabled = true;
                BeNothing();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("..\\input.txt", string.Empty);
            File.WriteAllText("..\\output.txt", string.Empty);
            tbInput.Text = "";
            tbOuput.Text = "";
            BeNothing();
            tbMSSV.Enabled = false;
            tbHoTen.Enabled = false;
            tbDienThoai.Enabled = false;
            tbDiemVan.Enabled = false;
            tbDiemToan.Enabled = false;
            btnWriteInput.Enabled = false;
            btnRead.Enabled = false;
            tbNumOfSV.Enabled = true;
            bntBatDauNhap.Enabled = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
            tbPathOutput.Text = fsr.Name;
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
            string content = sr.ReadToEnd();

            sr.Close();
            fsr.Close();

            string[] Lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            if (Lines.Length != 0 && Lines[0] != "")
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i] == "" && float.TryParse(Lines[i - 1], out _)
                                       && float.TryParse(Lines[i - 2], out _)
                                       && float.TryParse(Lines[i - 3], out _)
                                       && !float.TryParse(Lines[i - 4], out _)
                                       && float.TryParse(Lines[i - 5], out _))
                    {
                        Lines[i] = ((float.Parse(Lines[i - 1]) + float.Parse(Lines[i - 2])) / 2).ToString();
                        i++;
                    }
                }

            File.AppendAllLines("..\\output.txt", Lines);

            fsr = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
            sr = new StreamReader(fsr, Encoding.UTF8);
            tbOuput.Text = sr.ReadToEnd();
            sr.Close();
            fsr.Close();
        }

        private bool MustBeNum(char num)
        {
            return char.IsDigit(num) || num == '.';
        }
        private bool MustBeLetter(char letter)
        {
            return char.IsLetter(letter) || char.IsWhiteSpace(letter);
        }
        private void tbMSSV_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbMSSV.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); tbMSSV.Text = ""; return; }
            }
        }

        private void tbHoTen_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbHoTen.Text)
            {
                if (!MustBeLetter(item)) { MessageBox.Show("Tên không có số"); tbHoTen.Text = ""; return; }
            }
        }

        private void tbDienThoai_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbDienThoai.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); tbDienThoai.Text = ""; return; }
            }
        }

        private void tbDiemToan_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbDiemToan.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); tbDiemToan.Text = ""; return; }
            }
        }

        private void tbDiemVan_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbDiemVan.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); tbDiemVan.Text = ""; return; }
            }
        }
        private bool CheckScores()
        {
            if (!float.TryParse(tbDiemToan.Text, out float diemToan) || diemToan < 0 || diemToan > 10)
            {
                MessageBox.Show("Điểm Toán phải là một số từ 0 đến 10.");
                tbDiemToan.Text = "";
                return false;
            }

            if (!float.TryParse(tbDiemVan.Text, out float diemVan) || diemVan < 0 || diemVan > 10)
            {
                MessageBox.Show("Điểm Văn phải là một số từ 0 đến 10.");
                tbDiemVan.Text = "";
                return false;
            }

            return true;
        }

        private void tbNumOfSV_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in tbNumOfSV.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); tbNumOfSV.Text = ""; return; }
            }
        }
    }
}
