using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace instrucoescondicionais
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testando botao mostrar", "Ops! Mostrou",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation);
        }
    }
}
