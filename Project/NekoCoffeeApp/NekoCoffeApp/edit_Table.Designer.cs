﻿namespace UI
{
    partial class edit_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_Table));
            this.adminTable1 = new UI.AdminTable();
            this.SuspendLayout();
            // 
            // adminTable1
            // 
            this.adminTable1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.adminTable1.BackColor = System.Drawing.Color.White;
            this.adminTable1.Location = new System.Drawing.Point(12, 12);
            this.adminTable1.Name = "adminTable1";
            this.adminTable1.Size = new System.Drawing.Size(735, 540);
            this.adminTable1.TabIndex = 0;
            // 
            // edit_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 571);
            this.Controls.Add(this.adminTable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "edit_Table";
            this.Text = "edit_Table";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminTable adminTable1;
    }
}