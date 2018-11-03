using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
namespace TrasladoProductos
{
    class CapaLogica_TrasladoProducto
    {
        OdbcConnection conectar = CapaDatos_TrasladoProductos.getDB();
        public DataSet plusDatos(int id,string tabla, string campo)
        {
            DataSet set = new DataSet();
            try
            {
                using (var cmd = conectar.CreateCommand())
                {
                    cmd.CommandText = "Select" + campo + "from" + tabla + "where" +id+"=" + id;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cmd);
                    set = new DataSet();
                    datos.Fill(set);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return set;
        }
    }
}
