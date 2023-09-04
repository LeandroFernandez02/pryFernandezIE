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
            abrirFormHijo(new frmProveedores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmClientes());           
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAyuda());
        }

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
    }
}
