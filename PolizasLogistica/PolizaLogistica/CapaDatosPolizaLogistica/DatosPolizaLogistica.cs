using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;



namespace CapaDatosPolizaLogistica
{
    public class DatosPolizaLogistica
    {
        //Insertar datos en encabezado
        public void InsertarDatosDePoliza(string id, string fecha)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO TBL_encabezado_poliza(id_Poliza, Fecha_Actual_Poliza, Total_Poliza, estatus) VALUES('" + id + "','" + fecha + "',0,0)";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ingresado Exitosamente");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Datos del detalle
        public DataSet ConsultarDatosDePoliza()
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }

                        /*
                         SELECT Tipo_Operacion FROM TBL_operaciones_inventario 
UNION

ORDER BY ;
                         */
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }

        public string[] cargarDatos1(string usuario)
        {
            string[] datos;
            datos = new string[3];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "'" + usuario + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["usu_nickname"].ToString());
                                datos[1] = (Reader["usu_password"].ToString());
                                datos[2] = (Reader["usu_estado"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return datos;
        }
    }
}
