
namespace lab2
{
    partial class Bai4
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
            this.tbPathOutput = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbOuput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.labelinput = new System.Windows.Forms.Label();
            this.btnWriteInput = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.tbNumOfSV = new System.Windows.Forms.TextBox();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.tbDiemVan = new System.Windows.Forms.TextBox();
            this.tbDiemToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.bntBatDauNhap = new System.Windows.Forms.Button();
            this.tbPathInput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPathOutput
            // 
            this.tbPathOutput.BackColor = System.Drawing.SystemColors.Control;
            this.tbPathOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathOutput.Location = new System.Drawing.Point(449, 495);
            this.tbPathOutput.Multiline = true;
            this.tbPathOutput.Name = "tbPathOutput";
            this.tbPathOutput.ReadOnly = true;
            this.tbPathOutput.Size = new System.Drawing.Size(302, 99);
            this.tbPathOutput.TabIndex = 12;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(602, 179);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(146, 34);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read output.txt";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbOuput
            // 
            this.tbOuput.Location = new System.Drawing.Point(449, 217);
            this.tbOuput.Multiline = true;
            this.tbOuput.Name = "tbOuput";
            this.tbOuput.ReadOnly = true;
            this.tbOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOuput.Size = new System.Drawing.Size(299, 252);
            this.tbOuput.TabIndex = 10;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(63, 219);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInput.Size = new System.Drawing.Size(299, 253);
            this.tbInput.TabIndex = 9;
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(60, 475);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(50, 16);
            this.labelinput.TabIndex = 8;
            this.labelinput.Text = "Input.txt";
            // 
            // btnWriteInput
            // 
            this.btnWriteInput.Location = new System.Drawing.Point(63, 179);
            this.btnWriteInput.Name = "btnWriteInput";
            this.btnWriteInput.Size = new System.Drawing.Size(141, 34);
            this.btnWriteInput.TabIndex = 7;
            this.btnWriteInput.Text = "Write to input.txt";
            this.btnWriteInput.UseVisualStyleBackColor = true;
            this.btnWriteInput.Click += new System.EventHandler(this.btnWriteInput_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(158, 9);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(92, 16);
            this.labe.TabIndex = 14;
            this.labe.Text = "Number Of SV";
            // 
            // tbNumOfSV
            // 
            this.tbNumOfSV.Location = new System.Drawing.Point(273, 2);
            this.tbNumOfSV.Multiline = true;
            this.tbNumOfSV.Name = "tbNumOfSV";
            this.tbNumOfSV.Size = new System.Drawing.Size(45, 28);
            this.tbNumOfSV.TabIndex = 15;
            this.tbNumOfSV.TextChanged += new System.EventHandler(this.tbNumOfSV_TextChanged);
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(126, 55);
            this.tbMSSV.Multiline = true;
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(109, 28);
            this.tbMSSV.TabIndex = 16;
            this.tbMSSV.TextChanged += new System.EventHandler(this.tbMSSV_TextChanged);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(126, 89);
            this.tbHoTen.Multiline = true;
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(109, 28);
            this.tbHoTen.TabIndex = 17;
            this.tbHoTen.TextChanged += new System.EventHandler(this.tbHoTen_TextChanged);
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(126, 123);
            this.tbDienThoai.Multiline = true;
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(109, 28);
            this.tbDienThoai.TabIndex = 18;
            this.tbDienThoai.TextChanged += new System.EventHandler(this.tbDienThoai_TextChanged);
            // 
            // tbDiemVan
            // 
            this.tbDiemVan.Location = new System.Drawing.Point(468, 89);
            this.tbDiemVan.Multiline = true;
            this.tbDiemVan.Name = "tbDiemVan";
            this.tbDiemVan.Size = new System.Drawing.Size(109, 28);
            this.tbDiemVan.TabIndex = 20;
            this.tbDiemVan.TextChanged += new System.EventHandler(this.tbDiemVan_TextChanged);
            // 
            // tbDiemToan
            // 
            this.tbDiemToan.Location = new System.Drawing.Point(468, 55);
            this.tbDiemToan.Multiline = true;
            this.tbDiemToan.Name = "tbDiemToan";
            this.tbDiemToan.Size = new System.Drawing.Size(109, 28);
            this.tbDiemToan.TabIndex = 19;
            this.tbDiemToan.TextChanged += new System.EventHandler(this.tbDiemToan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "HoTen";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 126);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 16);
            this.label.TabIndex = 24;
            this.label.Text = "DienThoai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "DiemVan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "DiemToan";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(446, 475);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(58, 16);
            this.labelOutput.TabIndex = 28;
            this.labelOutput.Text = "output.txt";
            // 
            // bntBatDauNhap
            // 
            this.bntBatDauNhap.Location = new System.Drawing.Point(337, 0);
            this.bntBatDauNhap.Name = "bntBatDauNhap";
            this.bntBatDauNhap.Size = new System.Drawing.Size(141, 34);
            this.bntBatDauNhap.TabIndex = 29;
            this.bntBatDauNhap.Text = "Bat Dau Nhap";
            this.bntBatDauNhap.UseVisualStyleBackColor = true;
            this.bntBatDauNhap.Click += new System.EventHandler(this.bntBatDauNhap_Click);
            // 
            // tbPathInput
            // 
            this.tbPathInput.BackColor = System.Drawing.SystemColors.Control;
            this.tbPathInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathInput.Location = new System.Drawing.Point(60, 495);
            this.tbPathInput.Multiline = true;
            this.tbPathInput.Name = "tbPathInput";
            this.tbPathInput.ReadOnly = true;
            this.tbPathInput.Size = new System.Drawing.Size(302, 99);
            this.tbPathInput.TabIndex = 30;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(484, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 34);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 620);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbPathInput);
            this.Controls.Add(this.bntBatDauNhap);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDiemVan);
            this.Controls.Add(this.tbDiemToan);
            this.Controls.Add(this.tbDienThoai);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbMSSV);
            this.Controls.Add(this.tbNumOfSV);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.tbPathOutput);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.tbOuput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.labelinput);
            this.Controls.Add(this.btnWriteInput);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPathOutput;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbOuput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.Button btnWriteInput;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox tbNumOfSV;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbDienThoai;
        private System.Windows.Forms.TextBox tbDiemVan;
        private System.Windows.Forms.TextBox tbDiemToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button bntBatDauNhap;
        private System.Windows.Forms.TextBox tbPathInput;
        private System.Windows.Forms.Button btnReset;
    }
}