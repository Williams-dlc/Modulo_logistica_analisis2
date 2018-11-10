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
    class CapaDatos_TrasladoProductos
    {
        public static OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);



        DataTable dato = new DataTable();

        /* public static OdbcConnection getDB()
         {
             cnx = new OdbcConnection(Properties.Settings.Default.ruta);
             cnx.Open();
             return cnx;
         }*/
        string ConnStr = "Driver={MySQL ODBC 5.3 Driver};Server=35.225.5.123;Database=Db_Colchoneria;uid=umg;pwd=umg";
        public static string sedes = "select * from TBL_Sede";
        public static string dirFinal = "select * from TBL_Destino";
        public static string placa = "select * from TBL_Vehiculos";
        public static string codProducto = "select * from TBL_Producto";
        public static string codEnvio = "select * from TBL_Envio_Encabezado";
        public static string Detalle = "select * from TBL_Detalle_Envio";
        public static string stock = "select FK_id_Sede, stock from TBL_DetalleInventarioBodega where stock>0";


        public static DataTable llenarCombobox()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(sedes, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarDirFinal()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(dirFinal, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPlaca()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(placa, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarCodProducto()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(codProducto, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarCodEnvio()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(codEnvio, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarDetalle()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(Detalle, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarstok()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(stock, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public void  verstock(int idproducto){
            OdbcConnection con = new OdbcConnection(ConnStr);
            con.Open();
            OdbcCommand cmd = new OdbcCommand("select FK_id_Sede, stock from TBL_DetalleInventarioBodega where FK_id_Sede='"+idproducto+"'", con);
            OdbcDataReader queryResults = cmd.ExecuteReader();
            while (queryResults.Read())
            {

            }
            con.Close();
        }

    }
}
