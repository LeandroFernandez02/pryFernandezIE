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
        string varUsuario;
        public frmCargaPrograma(string usuario)
        {
            InitializeComponent();
            varUsuario = usuario;
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
                frmPrincipal abrirPrincipal = new frmPrincipal(varUsuario);
                abrirPrincipal.Show();
            }
        }
    }
}
