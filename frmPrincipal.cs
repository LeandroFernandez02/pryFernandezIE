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

        //  MENU
        private void pctLogo_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            
        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCargarProveedor());
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmBuscarProveedor());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmClientes());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAyuda());
        }

        //  ABRIR FORMULARIO DENTRO DEL PRINCIPAL
        private Form formActivo = null;

        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(formHijo);
            pnlFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        // HORA
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToLongTimeString();
            string fecha = DateTime.Now.ToLongDateString();
            lblFechaHora.Text = hora + "   " + fecha; 
        }

        // CERRAR Y MINIMIZAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
