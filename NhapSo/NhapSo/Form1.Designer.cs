﻿namespace NhapSo
{
    partial class Form1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.NumericOnly = new System.Windows.Forms.CheckBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(89, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(172, 20);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NumericOnly
            // 
            this.NumericOnly.AutoSize = true;
            this.NumericOnly.Location = new System.Drawing.Point(175, 75);
            this.NumericOnly.Name = "NumericOnly";
            this.NumericOnly.Size = new System.Drawing.Size(86, 17);
            this.NumericOnly.TabIndex = 1;
            this.NumericOnly.Text = "NumericOnly";
            this.NumericOnly.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(88, 124);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(172, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.NumericOnly);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox NumericOnly;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
    }
}

