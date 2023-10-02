﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmCargaPrograma : Form
    {
        private int conteo;
        public frmCargaPrograma()
        {
            InitializeComponent();

        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            carga();
        }

        public void carga()
        {
            pbrCarga.Increment(2);
            if (pbrCarga.Value == pbrCarga.Maximum)
            {
                tiempoCarga.Stop();
                this.Hide();
                frmPrincipal abrirPrincipal = new frmPrincipal();
                abrirPrincipal.Show();
            }
        }
    }
}