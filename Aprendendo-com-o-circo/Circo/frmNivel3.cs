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
    public partial class frmNivel3 : Form
    {
        Animais animal = new Animais();
        frmTenteNovamente tnt = new frmTenteNovamente();
        int ag = 0;
        int ap = 0;
        Bitmap an1 = null, an2 = null, an3 = null, an4 = null, an5 = null, an6 = null;

        private void animal2_Click(object sender, EventArgs e)
        {
            if (ap < 2)
            {
                an2 = Properties.Resources.Cachorro;
                ap++;
                lblPequenos.Text = ap.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }

        }

        private void animal3_Click(object sender, EventArgs e)
        {
            if (ag < 2)
            {
                an3 = Properties.Resources.Girafa;
                ag++;
                lblGrandes.Text = ag.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal6_Click(object sender, EventArgs e)
        {
            if(ap < 2)
            {
                an6 = Properties.Resources.Cobra;
                ap++;
                lblPequenos.Text = ap.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdConcluido_Click(object sender, EventArgs e)
        {
            if((ag ==2)&&(ap==2))
            {
                frmFinalnv3 fnv3 = new frmFinalnv3();
                this.Hide();
                fnv3.ShowDialog();
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void animal4_Click(object sender, EventArgs e)
        {
            if (ap < 2)
            {
                an4 = Properties.Resources.Coelho;
                ap++;
                lblPequenos.Text = ap.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal5_Click(object sender, EventArgs e)
        {
            if (ag < 2)
            {
                an5 = Properties.Resources.Elefante;
                ag++;
                lblGrandes.Text = ag.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal1_Click(object sender, EventArgs e)
        {
            if (ag < 2)
            {
                an1 = Properties.Resources.Leão;
                ag++;
                lblGrandes.Text = ag.ToString();
            }
            else
            {
                ag = 0;
                ap = 0;
                lblGrandes.Text = ag.ToString();
                lblPequenos.Text = ap.ToString();
                tnt.ShowDialog();
            }
        }

        public frmNivel3()
        {
            InitializeComponent();
        }
    }
}
