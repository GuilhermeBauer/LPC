using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int total = 0;
            total = Convert.ToInt32(txtValor1.Text) + Convert.ToInt32(txtValor2.Text);
            lblTotal.Text = total.ToString();
        }
    }
}
