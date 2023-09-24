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

            //  CREO LOS CAMPOS EN EL ARCHIVOS .CSV
            string Numero = "";
            string Entidad = "";
            string Apertura = "";
            string NumExpediente = "";
            string Juzgado = "";
            string Juridiccion = "";
            string Direccion = "";
            string Liquidador = "";

            //  ABRO EL ARCHIVO 
            StreamWriter ManejoArchivo = new StreamWriter(ruta, true);
           
            //  LLAMO LOS CAMPOS ANTERIORMENTE CREADOS(se separan con ";")
            ManejoArchivo.Write(Numero + "N° ;");
            ManejoArchivo.Write(Entidad + "Entidad ;");
            ManejoArchivo.Write(Apertura + "APERTURA ;");
            ManejoArchivo.Write(NumExpediente + "N° EXPTE. ;");
            ManejoArchivo.Write(Juzgado + "JUZG. ;");
            ManejoArchivo.Write(Juridiccion + "JURISD. ;");
            ManejoArchivo.Write(Direccion + "DIRECCION ;");
            ManejoArchivo.WriteLine(Liquidador + "LIQUIDADOR RESPONSABLE");

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
