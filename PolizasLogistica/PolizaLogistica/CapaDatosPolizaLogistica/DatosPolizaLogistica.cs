using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using CapaDeDiseñoPolizasLogistica;
using System.IO;


namespace CapaDatosPolizaLogistica
{
    public class DatosPolizaLogistica
    {
        //Insertar datos en encabezado
        public void InsertarDatosDePoliza(string id, string fecha, string tipo)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    //OdbcDataReader Reader;
                    conn.Open();

                    {

                        using (var cmd = conn.CreateCommand())
                        {
                            //Insertar datos a tabla TBL_encabezado_poliza

                            /*string total = ("SELECT SUM(Total) FROM TBL_Detalle_Doc_Inventario".ToString());
                            cmd.CommandText = "SELECT SUM(Total) FROM TBL_Detalle_Doc_Inventario".ToString();
                            double doble = Convert.ToDouble(total);
                            decimal valdec = Convert.ToDecimal(doble);*/
                            //cmd.CommandText = "INSERT INTO TBL_encabezado_poliza(id_Poliza, Fecha_Actual_Poliza, Total_Poliza, Tipo_Poliza, estatus) VALUES('" + id + "','" + fecha + "' , '"+ valdec + "' , '"+ tipo + "',0)";
                            cmd.CommandText = "INSERT INTO TBL_encabezado_poliza_Logistica(id_Poliza, Fecha_Actual_Poliza, Total_Poliza, Tipo_Poliza, estatus) VALUES('" + id + "','" + fecha + "',0,'" + tipo + "',0)";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Encabezado de poliza creado exitosamente");

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
        public DataSet ConsultarDatos(string inicio, string fin)
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
                            cmd.CommandText = "SELECT * FROM TBL_Enc_Doc_Inventario WHERE fecha  between '" + inicio + "' and FECHA  <=  '" + fin + "' UNION SELECT ";
                            //cmd.CommandText =
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            //Dgv_Poliza.DataSource = ds.Tables[0];
                            /*
           cmd.CommandText = "SELECT * FROM TBL_Enc_Doc_Inventario WHERE FECHA >= '" & DateTimePicker1.Value.ToString("yyyyMMdd") & "' and FECHA  <=  '" & DateTimePicker2.Value.ToString("yyyyMMdd") & "'";
                               
                         */
                        }
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


        public DataSet DatosDetalle()
        {
            //Mostrar datos de detalle
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT Id_Detalle_Poliza as ID_Detalle, Nombre_Cuenta_DP as Nombre_De_Cuenta, Cargo_detalle_poliza as Cargo, Abono_detalle_poliza as Abono, id_poliza as Numero_Poliza FROM TBL_detalle_poliza_Logistica";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
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

    }
}
