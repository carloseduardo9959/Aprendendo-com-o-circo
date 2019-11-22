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
    public partial class frmFinalnv2 : Form
    {
        public frmFinalnv2()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmNivel3 nv3 = new frmNivel3();
            this.Hide();
            nv3.ShowDialog();
        }
    }
}
