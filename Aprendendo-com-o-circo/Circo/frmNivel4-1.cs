﻿using System;
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
    public partial class frmNivel4_1 : Form
    {
        frmTenteNovamente tnt = new frmTenteNovamente();
        public frmNivel4_1()
        {
            InitializeComponent();
        }

        private void animal4_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void animal3_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void animal2_Click(object sender, EventArgs e)
        {
            tnt.ShowDialog();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void animal1_Click(object sender, EventArgs e)
        {
            frmNivel4_2 nv4 = new frmNivel4_2();
            this.Hide();
            nv4.ShowDialog();
        }
    }
}
