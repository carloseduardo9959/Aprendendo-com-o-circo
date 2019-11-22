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
    public partial class frmNivel5_4 : Form
    {
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel5_4()
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

        private void circulor_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void triangulol_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void quadradoa_Click(object sender, EventArgs e)
        {
            frmNivel5_5 n5 = new frmNivel5_5();
            this.Hide();
            n5.ShowDialog();
        }
    }
}
