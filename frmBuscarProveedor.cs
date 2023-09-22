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
            string ruta = @"..\..\Proveedores";
            treDirectorios.Nodes.Clear();
            pnlCargarProveedor.Visible = false;

            DirectoryInfo rutaBase = new DirectoryInfo(ruta);

            treDirectorios.Nodes.Add(crearArbol(rutaBase));
        }

        private TreeNode crearArbol(DirectoryInfo rutaBase)
        {
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


        //CARGAR EN GRILLA
        string leerLinea;
        string[] separarDatos;

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

                string rutaArchivo = Convert.ToString(treDirectorios.SelectedNode.FullPath);
                string nombreArchivo = Convert.ToString(treDirectorios.SelectedNode.Name);


                StreamReader sr = new StreamReader(rutaArchivo);

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

                sr.Close();                    
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un Archivo");
            }
        }
        
        
        private void btnCargarProveedor_Click(object sender, EventArgs e)
        {
            pnlCargarProveedor.Visible = true;
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal volver = new frmPrincipal();
            volver.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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
            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

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
                swManejoArchivo.Write(txtLiquidador.Text + ";");
                swManejoArchivo.WriteLine();

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

        private void btnCargar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

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
                swManejoArchivo.Write(txtLiquidador.Text + ";");
                swManejoArchivo.WriteLine();

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
    }
}
