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
    public partial class frmPrincipal : Form
    {
        Jogador p = new Jogador();
        frmNv1 nv1 = new frmNv1();
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            p.Player = txtNome.Text;
            nv1.ShowDialog();
        }
    }
}