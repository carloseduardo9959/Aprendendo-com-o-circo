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
    public partial class frmNv1 : Form
    {
        frmParabensnv1 pra = new frmParabensnv1();
        frmTenteNovamente tnt = new frmTenteNovamente();
        public void RadImage()
        {
            Random img = new Random();
            int a;
            a = img.Next(2);
            txtTeste.Text = a.ToString();
            if (a == 0)
            {
                BackgroundImage = Properties.Resources.Nivel1;
            }
            if (a == 1)
            {
                BackgroundImage = Properties.Resources.Nivel1_1;
            }
               
        }
        
        public frmNv1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNv1_Load(object sender, EventArgs e)
        {
            RadImage();
        }

        private void cmdPoucas_Click(object sender, EventArgs e)
        {
            int R = int.Parse(txtTeste.Text);
            if (R == 0)
            {
                pra.ShowDialog();
            }
            else
            {
                tnt.ShowDialog();
            }
        }

        private void cmdMuitas_Click(object sender, EventArgs e)
        {
            int R = int.Parse(txtTeste.Text);
            if (R == 1)
            {
                pra.ShowDialog();
            }
            else
            {
                tnt.ShowDialog();
            }
        }
    }
}
