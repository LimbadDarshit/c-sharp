﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;

            if (progressBar1.Value >= 100)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

                timer1.Enabled = false;
            }
            
        }
    }
}
