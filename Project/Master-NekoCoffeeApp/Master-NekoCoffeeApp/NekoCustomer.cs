﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
{
    internal class NekoCustomer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        private static string error1 = "Khách hàng không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {

            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Khách hàng đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_3()
        {
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static bool IsExist(NekoCustomer customer1, NekoCustomer customer2)
        {
            if (customer1 == null || customer2 == null) { return false; }

            if (customer1.ID != customer2.ID)
            {
                error1 = "Khách hàng không tồn tại!";
                return false;
            }
            return true;
        }


        public static bool Search(NekoCustomer customer1, NekoCustomer customer2)
        {
            if (customer1 == null || customer2 == null) { return false; }

            if (customer1.ID != customer2.ID)
            {
                System.Windows.Forms.MessageBox.Show("Khách hàng không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
