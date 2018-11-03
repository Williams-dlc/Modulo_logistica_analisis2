using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace TrasladoProductos
{
    class CapaDatos_TrasladoProductos
    {
        static OdbcConnection cnx = null;

        public static OdbcConnection getDB()
        {
            cnx = new OdbcConnection(Properties.Settings.Default.ruta);
            cnx.Open();
            return cnx;
        }
    }
}
