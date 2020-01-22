﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ButtonDesign buttonDesign = new ButtonDesign();
            buttonDesign.ShowDialog();
            Vars.ColorAllButtons(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Vars.ColorAllButtons(this);
        }
    }
}
