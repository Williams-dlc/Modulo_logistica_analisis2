using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace MNTPRODUCTO.Data
{
    class dataLayer
    {


        //GUARDAR PRODUCTO
        public bool creaProducto(int cod_prod, string descripcion, int unidad_medida, int grupo, int tipo_prod, int moneda, int stock, double precio, double costo)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();
                    int valDef = 0;

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO TBL_Producto VALUES('" + cod_prod + "','" + grupo + "','" + moneda + "','" + unidad_medida + "','" + tipo_prod + "','" + descripcion + "','" + stock + "','" + valDef + "','" + valDef + "','" + valDef + "','" + valDef + "','" + valDef + "','" + precio + "','" + costo + "','" + valDef + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        //ACTUALIZAR PRODUCTO
        public bool actualizaProducto(int cod_prod, string descripcion, int unidad_medida, int grupo, int tipo_prod, int moneda, int stock, double precio, double costo)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();
               

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE TBL_Producto SET FK_GrupoProductos = '" + grupo + "', FK_Moneda = '" + moneda + "', FK_UnidadDeMedida = '" + unidad_medida + "', FK_Tipo_Producto = '" + tipo_prod + "', Descripcion_Producto = '" + descripcion + "', cargo_Producto = '" + stock + "' , Precio = '" + precio + "', 	costo = '" + costo + "' WHERE PK_Codigo_Producto = '"+ cod_prod +"'";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //OBTIENE CODIGO DE GRUPO
        public int getCodGrupo(string name)
        {
            OdbcDataReader dr = null;
            int cod = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Codigo_Grupo_de_Productos FROM TBL_grupo_de_productos WHERE Nombre_de_Grupo_de_Productos = '" + name + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_Codigo_Grupo_de_Productos"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;
            }
        }


        //OBTIENE EL NUMERO INDICE
        public int getIndexGrupo(int ID)
        {
            OdbcDataReader dr = null;
            int no = -1;
            int cont = -1;
            int value = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Codigo_Grupo_de_Productos FROM TBL_grupo_de_productos";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cont++;

                            no = Convert.ToInt32(dr["PK_Codigo_Grupo_de_Productos"].ToString());

                            if (no == ID)
                            {
                                value = cont;
                            }
                        }

                        dr.Close();
                        conn.Close();
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }




        //GET GRUPO
        public DataTable getGrupo()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_grupo_de_productos";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["Nombre_de_Grupo_de_Productos"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }




        //OBTIENE CODIGO DE MEDIDA
        public int getCodUMedida(string name)
        {
            OdbcDataReader dr = null;
            int cod = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_CodigoDeUnidadDeMedidaBase FROM TBL_unidaddemedidabase WHERE UnidadDeMedida = '" + name + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_CodigoDeUnidadDeMedidaBase"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;

            }
        }



        //OBTIENE EL NUMERO INDICE
        public int getIndexMedida(int ID)
        {
            OdbcDataReader dr = null;
            int no = -1;
            int cont = -1;
            int value = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_CodigoDeUnidadDeMedidaBase FROM TBL_unidaddemedidabase";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cont++;

                            no = Convert.ToInt32(dr["PK_CodigoDeUnidadDeMedidaBase"].ToString());

                            if (no == ID)
                            {
                                value = cont;
                            }
                        }

                        dr.Close();
                        conn.Close();
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }




        //GET UNIDAD MEDIDA
        public DataTable getUnidadMedida()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_unidaddemedidabase";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["UnidadDeMedida"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



        //OBTIENE CODIGO DE TIPO
        public int getCodTipo(string name)
        {
            OdbcDataReader dr = null;
            int cod = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Id_Tipo_Pro FROM TBL_tipo_producto WHERE Tipo_Producto = '" + name + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_Id_Tipo_Pro"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;

            }
        }




        //OBTIENE EL NUMERO INDICE
        public int getIndexTipo(int ID)
        {
            OdbcDataReader dr = null;
            int no = -1;
            int cont = -1;
            int value = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Id_Tipo_Pro FROM TBL_tipo_producto";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cont++;

                            no = Convert.ToInt32(dr["PK_Id_Tipo_Pro"].ToString());

                            if (no == ID)
                            {
                                value = cont;
                            }
                        }

                        dr.Close();
                        conn.Close();
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }



        //GET TIPO
        public DataTable getTipo()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_tipo_producto";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["Tipo_Producto"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



        //OBTIENE CODIGO DE MARCA
        public int getCodMarca(string name)
        {
            OdbcDataReader dr = null;
            int cod = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_id_Linea FROM TBL_marca WHERE Nombre = '" + name + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_id_Linea"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;

            }
        }




        //OBTIENE EL NUMERO INDICE
        public int getIndexMarca(int ID)
        {
            OdbcDataReader dr = null;
            int no = -1;
            int cont = -1;
            int value = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_id_Linea FROM TBL_marca";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cont++;

                            no = Convert.ToInt32(dr["PK_id_Linea"].ToString());

                            if (no == ID)
                            {
                                value = cont;
                            }
                        }

                        dr.Close();
                        conn.Close();
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }


        //GET MARCA
        public DataTable getMarca()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_marca";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["Nombre"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



        //OBTIENE EL NUMERO DE DOCUMENTO SIGUIENTE
        public int getNoSig()
        {
            OdbcDataReader dr = null;
            int no = -1;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Codigo_Producto FROM TBL_producto";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            no = Convert.ToInt32(dr["PK_Codigo_Producto"].ToString());
                        }

                        dr.Close();
                        conn.Close();

                        if (no == -1)
                        {
                            no = 0;
                        }
                        return no + 1;
                    }

                }
            }
            catch (Exception ex)
            {
                return no;
            }
        }







        //
    }
}
