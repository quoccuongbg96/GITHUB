﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapSo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt2.Clear();
            try
            {
                if (NumericOnly.Checked)
                {
                   string q = txt1.Text.Replace("t", "00");
                   string w = txt1.Text.Replace("n", "000");
                    float a = float.Parse(q);
                    float b = float.Parse(w);
                    txt2.Text = a.ToString();
                    //txt2.Text = b.ToString();
                }
                else
            {
                string a = txt1.Text;
                txt2.Text = a;
            }
        }
            catch (Exception)
            {

                MessageBox.Show("Hãy nhập số !!!");
            }

}
    }
}
