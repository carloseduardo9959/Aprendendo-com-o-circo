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
    public partial class frmNivel5_1 : Form
    {
        frmTenteNovamente tnt = new frmTenteNovamente();
        frmNivel5_2 nv5 = new frmNivel5_2();
        public frmNivel5_1()
        {
            InitializeComponent();
        }

        private void quadradoy_Click(object sender, EventArgs e)
        {
            this.Hide();
            nv5.ShowDialog();
        }

        private void triangulov_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void circulov_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void quadradoa_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void circulor_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void triangulol_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }
    }
}
