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

    public partial class frmNivel2 : Form
    {
        int contc = 0;
        int contf = 0;
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel2()
        {
            InitializeComponent();
        }

        private void animal1_Click(object sender, EventArgs e)
        {
            if(contc < 2)
            {
                contc++;
                lblCirculo.Text = contc.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
            
        }

        private void animal2_Click(object sender, EventArgs e)
        {
            if(contc < 2)
            {
                contc++;
                lblCirculo.Text = contc.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal3_Click(object sender, EventArgs e)
        {
            if(contc < 2)
            {
                contc++;
                lblCirculo.Text = contc.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal4_Click(object sender, EventArgs e)
        {
            if(contf < 2)
            {
                contf++;
                lblFora.Text = contf.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
        }

        private void animal5_Click(object sender, EventArgs e)
        {
            if(contf < 2)
            {
                contf++;
                lblFora.Text = contf.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
                
        }

        private void animal6_Click(object sender, EventArgs e)
        {
            if(contf < 2)
            {
                contf++;
                lblFora.Text = contf.ToString();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
        }

        private void cmdConcluido_Click(object sender, EventArgs e)
        {
            if ((contc == 2) && (contf == 2))
            {
                frmFinalnv2 fi = new frmFinalnv2();
                this.Hide();
                fi.ShowDialog();
            }
            else
            {
                contc = 0;
                contf = 0;
                lblCirculo.Text = contc.ToString();
                lblFora.Text = contf.ToString();
                tnt.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
