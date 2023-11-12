using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Data;


namespace pryFernandezIES
{
    class clsBaseDatosCliente
    {
        //Objetos
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=EL_CLUB.accdb";

        public string estadoConexion = "";
        public string datosTabla;
        public void ConectarBD()
        {
            try 
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("CODIGO_SOCIO", "CODIGO_SOCIO");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Edad","Edad");
            grilla.Columns.Add("Sexo", "Sexo");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");
            grilla.Columns.Add("Atividad", "Actividad");
                      
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    string actividad = (bool)lectorBD["Actividad"] ? "Activo" : "Inactivo";

                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0],lectorBD[1],lectorBD[2],lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], actividad);
                }
            }
        }

        public void BuscarPorID(int codigo)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;  //q tipo de operacion quierp hacer y que me traiga TOD la tabla con el tabledirect
            comandoBD.CommandText = "CLIENTES"; //Que tabla traigo

            lectorBD = comandoBD.ExecuteReader(); //abre la tabla y muestra por renglon

            if (lectorBD.HasRows) //SI TIENE FILAS
            {
                bool Find = false; // bandera
                while (lectorBD.Read()) //mientras pueda leer, mostrar (leer)
                {
                    if (int.Parse(lectorBD[0].ToString()) == codigo)
                    {

                        //datosTabla += "-" + lectorBD[0]; //dato d la comlumna 0
                        MessageBox.Show("Cliente Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Find = true; // bandera
                        break;
                    }

                }
                if (Find == false)
                {
                    MessageBox.Show("NO Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void actividadCliente(int codigo)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            adaptadorBD.Fill(objDataSet,"CLIENTES");

            DataTable dt = objDataSet.Tables["CLIENTES"];

            foreach (DataRow dr in dt.Rows)
            {
                
                if ((int)dr["CODIGO_SOCIO"] == codigo)
                {
                    if ((bool)dr["ACTIVIDAD"] == false)
                    {                       
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = true;
                        dr.EndEdit();                     
                        break;
                    }
                    else if ((bool)dr["ACTIVIDAD"] == true)
                    {
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = false;
                        dr.EndEdit();
                        break;
                    }
                }                          
            }
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);
           
            adaptadorBD.Update(objDataSet, "CLIENTES");                     
        }
    }
}
