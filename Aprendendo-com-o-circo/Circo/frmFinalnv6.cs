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
    public partial class frmFinalnv6 : Form
    {
        public frmFinalnv6()
        {
            InitializeComponent();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmNivel7 n7 = new frmNivel7();
            this.Hide();
            n7.ShowDialog();
        }
    }
}
