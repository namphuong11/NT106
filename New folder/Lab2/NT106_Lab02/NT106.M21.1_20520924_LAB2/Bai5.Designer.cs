
namespace NT106.M21._1_20520924_LAB2
{
    partial class Bai5
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
            this.listViewFileInfo = new System.Windows.Forms.ListView();
            this.clnTenFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnKichThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDuoiMoRong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgayTao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFileInfo
            // 
            this.listViewFileInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTenFile,
            this.clnKichThuoc,
            this.clnDuoiMoRong,
            this.clnNgayTao});
            this.listViewFileInfo.GridLines = true;
            this.listViewFileInfo.HideSelection = false;
            this.listViewFileInfo.Location = new System.Drawing.Point(33, 25);
            this.listViewFileInfo.Name = "listViewFileInfo";
            this.listViewFileInfo.Size = new System.Drawing.Size(1174, 372);
            this.listViewFileInfo.TabIndex = 0;
            this.listViewFileInfo.UseCompatibleStateImageBehavior = false;
            this.listViewFileInfo.View = System.Windows.Forms.View.Details;
            this.listViewFileInfo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewFileInfo_ColumnClick);
            // 
            // clnTenFile
            // 
            this.clnTenFile.Text = "Tên File";
            this.clnTenFile.Width = 167;
            // 
            // clnKichThuoc
            // 
            this.clnKichThuoc.Text = "Kích Thước (byte)";
            this.clnKichThuoc.Width = 225;
            // 
            // clnDuoiMoRong
            // 
            this.clnDuoiMoRong.Text = "Đuôi Mở Rộng";
            this.clnDuoiMoRong.Width = 241;
            // 
            // clnNgayTao
            // 
            this.clnNgayTao.Text = "Ngày Tạo";
            this.clnNgayTao.Width = 121;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(552, 413);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(184, 32);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 469);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.listViewFileInfo);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFileInfo;
        private System.Windows.Forms.ColumnHeader clnTenFile;
        private System.Windows.Forms.ColumnHeader clnKichThuoc;
        private System.Windows.Forms.ColumnHeader clnDuoiMoRong;
        private System.Windows.Forms.ColumnHeader clnNgayTao;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}