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
    public partial class frmNivel8 : Form
    {
        frmTenteNovamente tnt = new frmTenteNovamente();
        private List<Jogador> lista = new List<Jogador>();
        internal List<Jogador> Lista { get => lista; set => lista = value; }

        public frmNivel8()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNome1_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void lblNome2_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            frmFinal fi = new frmFinal();
            this.Hide();
            fi.ShowDialog();
        }

        private void frmNivel8_Load(object sender, EventArgs e)
        {
            foreach (Jogador item in Lista)
            {
                lblNome.Text = item.Player;
            }
        }
    }
}
