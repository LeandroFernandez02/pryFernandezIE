using System;
using System.IO;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmBuscarProveedor : Form
    {
        DirectoryInfo rutaBase = new DirectoryInfo(@"../../Resources/Proveedores/");
        public frmBuscarProveedor()
        {
            InitializeComponent();

            treDirectorios.Nodes.Clear();
            //DirectoryInfo rutaBase = new DirectoryInfo(@"../../Resources/Proveedores/");            
            treDirectorios.Nodes.Add(crearArbol(rutaBase));
        }

        //CREA TREVIEW
        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {         
            pnlCargarProveedor.Visible = false;
          
        }

        // CREO UNA METODO PARA CARGAR EL TREVIEW
        private TreeNode crearArbol(DirectoryInfo rutaBase)
        {
            //  CREA UN NODO CON LA RUTABASE
            TreeNode newNode = new TreeNode(rutaBase.Name);

            //RECORRE LOS DIRECTORIOS
            foreach (var dir in rutaBase.GetDirectories())
            {
                //INICIA RECURSIVIDAD
                newNode.Nodes.Add(crearArbol(dir));
            }

            //RECORRE LOS ARCHIVOS
            foreach (var file in rutaBase.GetFiles())
            {
                newNode.Nodes.Add(new TreeNode(file.Name));
            }

            return newNode;
        }

        //  CARGA DE GRILLA
        private void btnMostrarProveedor_Click(object sender, EventArgs e)
        {
            limpiar();
            string leerLinea;
            string[] separarDatos;
            try
            {
                btnNuevoProveedor.Visible = true;
                btnModificarProveedor.Visible = true;
                btnEliminarProveedor.Visible = true;
                btnLimpiar.Visible = true;
                pnlCargarProveedor.Visible = true;
                dgrArchivos.Rows.Clear();
                dgrArchivos.Columns.Clear();

                if (treDirectorios.SelectedNode == null)
                {
                    MessageBox.Show("Selecciona un archivo para cargar la grilla");
                    return;
                }
                //  CREO VARIABLES CON LA RUTA SELECCIONADA EN EL TREVIEW
                string rutaArchivo = @"../../Resources/" + Convert.ToString(treDirectorios.SelectedNode.FullPath);
                //string nombreArchivo = @"../../Resources/" + Convert.ToString(treDirectorios.SelectedNode.Name);

                //  ABRO EL ARCHIVO PARA LEERLO
                StreamReader sr = new StreamReader(rutaArchivo, true);

                //  LEE LINEA Y SEPARA SI DETECTA "; "
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
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un Archivo" + ex);
            }
        }

        // AGREGAR
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            //  CONDICIONES
            if (txtNumero.Text == "" && txtEntidad.Text == "" && txtApertura.Text == "" && txtNumExpediente.Text == "" && txtJuzg.Text == "" && txtJurisd.Text == "" && txtDireccion.Text == "" && txtLiquidador.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
                return;
            }


            //  CARGO EN ARCHIVO LOS NUEVOS DATOS EN CAMPOS DE TEXTO

            try
            {
                string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

                StreamWriter swNuevo = new StreamWriter(archivoSeleccionado, true);

                swNuevo.Write(txtNumero.Text + ";");
                swNuevo.Write(txtEntidad.Text + ";");
                swNuevo.Write(txtApertura.Text + ";");
                swNuevo.Write(txtNumExpediente.Text + ";");
                swNuevo.Write(txtJuzg.Text + ";");
                swNuevo.Write(txtJurisd.Text + ";");
                swNuevo.Write(txtDireccion.Text + ";");
                swNuevo.WriteLine(txtLiquidador.Text + ";");


                swNuevo.Close();
                swNuevo.Dispose();

                MessageBox.Show("Proveedor agregado");
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se econtro el archivo");
            }

        }

        // MODIFICAR
        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

            StreamWriter swModificar = new StreamWriter(archivoSeleccionado, true);

            dgrArchivos[0, posicion].Value = txtNumero.Text;
            dgrArchivos[1, posicion].Value = txtEntidad.Text;
            dgrArchivos[2, posicion].Value = txtApertura.Text;
            dgrArchivos[3, posicion].Value = txtNumExpediente.Text;
            dgrArchivos[4, posicion].Value = txtJuzg.Text;
            dgrArchivos[5, posicion].Value = txtJurisd.Text;
            dgrArchivos[6, posicion].Value = txtDireccion.Text;
            dgrArchivos[7, posicion].Value = txtLiquidador.Text;

            limpiar();
            txtNumero.Focus();

            swModificar.Close();
            swModificar.Dispose();
            GuardarCambiosEnCSV();
        }

        // BORRAR
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;

            StreamWriter swEliminar = new StreamWriter(archivoSeleccionado, true);

            dgrArchivos.Rows.RemoveAt(posicion);
            limpiar();
            txtNumero.Focus();

            swEliminar.Close();
            swEliminar.Dispose();
            GuardarCambiosEnCSV();
        }

        // LIMPIA LOS TEXTBOX
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // ACTUALIZAR .CSV
        private void GuardarCambiosEnCSV()
        {
            string archivoSeleccionado = treDirectorios.SelectedNode.FullPath;
            
            StreamWriter swGuardar = new StreamWriter(archivoSeleccionado);

            // ESCRIBIR LOS CAMPOS DE LAS COLUMNAS EN EL ARCHIVO
            for (int i = 0; i < dgrArchivos.Columns.Count; i++)
            {
                swGuardar.Write(dgrArchivos.Columns[i].HeaderText);
                if (i < dgrArchivos.Columns.Count - 1)
                {
                    swGuardar.Write(";");
                }
                else
                {
                    swGuardar.WriteLine(); // Agrega una línea en blanco al final de las cabeceras
                }
            }

            // ESCRIBIR LAS FILAS EN EL ARCHIVO
            foreach (DataGridViewRow row in dgrArchivos.Rows)
            {
                if (!row.IsNewRow) // NO ESCRIBE LINEA EN BLANCO NUEVA
                {
                    for (int i = 0; i < dgrArchivos.Columns.Count; i++)
                    {
                        swGuardar.Write(row.Cells[i].Value);
                        if (i < dgrArchivos.Columns.Count - 1)
                        {
                            swGuardar.Write(";");
                        }
                        else
                        {
                            swGuardar.WriteLine(); // AGREGA LINEA EN BLANCO DESPUES DE CADA FILA
                        }
                    }
                }
            }
            swGuardar.Close();
            swGuardar.Dispose();
        }

        // SELECCION EN GRILLA
        int posicion;
        private void dgrArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // INDICE DE LA COLUMNA
            posicion = dgrArchivos.CurrentRow.Index;

            // TRASLADO LOS DATOS DE LA GRILLA A LOS TEXTBOX
            txtNumero.Text = dgrArchivos[0, posicion].Value.ToString();
            txtEntidad.Text = dgrArchivos[1, posicion].Value.ToString();
            txtApertura.Text = dgrArchivos[2, posicion].Value.ToString();
            txtNumExpediente.Text = dgrArchivos[3, posicion].Value.ToString();
            txtJuzg.Text = dgrArchivos[4, posicion].Value.ToString();
            txtJurisd.Text = dgrArchivos[5, posicion].Value.ToString();
            txtDireccion.Text = dgrArchivos[6, posicion].Value.ToString();
            txtLiquidador.Text = dgrArchivos[7, posicion].Value.ToString();
        }
        void limpiar()
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
            dgrArchivos.ClearSelection();
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
                e.Handled = true;
            }
        }

        private void frmBuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }
    }
}
