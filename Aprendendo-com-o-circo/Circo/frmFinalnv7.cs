using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circo
{
    public partial class frmFinalnv7 : Form
    {
        public frmFinalnv7()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmNivel8 n8 = new frmNivel8();
            frmPrincipal p = new frmPrincipal();
            n8.Lista = p.Lista;
            this.Hide();
            n8.ShowDialog();
        }
    }
}
