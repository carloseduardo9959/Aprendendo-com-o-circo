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
    public partial class frmFinalnv3 : Form
    {
        public frmFinalnv3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmNivel4 nv4 = new frmNivel4();
            this.Hide();
            nv4.ShowDialog();
        }
    }
}
