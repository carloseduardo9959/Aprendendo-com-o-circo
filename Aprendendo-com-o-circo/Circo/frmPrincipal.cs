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
    public partial class frmPrincipal : Form
    {
        frmNv1 nv1 = new frmNv1();
        private List<Jogador> lista = new List<Jogador>();
        Jogador c1 = null;

        internal List<Jogador> Lista { get => lista; set => lista = value; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            c1 = new Jogador();
            c1.Player = txtNome.Text;
            Lista.Add(c1);
            nv1.ShowDialog();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome.Text = null;
        }
    }
}
