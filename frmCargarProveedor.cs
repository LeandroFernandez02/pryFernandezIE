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
            string ruta = fbdSeleccionCarpeta.SelectedPath;
            ruta += @"\" +  txtNombreArchivo.Text;

            StreamWriter ManejoArchivo = new StreamWriter(ruta);

            MessageBox.Show("Archivo Creado");
            lblRuta.Text = "";
            txtNombreArchivo.Clear();
        }
    }
}
