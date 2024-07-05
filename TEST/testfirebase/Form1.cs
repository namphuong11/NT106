using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace testfirebase
{
    public partial class Form1 : Form
    {
        DataTable mydt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4MuMLXbNVSf631YwFNNRS7bAqPeSyIf7nbisDcdd",
            BasePath = "https://test-66037-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datban datban = new datban();
            datban.Show();
        }
    }
}
