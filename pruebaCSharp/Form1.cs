﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                 textBox1.Text = "Israel";
            }
            else if(radioButton2.Checked)
            {
                textBox1.Text = "Pablo";
            }
            else
            {
                textBox1.Text = "No has escojido ningun nombre";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Israel";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Text = "Pablo";
        }
    }
}
