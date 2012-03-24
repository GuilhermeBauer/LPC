using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Total_a_ser_pago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            int valcompra=0;
            valcompra = Convert.ToInt32(txtValor.Text);
            total = valcompra - ((valcompra * Convert.ToInt32(txtDesconto.Text))/100);

            lblPago.Text = total.ToString();



        }

       
    }
}
