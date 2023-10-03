using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryFernandezIES
{
    public partial class frmCargarProveedor : Form
    {
        public frmCargarProveedor()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            fbdSeleccionCarpeta.SelectedPath = Application.StartupPath + "\\Proveedores";
        }

        private void btnSeleccionCarpeta_Click(object sender, EventArgs e)
        {
            //SELECCIONO RUTA DE LA CARPETA
            fbdSeleccionCarpeta.ShowDialog();
            lblDireccion.Text = fbdSeleccionCarpeta.SelectedPath;

            if (btnSeleccionCarpeta.DialogResult == DialogResult.OK || btnSeleccionCarpeta.Enabled == true)
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //  CREO VARIABLE CON LA RUTA SELECCIONADA Y CREO VARIABLE NOMBRE DE ARCHIVO .CSV
            string ruta = fbdSeleccionCarpeta.SelectedPath;
            string nombreArchivo = txtNombreArchivo.Text + ".csv";

            //  CONCATENO LA RUTA MAS UNA BARRA PARA ENTRAR A LA CARPETA SELECCIONADA Y EL NOMBRE DEL ARCHIVO
            ruta += @"\" + nombreArchivo;         

            //  ABRO EL ARCHIVO 
            StreamWriter ManejoArchivo = new StreamWriter(ruta, false);
           
            //  LLAMO LOS CAMPOS ANTERIORMENTE CREADOS(se separan con ";")
            ManejoArchivo.Write("N° ;");
            ManejoArchivo.Write("Entidad ;");
            ManejoArchivo.Write("APERTURA ;");
            ManejoArchivo.Write("N° EXPTE. ;");
            ManejoArchivo.Write("JUZG. ;");
            ManejoArchivo.Write("JURISD. ;");
            ManejoArchivo.Write("DIRECCION ;");
            ManejoArchivo.WriteLine("LIQUIDADOR RESPONSABLE");

            //  CIERRO EL ARCHIVO
            ManejoArchivo.Close();
            ManejoArchivo.Dispose();

            // MENSAJE
            MessageBox.Show("Archivo Creado");
            lblDireccion.Text = "";
            txtNombreArchivo.Clear();
        }
    }
}
