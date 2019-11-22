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
    public partial class frmNivel5 : Form
    {
        frmNivel5_1 n5 = new frmNivel5_1();
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel5()
        {
            InitializeComponent();
        }

        private void circulov_Click(object sender, EventArgs e)
        {
            this.Hide();
            n5.ShowDialog();
        }

        private void triangulov_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void quadradoy_Click(object sender, EventArgs e)
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
