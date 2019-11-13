using System;
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
        Base obj = new Base();
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(obj.Factorial(Convert.ToInt32(txtInput.Text)).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }
        
    }
}
