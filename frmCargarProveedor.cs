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
        }

        private void btnSeleccionCarpeta_Click(object sender, EventArgs e)
        {
            fbdSeleccionCarpeta.ShowDialog();
            lblRuta.Text = fbdSeleccionCarpeta.SelectedPath;          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //  Obtengo la ruta de la carpeta
            string ruta = fbdSeleccionCarpeta.SelectedPath;
            //  Obtengo el nombre del archivo que quiero crear
            string nombreArchivo = txtNombreArchivo.Text;

            //  Concateno una barra para que entre a la carpeta para poder crear el archivo mas el nombre con su extension
            ruta += @"\" + nombreArchivo;

            //  LLamo la variable ruta para crear el archivo con sus propiedades dadas anteriormente
            StreamWriter ManejoArchivo = new StreamWriter(ruta);
            //  Cierro el archivo para evitar coaliciones o errores
            ManejoArchivo.Close();

            MessageBox.Show("Archivo Creado");
            lblRuta.Text = "";
            txtNombreArchivo.Clear();
        }
    }
}
