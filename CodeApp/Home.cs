﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLibrary;

namespace CodeApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            Base obj = new Base();
            MessageBox.Show(obj.Factorial(Convert.ToInt32(txtInput.Text)).ToString());
        }
    }
}
