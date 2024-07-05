using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testfirebase
{
    public partial class datban : Form
    {

        DataTable mydt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4MuMLXbNVSf631YwFNNRS7bAqPeSyIf7nbisDcdd",
            BasePath = "https://test-66037-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public datban()
        {
            InitializeComponent();
        }

        private async void datban_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            mydt.Columns.Add("Tenmon");
            mydt.Columns.Add("SL");

            dataGridView1.DataSource = mydt;


            string[] items = { "ca phe", "nuoc ep", "sua" };
            comboBox1.Items.AddRange(items);
            string[] items1 = { "meo ta", "mmeo tay", "mon leo" };
            comboBox2.Items.AddRange(items1);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1 && comboBox2.SelectedIndex <= -1)
            {
                MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
                return;
            }

            string selectedNumber = numericUpDown1.Value.ToString();
            string selectedItem;

            if (comboBox1.SelectedIndex >= 0)
            {
                selectedItem = comboBox1.SelectedItem.ToString();
            }
            else
            {
                selectedItem = comboBox2.SelectedItem.ToString();
            }


            SetResponse response = await client.SetAsync("1/" + selectedItem, selectedNumber);

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            numericUpDown1.Value = 0;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            mydt.Rows.Clear();
            FirebaseResponse resp = await client.GetAsync("1/");
            var data = resp.ResultAs<Dictionary<string, string>>();
            if (data == null)
            {
                MessageBox.Show("Ban chua duoc su dung");
            }
            else
            {
                foreach (var item in data)
                {
                    DataRow row = mydt.NewRow();
                    row["Tenmon"] = item.Key; // Khóa là tên món
                    row["SL"] = item.Value;   // Giá trị là số lượng
                    mydt.Rows.Add(row);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            numericUpDown1.Value = 0;
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            foreach (string s in comboBox1.Items)
            {
                if (s == Convert.ToString(row.Cells["Tenmon"].Value))
                {
                    comboBox1.SelectedItem = Convert.ToString(row.Cells["Tenmon"].Value);
                }  
            }
            foreach (string s in comboBox2.Items)
            {
                if (s == Convert.ToString(row.Cells["Tenmon"].Value))
                {
                    comboBox2.SelectedItem = Convert.ToString(row.Cells["Tenmon"].Value);
                }
            }
            numericUpDown1.Value = Convert.ToInt64(row.Cells["SL"].Value);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (comboBox1.SelectedIndex <= -1 && comboBox2.SelectedIndex <= -1)
                {
                    MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
                    return;
                }
                if (comboBox1.SelectedIndex >= 1 && comboBox2.SelectedIndex >= 1)
                {
                    MessageBox.Show("Vui lòng chọn một mon");
                    return;
                }
                string selectedNumber = numericUpDown1.Value.ToString();
                string selectedItem;

                if (comboBox1.SelectedIndex >= 0)
                {
                    selectedItem = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    selectedItem = comboBox2.SelectedItem.ToString();
                }
                FirebaseResponse response = await client.DeleteAsync("1/" + selectedItem);
                mydt.Rows.Clear();
                MessageBox.Show("Đã xóa thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}