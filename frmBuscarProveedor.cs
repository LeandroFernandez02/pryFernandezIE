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
    public partial class frmBuscarProveedor : Form
    {
        public frmBuscarProveedor()
        {
            InitializeComponent();
            //LlenarTreDirectorios();
        }
        //SABER EXPLICAR TODO EL PROCESO 
        //PROCESO -> https://learn.microsoft.com/es-es/dotnet/desktop/winforms/controls/creating-an-explorer-style-interface-with-the-listview-and-treeview?view=netframeworkdesktop-4.8


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
                btnCargarArchivo.Text = "Volver a Seleccionar";

                string rutaArchivo = treDirectorios.SelectedNode.FullPath;
                string nombreArchivo = treDirectorios.SelectedNode.Name;

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
        
        
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            pnlCargarProveedor.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal volver = new frmPrincipal();
            volver.Show();
            this.Hide();
        }
    }
}
