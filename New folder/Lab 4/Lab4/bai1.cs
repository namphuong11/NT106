using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }
        private string getHTML(string szUrl)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szUrl);
                // Get the response.
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Close the response.
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine(ex.Message);
                // Return a null string to indicate failure
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string link = textBox1.Text;
            if (string.IsNullOrWhiteSpace(link))
            {
                MessageBox.Show("Vui lòng nhập link website", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string result = getHTML(link);
                if (result != null)
                {
                    richTextBox1.Text = result;
                }
                else
                {
                    MessageBox.Show("Không thể lấy nội dung từ URL. Vui lòng kiểm tra lại link hoặc kết nối mạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
