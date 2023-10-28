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
    public partial class frmClientes : Form
    {
        clsBaseDatosCliente objBaseDatosCliente;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            objBaseDatosCliente = new clsBaseDatosCliente();
            objBaseDatosCliente.ConectarBD();

            lblEstadoConexion.Text = objBaseDatosCliente.estadoConexion;
            lblEstadoConexion.BackColor = Color.Green;

            objBaseDatosCliente.TraerDatos(dgvCliente);
        }

        private void btnLocura_Click(object sender, EventArgs e)
        {
            try
            {
                objBaseDatosCliente.BuscarPorID(int.Parse(txtBuscar.Text));
            }
            catch (Exception)
            {
                if(txtBuscar.Text == "")
                {
                    MessageBox.Show("El campo esta vacio");
                }
                else
                {
                    MessageBox.Show("El movimiento no existe");
                }              
            }
            
        }
    }
}
