using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryFernandezIES
{
    internal class clsBaseDatosLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter objDataAdap;
        OleDbDataReader lectorBD;
        DataSet objDataSet = new DataSet();

        public clsBaseDatosLogs()
        {
            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public string datosTabla;
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=EL_CLUB.accdb");
                conexionBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        public void TraerDatos(DataGridView grilla)
        {
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "LOGS";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Fecha", "Fecha");
            grilla.Columns.Add("Detalle", "Detalle");

            //leo como si fuera un archivo
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[3]);
                }
            }
        }

        public void Logs(string usuario, DateTime fecha, string accion)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;           
            comandoBD.CommandText = "LOGS";
            
            objDataAdap = new OleDbDataAdapter(comandoBD);           
            objDataAdap.Fill(objDataSet, "LOGS");
            
            DataTable dt = objDataSet.Tables["LOGS"];         
            DataRow dr = dt.NewRow();
           
            dr["Nombre"] = usuario;
            dr["Fecha"] = fecha;
            dr["Resultado"] = accion;

            dt.Rows.Add(dr);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);

            objDataAdap.Update(objDataSet, "LOGS");
            conexionBD.Close();
            conexionBD.Dispose();
        }
    }
}
