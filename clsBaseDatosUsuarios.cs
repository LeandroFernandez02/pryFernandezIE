using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Data;

namespace pryFernandezIES
{ 
    class clsBaseDatosUsuarios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=EL_CLUB.accdb");
                conexionBD.Open();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }
        }
        public string datosTabla;

        int varContador = 0;
        int varEncontro = 0;

        public void TraerDatos(DataGridView grilla)
        {
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("Id", "Id");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Contraseña", "Contraseña");

            //leo como si fuera un archivo
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2]);
                }
            }
        }

        public void Login(string usuario, string contraseña,frmInicioSesion frmInicio)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            lectorBD = comandoBD.ExecuteReader();

            // Mientras haya registros
            if (lectorBD.HasRows)
            {
                // Leo todas los registros
                while (lectorBD.Read())
                {     
                    if (lectorBD[1].ToString() == usuario && lectorBD[2].ToString() == contraseña)
                    {
                        clsBaseDatosLogs objBaseDatosLogs;
                        objBaseDatosLogs = new clsBaseDatosLogs();                    

                        DateTime fechaHora = DateTime.Now;
                        string detalle = "Inicio de Sesion";
                        objBaseDatosLogs.Logs(usuario, fechaHora, detalle);

                        frmInicio.Hide();
                        frmCargaPrograma pasar = new frmCargaPrograma(usuario);
                        pasar.Show();
                        varEncontro++;

                        conexionBD.Close();
                        conexionBD.Dispose();

                        break;
                    }
                }
                if (varEncontro == 0)
                {
                    MessageBox.Show("Datos de inicio de sesion incorrectos");
                    varContador += 1;
                }
                if (varContador >= 3)
                {
                    MessageBox.Show("Demaciados intentos de inicio de sesion, el sistema se cerrara");
                    Application.Exit();
                }
            }
        }
    }
}

