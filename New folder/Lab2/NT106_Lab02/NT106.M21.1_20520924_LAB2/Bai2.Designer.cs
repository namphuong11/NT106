
namespace NT106.M21._1_20520924_LAB2
{
    partial class Bai2
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
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.bntRead = new System.Windows.Forms.Button();
            this.richtbContent = new System.Windows.Forms.RichTextBox();
            this.tbNumL = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(100, 154);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(250, 22);
            this.tbFileName.TabIndex = 0;
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(21, 44);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(161, 76);
            this.bntRead.TabIndex = 1;
            this.bntRead.Text = "Read File";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // richtbContent
            // 
            this.richtbContent.Location = new System.Drawing.Point(356, 55);
            this.richtbContent.Name = "richtbContent";
            this.richtbContent.Size = new System.Drawing.Size(432, 374);
            this.richtbContent.TabIndex = 2;
            this.richtbContent.Text = "";
            // 
            // tbNumL
            // 
            this.tbNumL.Location = new System.Drawing.Point(169, 210);
            this.tbNumL.Name = "tbNumL";
            this.tbNumL.Size = new System.Drawing.Size(181, 22);
            this.tbNumL.TabIndex = 4;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(100, 182);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(250, 22);
            this.tbUrl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Lines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of characters";
            // 
            // tbNumC
            // 
            this.tbNumC.Location = new System.Drawing.Point(169, 238);
            this.tbNumC.Name = "tbNumC";
            this.tbNumC.Size = new System.Drawing.Size(181, 22);
            this.tbNumC.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of words";
            // 
            // tbNumW
            // 
            this.tbNumW.Location = new System.Drawing.Point(169, 266);
            this.tbNumW.Name = "tbNumW";
            this.tbNumW.Size = new System.Drawing.Size(181, 22);
            this.tbNumW.TabIndex = 13;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbNumL);
            this.Controls.Add(this.richtbContent);
            this.Controls.Add(this.bntRead);
            this.Controls.Add(this.tbFileName);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.RichTextBox richtbContent;
        private System.Windows.Forms.TextBox tbNumL;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumW;
    }
}