﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryFernandezIES
{
    class clsBaseDatosUsuarios
    {
        OleDbConnection conexionBD;

        public void abrirBd()
        {
            try
            {
                conexionBD = new OleDbConnection();
            }
            catch (Exception)
            {
                
            }

        }
    }
}
