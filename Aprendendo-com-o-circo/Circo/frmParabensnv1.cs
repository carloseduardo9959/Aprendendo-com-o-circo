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
    public partial class frmParabensnv1 : Form
    {
        frmNivel2 nv2 = new frmNivel2();
        public frmParabensnv1()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            nv2.ShowDialog();
        }
    }
}
