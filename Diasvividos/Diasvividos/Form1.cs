using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diasvividos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {

           

            int diavida = 0;
            diavida = Convert.ToInt32(txtidade.Text) * 365;
            lbldia.Text = diavida.ToString ();

            int horavida = 0;
            horavida = (Convert.ToInt32(txtidade.Text) * 365)*24;
            lblhoras.Text = horavida.ToString(); 


        }
    }
}
