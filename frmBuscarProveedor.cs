using System;
using System.IO;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmBuscarProveedor : Form
    {
        public frmBuscarProveedor()
        {
            InitializeComponent();
            
        }
        //SABER EXPLICAR TODO EL PROCESO 
        
        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {
            //  CREO VARIABLE RUTA
            string ruta = @"..\..\bin\Debug\Proveedores";
            treDirectorios.Nodes.Clear();
            pnlCargarProveedor.Visible = false;

            //  CREO OBJETO RUTABASE QUE HEREDA LA RUTA
            DirectoryInfo rutaBase = new DirectoryInfo(ruta);

            //  SE CREA EL TREVIEW CON LA CLASE DEFINIDA ABAJO
            treDirectorios.Nodes.Add(crearArbol(rutaBase));
        }

        // CREO UNA CLASE PARA CARGAR EL TREVIEW
        private TreeNode crearArbol(DirectoryInfo rutaBase)
        {
            //  CREA UN NODO CON LA RUTABASE
            TreeNode newNode = new TreeNode(rutaBase.Name);

            //RECORRE LOS DIRECTORIOS
            foreach(var item in rutaBase.GetDirectories())
            {            
                //INICIA RECURSIVIDAD
                newNode.Nodes.Add(crearArbol(item));
            }

            //RECORRE LOS ARCHIVOS
            foreach (var item in rutaBase.GetFiles())
            {          
                newNode.Nodes.Add(new TreeNode(item.Name));               
            }
            
            return newNode;
        }


        //  VARIABLES PARA LUEGO USAR EN GRILLA
        string leerLinea;
        string[] separarDatos;

        //  CARGA DE GRILLA
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                dgrArchivos.Rows.Clear();
                dgrArchivos.Columns.Clear();

                if (treDirectorios.SelectedNode == null)
                {
                    MessageBox.Show("Selecciona un archivo para cargar la grilla");
                    return;
                }
                else if(btnCargarArchivo.Enabled = true && treDirectorios.SelectedNode != null)
                {
                    btnCargar.Enabled = true;
                }

                //  CREO VARIABLES CON LA RUTA SELECCIONADA EN EL TREVIEW
                string rutaArchivo = Convert.ToString(treDirectorios.SelectedNode.FullPath);
                string nombreArchivo = Convert.ToString(treDirectorios.SelectedNode.Name);

                //  ABRO EL ARCHIVO PARA LEERLO
                StreamReader sr = new StreamReader(rutaArchivo, true);

                //  LEE LINEA Y SEPARA SI DETECTA ";"
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                //Carga Columna
                for (int i = 0; i < separarDatos.Length; i++)
                {
                    dgrArchivos.Columns.Add(separarDatos[i], separarDatos[i]);
                }

                //CargaFila
                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgrArchivos.Rows.Add(separarDatos);
                }

                //  CIERRO ARCHIVO
                sr.Close();
                sr.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un Archivo");
            }
        }       
        
        private void btnCargarProveedor_Click(object sender, EventArgs e)
        {
            //  MUESTRA PANEL NUEVOS PROVEEDORES
            pnlCargarProveedor.Visible = true;
            txtNumero.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {   
            //  LIMPIA
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumExpediente.Clear();
            txtJuzg.Clear();
            txtJurisd.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //  CONDICIONES
            if (treDirectorios.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un archivo en donde cargaremos el nuevo Proveedor");
                return;
            }
            if (txtNumero.Text == "" && txtApertura.Text == "" && txtJurisd.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
                return;
            }

            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

            //  CARGO EN ARCHIVO LOS NUEVOS DATOS EN CAMPOS DE TEXTO
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter(archivoSeleccionado, true);
               
                swManejoArchivo.Write(txtNumero.Text + ";");
                swManejoArchivo.Write(txtEntidad.Text + ";");
                swManejoArchivo.Write(txtApertura.Text + ";");
                swManejoArchivo.Write(txtNumExpediente.Text + ";");
                swManejoArchivo.Write(txtJuzg.Text + ";");
                swManejoArchivo.Write(txtJurisd.Text + ";");
                swManejoArchivo.Write(txtDireccion.Text + ";");
                swManejoArchivo.WriteLine(txtLiquidador.Text + ";");

                swManejoArchivo.Close();

                MessageBox.Show("Proveedor agregado");
                txtNumero.Clear();
                txtEntidad.Clear();
                txtApertura.Clear();
                txtNumExpediente.Clear();
                txtJuzg.Clear();
                txtJurisd.Clear();
                txtDireccion.Clear();
                txtLiquidador.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("No se econtro el archivo");
                throw;
            }
        }

        //  CONDICIONALES
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Condicional para solo numeros y alerta
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //  Condicional para pasar de un textbox a otro
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                txtEntidad.Focus();
                e.Handled = true;
            }
                
        }

        private void txtEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

                
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApertura.Focus();
                e.Handled = true;
            }
        }

        private void txtApertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 46) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros y /", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumExpediente.Focus();
                e.Handled = true;
            }    
        }

        private void txtNumExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 46) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros y /", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtJuzg.Focus();
                e.Handled = true;
            }
 
        }

        private void txtJuzg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 91) || (e.KeyChar >= 123 && e.KeyChar <= 247) || (e.KeyChar >= 249 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras y Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtJurisd.Focus();
                e.Handled = true;
            }
        }

        private void txtJurisd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
                e.Handled = true;
            }

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                txtLiquidador.Focus();
                e.Handled = true;
            }
        }

        private void txtLiquidador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCargar.Focus();
                e.Handled = true;
            }
        }
    }
}
