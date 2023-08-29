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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.ShowDialog();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.ShowDialog();
            this.Close();
        }
    }
}
