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
    public partial class frmFinalnv5 : Form
    {
        public frmFinalnv5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmNivel6 n6 = new frmNivel6();
            frmPrincipal p = new frmPrincipal();
            n6.Lista = p.Lista;
            n6.ShowDialog();
        }
    }
}
