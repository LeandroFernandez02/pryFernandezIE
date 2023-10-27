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
    public partial class frmUsuarios : Form
    {
        clsBaseDatosUsuarios objBaseDatosUsuarios;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            objBaseDatosUsuarios = new clsBaseDatosUsuarios();
            objBaseDatosUsuarios.ConectarBD();

            lblEstadoConexion.BackColor = Color.Green;

            //objBaseDatosUsuarios.TraerDatos();
        }
    }
}
