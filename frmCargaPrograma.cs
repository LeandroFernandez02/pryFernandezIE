using System;
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
        public string varUsuario;
        public string varCategoria;
        public frmCargaPrograma(string usuario, string categoria)
        {
            InitializeComponent();
            varUsuario = usuario;
            varCategoria = categoria;
        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            carga();
        }

        // METODO PARA CARGAR FORMULARIO SIGUIENTE
        public void carga()
        {
            pbrCarga.Increment(2);
            lblCarga.Text = Convert.ToString("%" + pbrCarga.Value);

            if (pbrCarga.Value == pbrCarga.Maximum)
            {
                tiempoCarga.Stop();
                this.Hide();
                frmPrincipal abrirPrincipal = new frmPrincipal(varUsuario, varCategoria);
                abrirPrincipal.Show();
            }
        }

        private void frmCargaPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }
    }
}
