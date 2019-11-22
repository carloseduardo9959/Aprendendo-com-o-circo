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
    public partial class frmNivel7 : Form
    {
        int c = 1;
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel7()
        {
            InitializeComponent();
        }
        public void baloes ()
        {
        }
        private void pb1_Click(object sender, EventArgs e)
        {
            if((c > 0) && (c <= 3))
            {
                pb1.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if((c > 0) && (c <=3))
            {
                pb7.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            if((c > 0) && (c <=3))
            {
                pb13.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if((c >=4 ) && (c <= 6))
            {
                pb2.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if ((c >= 4) && (c <= 6))
            {
                pb9.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            if ((c >= 4) && (c <= 6))
            {
                pb16.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if ((c >= 7) && (c <= 9))
            {
                pb5.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            if ((c >= 7) && (c <= 9))
            {
                pb11.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            if ((c >= 7) && (c <= 9))
            {
                pb15.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if ((c >= 10) && (c <= 12))
            {
                pb4.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if ((c >= 10) && (c <= 12))
            {
                pb8.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            if ((c >= 10) && (c <= 12))
            {
                pb14.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if ((c >= 13) && (c <= 14))
            {
                pb6.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            if ((c >= 13) && (c <= 14))
            {
                pb10.Image = null;
                c++;
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if ((c >= 15) && (c <= 16))
            {
                pb3.Image = null;
                c++;
                fim();
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            if ((c >= 15) && (c <= 16))
            {
                pb12.Image = null;
                c++;
                fim();
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void fim ()
        {
            if(c > 16)
            {
                frmFinalnv7 fi = new frmFinalnv7();
                this.Hide();
                fi.ShowDialog();
            }
        }
    }
}
