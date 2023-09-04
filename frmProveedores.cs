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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath + @"\"+ txtProveedores.Text;

            try
            {
                if (Directory.Exists(carpeta))
                {
                    MessageBox.Show("La carpeta ya existe");
                }
                else
                {
                    MessageBox.Show("Se creo una carpeta:" + txtProveedores.Text);
                    Directory.CreateDirectory(carpeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
                throw;
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter swManejoArchivo = new StreamWriter("miarchivo", true);
                    swManejoArchivo.WriteLine(txtDatos.Text);

                    swManejoArchivo.Close();

                    MessageBox.Show("Almacenado");
                    txtDatos.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error:" + ex.Message);
                    throw;
                }
            }
        }
    }
}
