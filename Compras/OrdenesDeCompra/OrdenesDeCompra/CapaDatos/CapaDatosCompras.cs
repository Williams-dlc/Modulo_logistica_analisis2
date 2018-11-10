using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesDeCompra.CapaInterfaz;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace OrdenesDeCompra.CapaDatos
{
    class CapaDatosCompras
    {
        //  FUNCION QUE RETORNA UNA LISTA DE DATOS PARA CARGAR LOS COMBOBOX CON EL NOMBRE Y NO EL CODIGO (EJ. PROVEEDORES, PRODUTOS)
        public DataSet cargarCBBX(String tabla, String campoNombre)
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
                            cmd.CommandText = "SELECT " + campoNombre + " from " + tabla + " WHERE estatus = 0";
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

        /**/
        public int existencias1(string codigo, string pk, string table)
        {
            String datos;
            datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT "+pk+" FROM "+table+" WHERE estatus= 0 AND "+pk+" = " + codigo + ";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader[pk].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "ERROR");
            }

            if (datos == "")
            {
                return 0;
            }else
            {
                return 1;
            }
        }

        // FUNCION PARA EXTRAER EL CODIGO SEGUN EL NOMBRE
        public String ExtraerCodigos(String nombre, String Pk, String tabla, String nombreTabla)
        {
            string datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT " + Pk + " FROM " + tabla + " WHERE " + nombreTabla + " = '" + nombre + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader[Pk].ToString());
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

            //FUNCION PARA ACTUALIZAR LOS TOTALES CUANDO SE INGRESA UN NUEVO DETALLE
        public String ActualizarTotal(String valortotal, String Pk, String tabla, String pkvalue)
        {
            string datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE " + tabla + " SET `Total`= " + valortotal + " WHERE " + Pk + "= " + pkvalue + ";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
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

        // FUNCION PARA CARGAR LOS DATOS DE PRODUCTO, ESTO PARA SABER QUE PRODUCTO SE SELECCIONA CUANDO SE CREA EL DETALLE
        public string[] cargarDatos1(string codigo)
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
                            cmd.CommandText = "SELECT PK_Codigo_Producto, FK_GrupoProductos, FK_UnidadDeMedida, Precio FROM TBL_Producto WHERE estatus= 0 AND PK_Codigo_Producto = " + codigo + ";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["FK_GrupoProductos"].ToString());
                                datos[1] = (Reader["FK_UnidadDeMedida"].ToString());
                                datos[2] = (Reader["Precio"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "ERROR");
            }
            return datos;
        }

        // FUNCION QUE RETORNA LOS DATOS DEL DETALLE DE UN ENCABEZADO DE ORDEN DE COMPRA
        public DataSet ConsultarDatos(String codigo)
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
                            cmd.CommandText = "SELECT PK_Codigo_DetalleOrdenDeCompra as Codigo, FK_EncabezadoOrden as N_Orden, FK_Productos as Producto, Cantidad, Subtotal FROM TBL_OrdenDeCompraDetalle WHERE FK_EncabezadoOrden=" + codigo + ";";
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

        // FUNCION QUE RETORNA LOS DATOS DEL DETALLE DE UN ENCABEZADO DE ORDEN DE DEVOLUCION
        public DataSet ConsultarDatos1(String codigo)
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
                            cmd.CommandText = "SELECT PK_Codigo_DetalleOrdenDeDevolucion as Codigo, FK_EncabezadoOrden as N_Orden, FK_Producto as Producto, Cantidad, Subtotal FROM TBL_OrdenDeDevolucionDetalle WHERE FK_EncabezadoOrden=" + codigo + ";";
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

        // FUNCION QUE RETORNA LOS DATOS DEL DETALLE DE UN ENCABEZADO DE COTIZACION
        public DataSet ConsultarDatos2(String codigo)
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
                            cmd.CommandText = "SELECT PK_CotizacionOrden as Codigo, FK_CotizacionEncabezado as N_Orden, FK_Producto as Producto, Cantidad, Subtotal FROM TBL_CotizacionProveedores WHERE FK_CotizacionEncabezado=" + codigo + ";";
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

        // FUNCION PARA INSERTAR DATOS DEL DETALLE DE UNA ORDEN DE COMPRA
        public void InsertarDatosDetalle(string codigo, string cantidad, string subtotal, string encabezado, string productos)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO TBL_OrdenDeCompraDetalle (PK_Codigo_DetalleOrdenDeCompra, Cantidad, Subtotal, FK_EncabezadoOrden, FK_Productos) VALUES('" + codigo + "', '" + cantidad + "', '" + subtotal + "', '" + encabezado + "', '" + productos + "'); ";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
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

        // FUNCION PARA INSERTAR DATOS DEL DETALLE DE UNA ORDEN DE DEVOLUCION
        public void InsertarDatosDetalle1(string codigo, string cantidad, string subtotal, string encabezado, string productos)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO TBL_OrdenDeDevolucionDetalle (PK_Codigo_DetalleOrdenDeDevolucion, Cantidad, Subtotal, FK_EncabezadoOrden, FK_Producto) VALUES('" + codigo + "', '" + cantidad + "', '" + subtotal + "', '" + encabezado + "', '" + productos + "'); ";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
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


        // FUNCION PARA INSERTAR DATOS DEL DETALLE DE UNA COTIZACION
        public void InsertarDatosDetalle2(string codigo, string cantidad, string subtotal, string encabezado, string productos)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {

                            cmd.CommandText = "INSERT INTO TBL_CotizacionProveedores (PK_CotizacionOrden, Cantidad, Subtotal, FK_CotizacionEncabezado, FK_Producto) VALUES('" + codigo + "', '" + cantidad + "', '" + subtotal + "', '" + encabezado + "', '" + productos + "'); ";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
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

        // FUNCION PARA ELIMINAR DATOS DEL DETALLE DE UNA ORDEN DE COMPRA
        public void EliminarDatosDetalle(string codigoDetalle, string codigoOrden)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM TBL_OrdenDeCompraDetalle WHERE PK_Codigo_DetalleOrdenDeCompra = "+codigoDetalle+ " AND FK_EncabezadoOrden = "+codigoOrden+";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Eliminado");
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

        // FUNCION PARA ELIMINAR DATOS DEL DETALLE DE UNA ORDEN DE DEVOLUCION
        public void EliminarDatosDetalle1(string codigoDetalle, string codigoOrden)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM TBL_OrdenDeDevolucionDetalle WHERE PK_Codigo_DetalleOrdenDeDevolucion= " + codigoDetalle + " AND FK_EncabezadoOrden = " + codigoOrden + ";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Eliminado");
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


        // FUNCION PARA ELIMINAR DATOS DEL DETALLE DE UNA COTIZACION    
        public void EliminarDatosDetalle2(string codigoDetalle, string codigoOrden)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM TBL_CotizacionProveedores WHERE PK_CotizacionOrden= " + codigoDetalle + " AND FK_CotizacionEncabezado = " + codigoOrden + ";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Eliminado");
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
    }
}
