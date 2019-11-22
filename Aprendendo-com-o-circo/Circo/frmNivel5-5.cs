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
    public partial class frmNivel5_5 : Form
    {
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel5_5()
        {
            InitializeComponent();
        }

        private void circulov_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void triangulov_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void quadradoy_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void triangulol_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void quadradoa_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void circulor_Click(object sender, EventArgs e)
        {
            frmFinalnv5 n5 = new frmFinalnv5();
            this.Hide();
            n5.ShowDialog();
        }
    }
}
