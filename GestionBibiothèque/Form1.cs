﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibiothèque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            Percentage.Text = ""+ startpoint;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }         

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }
    }
}
