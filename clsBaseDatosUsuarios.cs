using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace pryFernandezIES
{
    
    class clsBaseDatosUsuarios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=EL_CLUB.accdb";

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }
        }

        int varContador = 0;

        public void TraerDatos(string usuario , string contraseña)
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
                    if (varContador < 3)
                    {
                        if (lectorBD[1].ToString() == usuario && lectorBD[2].ToString() == contraseña)
                        {
                            frmCargaPrograma pasar = new frmCargaPrograma();
                            pasar.Show();

                            break;
                        }
                        else
                        {
                            varContador++;
                            MessageBox.Show("Hola");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Demasiados Intentos");
                        break;
                    }
                }
            }
        }
    }
}
