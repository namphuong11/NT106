
namespace NT106.M21._1_20520924_LAB2
{
    partial class Bai3
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
            this.btnReadInput = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOuput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbPathOutput = new System.Windows.Forms.TextBox();
            this.tbPathInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(311, 31);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(75, 34);
            this.btnReadInput.TabIndex = 0;
            this.btnReadInput.Text = "Open Input";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(6, 31);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInput.Size = new System.Drawing.Size(299, 253);
            this.tbInput.TabIndex = 3;
            // 
            // tbOuput
            // 
            this.tbOuput.Location = new System.Drawing.Point(392, 29);
            this.tbOuput.Multiline = true;
            this.tbOuput.Name = "tbOuput";
            this.tbOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOuput.Size = new System.Drawing.Size(299, 252);
            this.tbOuput.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(311, 71);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 37);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbPathOutput
            // 
            this.tbPathOutput.BackColor = System.Drawing.SystemColors.Control;
            this.tbPathOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathOutput.Location = new System.Drawing.Point(392, 287);
            this.tbPathOutput.Multiline = true;
            this.tbPathOutput.Name = "tbPathOutput";
            this.tbPathOutput.Size = new System.Drawing.Size(302, 126);
            this.tbPathOutput.TabIndex = 6;
            // 
            // tbPathInput
            // 
            this.tbPathInput.BackColor = System.Drawing.SystemColors.Control;
            this.tbPathInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathInput.Location = new System.Drawing.Point(6, 290);
            this.tbPathInput.Multiline = true;
            this.tbPathInput.Name = "tbPathInput";
            this.tbPathInput.Size = new System.Drawing.Size(302, 126);
            this.tbPathInput.TabIndex = 7;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 436);
            this.Controls.Add(this.tbPathInput);
            this.Controls.Add(this.tbPathOutput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbOuput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnReadInput);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOuput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbPathOutput;
        private System.Windows.Forms.TextBox tbPathInput;
    }
}