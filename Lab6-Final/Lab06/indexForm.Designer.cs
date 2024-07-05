namespace Lab06
{
    partial class indexForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.joinUsername = new System.Windows.Forms.TextBox();
            this.joinIP = new System.Windows.Forms.TextBox();
            this.joinPort = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Montserrat", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(224, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 72);
            this.label5.TabIndex = 22;
            this.label5.Text = "GUESS NUMBER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "IP Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username: ";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Khaki;
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClient.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClient.Location = new System.Drawing.Point(127, 380);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(500, 68);
            this.btnClient.TabIndex = 15;
            this.btnClient.Text = "Join room ";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // hostPort
            // 
            this.hostPort.BackColor = System.Drawing.SystemColors.Control;
            this.hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hostPort.ForeColor = System.Drawing.Color.Black;
            this.hostPort.Location = new System.Drawing.Point(330, 211);
            this.hostPort.Margin = new System.Windows.Forms.Padding(4);
            this.hostPort.MaxLength = 5;
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(208, 32);
            this.hostPort.TabIndex = 16;
            this.hostPort.Text = "65535";
            this.hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinUsername
            // 
            this.joinUsername.BackColor = System.Drawing.SystemColors.Control;
            this.joinUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.joinUsername.ForeColor = System.Drawing.Color.Black;
            this.joinUsername.Location = new System.Drawing.Point(330, 109);
            this.joinUsername.Margin = new System.Windows.Forms.Padding(4);
            this.joinUsername.Name = "joinUsername";
            this.joinUsername.Size = new System.Drawing.Size(208, 32);
            this.joinUsername.TabIndex = 12;
            this.joinUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinIP
            // 
            this.joinIP.BackColor = System.Drawing.SystemColors.Control;
            this.joinIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.joinIP.ForeColor = System.Drawing.Color.Black;
            this.joinIP.Location = new System.Drawing.Point(330, 158);
            this.joinIP.Margin = new System.Windows.Forms.Padding(4);
            this.joinIP.Name = "joinIP";
            this.joinIP.Size = new System.Drawing.Size(208, 32);
            this.joinIP.TabIndex = 13;
            this.joinIP.Text = "localhost";
            this.joinIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinPort
            // 
            this.joinPort.BackColor = System.Drawing.SystemColors.Control;
            this.joinPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.joinPort.ForeColor = System.Drawing.Color.Black;
            this.joinPort.Location = new System.Drawing.Point(330, 261);
            this.joinPort.Margin = new System.Windows.Forms.Padding(4);
            this.joinPort.MaxLength = 5;
            this.joinPort.Name = "joinPort";
            this.joinPort.Size = new System.Drawing.Size(208, 32);
            this.joinPort.TabIndex = 14;
            this.joinPort.Text = "65535";
            this.joinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Khaki;
            this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnServer.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnServer.Location = new System.Drawing.Point(127, 304);
            this.btnServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(500, 68);
            this.btnServer.TabIndex = 17;
            this.btnServer.Text = "New room";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.joinUsername);
            this.Controls.Add(this.joinIP);
            this.Controls.Add(this.joinPort);
            this.Controls.Add(this.btnServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "indexForm";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.TextBox joinUsername;
        private System.Windows.Forms.TextBox joinIP;
        private System.Windows.Forms.TextBox joinPort;
        private System.Windows.Forms.Button btnServer;
    }
}