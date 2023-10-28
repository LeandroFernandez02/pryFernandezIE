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
    public partial class frmPrincipal : Form
    {
        clsBaseDatosLogs objBaseDatosLogs;
        string varUsuario;
        
        public frmPrincipal(string usuario)
        {
            InitializeComponent();

            varUsuario = usuario;

            objBaseDatosLogs = new clsBaseDatosLogs();
            objBaseDatosLogs.ConectarBD();
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
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Carga Proveedores";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);
            
            abrirFormHijo(new frmCargarProveedor());
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Buscar Proveedores";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmBuscarProveedor());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Clientes";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmClientes());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Ayuda";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmAyuda());
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Usuarios";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmUsuarios());
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
            DateTime fechaHora = DateTime.Now;
            string detalle = "Cierre de Sistema";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
