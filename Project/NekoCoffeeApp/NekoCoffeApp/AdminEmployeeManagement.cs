﻿using Aspose.Email.PersonalInfo;
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace UI
{
    public partial class AdminEmployeeManagement : System.Windows.Forms.UserControl
    {

        public AdminEmployeeManagement()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient emp;
        private void AdminEmployeeManagement_Load(object sender, EventArgs e)
        {

            try
            {
                emp = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();

        }

        private void AdminAddEmployee_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(AdminFillEmployeeDateOfBirth.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeeGender.Text) ||
            string.IsNullOrWhiteSpace(AdminFillEmployeeShift.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminFillEmployeeID.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeeName.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeeSalary.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            FirebaseResponse res = emp.Get(@"Employees/" + AdminFillEmployeeID.Text);
            NekoEmployee ResEmployee = res.ResultAs<NekoEmployee>();

            NekoEmployee CurEmployee = new NekoEmployee()
            {
                ID = AdminFillEmployeeID.Text
            };

            if (NekoEmployee.Search(ResEmployee, CurEmployee))
            {
                NekoEmployee.ShowError_2();
                return;
            }

            NekoEmployee employee = new NekoEmployee()
            {
                ID = AdminFillEmployeeID.Text,
                Name = AdminFillEmployeeName.Text,
                DateOfBirth = AdminFillEmployeeDateOfBirth.Text,
                Gender = AdminFillEmployeeGender.Text,
                Shift = AdminFillEmployeeShift.Text,
                PhoneNumber = AdminFillEmployeePhoneNumber.Text,
                Email = AdminFillEmployeeEmail.Text,
                Salary = int.Parse(AdminFillEmployeeSalary.Text)
            };

            SetResponse set = emp.Set(@"Employees/" + AdminFillEmployeeID.Text, employee);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công nhân viên {AdminFillEmployeeID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
            }
            
        }


       

        async void viewData()
        {
            var data = await emp.GetAsync(@"/Employees");
            //var mList = JsonConvert.DeserializeObject<Dictionary<string, NekoEmployee>>(data.Body);
            //var listNumber = mList.Values.ToList();
            //AdminViewAllEmployees.DataSource = listNumber;
            var employeeList = JsonConvert.DeserializeObject<List<NekoEmployee>>(data.Body);

            AdminViewAllEmployees.DataSource = employeeList;
        }

        private void AdminShowAllEmployees_Click(object sender, EventArgs e)
        {

        }

        private void AdminDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(AdminFillEmployeeID.Text)    )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FirebaseResponse res = emp.Get(@"Employees/" + AdminFillEmployeeID.Text);
            NekoEmployee ResEmployee = res.ResultAs<NekoEmployee>();

            NekoEmployee CurEmployee = new NekoEmployee()
            {
                ID = AdminFillEmployeeID.Text
            };

            if (!NekoEmployee.IsExist(ResEmployee, CurEmployee))
            {
                NekoEmployee.ShowError_3();
                return;
            }
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản này?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var delete = emp.Delete(@"Employees/" + AdminFillEmployeeID.Text);
                if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Xoá nhân viên {AdminFillEmployeeID.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminFillEmployeeID.Clear();                  
                }
            }
            else
            {
                return;
            }
            viewData();

        }

        private void AdminUpdateEmployee_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = emp.Get(@"Employees/" + AdminFillEmployeeID.Text);
            NekoEmployee ResEmployee = res.ResultAs<NekoEmployee>();

            NekoEmployee CurEmployee = new NekoEmployee()
            {
                ID = AdminFillEmployeeID.Text
            };

            if (!NekoEmployee.IsExist(ResEmployee, CurEmployee))
            {
                NekoEmployee.ShowError_3();
                return;
            }
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NekoEmployee employee = new NekoEmployee()
                {
                    ID = AdminFillEmployeeID.Text,
                    Name = AdminFillEmployeeName.Text,
                    DateOfBirth = AdminFillEmployeeDateOfBirth.Text,
                    Gender = AdminFillEmployeeGender.Text,
                    Shift = AdminFillEmployeeShift.Text,
                    PhoneNumber = AdminFillEmployeePhoneNumber.Text,
                    Email = AdminFillEmployeeEmail.Text,
                    Salary = int.Parse(AdminFillEmployeeSalary.Text)
                };
                FirebaseResponse update = emp.Update(@"Employees/" + AdminFillEmployeeID.Text, employee);
                if (update.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Sửa nhân viên {AdminFillEmployeeID.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminFillEmployeeID.Clear();
                }
            }
            else
            {
                return;
            }
            viewData();
        }

        private void AdminCheckEmployee_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(AdminFillEmployeeSearch.Text))
                {
                    MessageBox.Show("Vui lòng điền ID nhân viên", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = emp.Get(@"Employees/" + AdminFillEmployeeSearch.Text);
                NekoEmployee existingEmployee = response.ResultAs<NekoEmployee>();

                if (existingEmployee == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AdminFillEmployeeID.Text = existingEmployee.ID;
                AdminFillEmployeeName.Text = existingEmployee.Name;
                AdminFillEmployeeDateOfBirth.Text = existingEmployee.DateOfBirth;
                AdminFillEmployeeGender.Text = existingEmployee.Gender;
                AdminFillEmployeeShift.Text = existingEmployee.Shift;
                AdminFillEmployeePhoneNumber.Text = existingEmployee.PhoneNumber;
                AdminFillEmployeeEmail.Text = existingEmployee.Email;
                AdminFillEmployeeSalary.Text = existingEmployee.Salary.ToString();
            
        }

        private void AdminFillEmployeePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminFillEmployeeAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
