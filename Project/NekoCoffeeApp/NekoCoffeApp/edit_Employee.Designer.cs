﻿namespace UI
{
    partial class edit_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_Employee));
            this.adminEmployeeManagement1 = new UI.AdminEmployeeManagement();
            this.SuspendLayout();
            // 
            // adminEmployeeManagement1
            // 
            this.adminEmployeeManagement1.BackColor = System.Drawing.Color.White;
            this.adminEmployeeManagement1.Location = new System.Drawing.Point(-5, 4);
            this.adminEmployeeManagement1.Margin = new System.Windows.Forms.Padding(4);
            this.adminEmployeeManagement1.Name = "adminEmployeeManagement1";
            this.adminEmployeeManagement1.Size = new System.Drawing.Size(1604, 1033);
            this.adminEmployeeManagement1.TabIndex = 0;
            this.adminEmployeeManagement1.Load += new System.EventHandler(this.adminEmployeeManagement1_Load);
            // 
            // edit_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1050);
            this.Controls.Add(this.adminEmployeeManagement1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_Employee";
            this.Text = "customer_edit";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminEmployeeManagement adminEmployeeManagement1;
    }
}