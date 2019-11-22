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
    public partial class frmNivel6 : Form
    {
        private List<Jogador> lista = new List<Jogador>();

        internal List<Jogador> Lista { get => lista; set => lista = value; }

        public frmNivel6()
        {
            InitializeComponent();
            foreach (Jogador item in Lista)
            {
                if (item.Player != null)
                    lblNome6.Text = item.Player;
            }
        }

        private void lblNome1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome6_Click(object sender, EventArgs e)
        {
            frmFinalnv6 fi = new frmFinalnv6();
            this.Hide();
            fi.ShowDialog();
        }

        private void frmNivel6_Load(object sender, EventArgs e)
        {
            foreach (Jogador item in Lista)
            {
                if(item.Player != null)
                 lblNome6.Text = item.Player;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
