using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using BIT;
using System.Data;
namespace TrasladoProductos
{
    public partial class GenerarTraslado : Form
    {
        graphicLayer cpg = new graphicLayer();
        CapaDatos_TrasladoProductos conexion = new CapaDatos_TrasladoProductos();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.225.5.123;Database=Db_Colchoneria;uid=umg;pwd=umg";
        public GenerarTraslado()
        {
            InitializeComponent();
            txt_codigoTraslado.Enabled = false;
            txt_Descripcion.Enabled = false;
            txt_TotalProductos.Enabled = false;
            cmb_CodigoProducto.Enabled = false;
            cmb_CodigoEnvio.Enabled = false;
            txt_codigoEnvio.Enabled = false;
            Txt_DirInicial.Enabled = false;
            txt_inicioTraslado.Enabled = false;
            cmb_sedeDestino.Enabled = false;
            cmb_Placa.Enabled = false;
            cmb_direccionFinal.Enabled = false;
            btn_Aceptar.Enabled = false;
            txt_stock.Enabled = false;
            btn_Guardar.Enabled = false;

        }

        public void cargarData()
        {
            if (cmb_sedeDestino.SelectedIndex != 1)
            {
                dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCombobox();
            }
            else if (cmb_sedeDestino.SelectedIndex != 1)
            {
                dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
            }

            //dgv_mostrar.Rows.Add("Direccion");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCombobox();
        }

        private void GenerarTraslado_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = true;
            txt_stock.Enabled = true;
           /* OdbcConnection con = new OdbcConnection(ConnStr);
            con.Open();
            OdbcCommand cmd = new OdbcCommand("select FK_id_Sede, stock from TBL_DetalleInventarioBodega where FK_Codigo_Producto='" + txt_stock + "'", con);
            OdbcDataReader queryResults = cmd.ExecuteReader();
            while (queryResults.Read())
            {
                dgv_mostrar.DataSource = queryResults;
                
                cmb_CodigoProducto.Items.Clear();
            cmb_CodigoEnvio.Items.Clear();
            cmb_Placa.Items.Clear();
            btn_Actualizar.Enabled = false;
            txt_codigoEnvio.Enabled = true;
            Txt_DirInicial.Enabled = true;
            txt_inicioTraslado.Enabled = true;
            cmb_sedeDestino.Enabled = true;
            cmb_Placa.Enabled = true;
            cmb_direccionFinal.Enabled = true;
            btn_Actualizar.Enabled = false;
            cmb_sedeDestino.DataSource = CapaDatos_TrasladoProductos.llenarCombobox();
            cmb_sedeDestino.ValueMember = "PK_id_Sede";

            cmb_direccionFinal.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
            cmb_direccionFinal.ValueMember = "PK_correlativo_Destino";
            cmb_Placa.DataSource = CapaDatos_TrasladoProductos.llenarPlaca();
            cmb_Placa.ValueMember = "PK_id_Vehiculos";
                
                //cargarData();
                }*/
            }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigoEnvio.Text == "" || Txt_DirInicial.Text == "" || txt_inicioTraslado.Text == "" || cmb_sedeDestino.SelectedIndex == -1 || cmb_direccionFinal.SelectedIndex == -1 || cmb_Placa.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");
            }
            else
            {
                txt_codigoTraslado.Enabled = true;
                txt_Descripcion.Enabled = true;
                txt_TotalProductos.Enabled = true;
                cmb_CodigoProducto.Enabled = true;
                cmb_CodigoEnvio.Enabled = true;
                
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);
                    OdbcCommand cmd = new OdbcCommand("insert into TBL_Envio_Encabezado values ('" + txt_codigoEnvio.Text + "', '" + txt_inicioTraslado.Text + "', '" + Txt_DirInicial.Text + "', '" + cmb_sedeDestino.Text.ToString() + "', '" + cmb_direccionFinal.Text.ToString() + "', '" + cmb_Placa.Text.ToString() + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cmb_CodigoProducto.DataSource = CapaDatos_TrasladoProductos.llenarCodProducto();
                cmb_CodigoProducto.ValueMember = "PK_Codigo_Producto";
                cmb_CodigoEnvio.DataSource = CapaDatos_TrasladoProductos.llenarCodEnvio();
                cmb_CodigoEnvio.ValueMember = "PK_Codigo_Encabezado_Envio";

                this.btn_continuar.Enabled = false;
                btn_Guardar.Enabled = true;

            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bdcolchoneria;uid=willi;pwd=1234";
            if (txt_codigoTraslado.Text == "" || txt_Descripcion.Text == "" || txt_TotalProductos.Text == "" || cmb_CodigoProducto.SelectedIndex == -1 || cmb_CodigoEnvio.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);
                    OdbcCommand cmd = new OdbcCommand("insert into TBL_Detalle_Envio values ('" + txt_codigoTraslado.Text + "', '" + txt_Descripcion.Text + "', '" + txt_TotalProductos.Text + "', '" + cmb_CodigoProducto.Text.ToString() + "', '" + cmb_CodigoEnvio.Text.ToString() + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarDetalle();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cpg.Accion("Insertar", "5710_Traslado de Productos");                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            VisualizarTraslados ver = new VisualizarTraslados();
            ver.Show();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            btn_Actualizar.Enabled = true;
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);
                // OdbcCommand cmd = new OdbcCommand("update TBL_Envio_Encabezado set Fecha='" + txt_inicioTraslado.Text + "', Punto_origen='" + Txt_DirInicial.Text + "', FK_id_Sede= '" + cmb_sedeDestino.Text.ToString() + "', FK_correlativo_destino='" + cmb_direccionFinal.Text.ToString() + "', FK_id_Vehiculos = '" + cmb_Placa.Text.ToString() + "' where PK_Codigo_Encabezado_Envio= '" + txt_codigoEnvio.Text + "'", con);

                OdbcCommand cmd = new OdbcCommand("update TBL_Envio_Encabezado set Fecha='" + txt_inicioTraslado.Text + "', Punto_origen='" + Txt_DirInicial.Text + "', FK_id_Sede= '" + cmb_sedeDestino.Text.ToString() + "', FK_correlativo_destino='" + cmb_direccionFinal.Text.ToString() + "', FK_id_Vehiculos= '" + cmb_Placa.Text.ToString() + "' where PK_Codigo_Encabezado_Envio= '" + txt_codigoEnvio.Text + "'", con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCodEnvio();
        }

        private void cmb_direccionFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
        }

        private void cmb_Placa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarPlaca();
        }

        private void cmb_CodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCodProducto();
        }

        private void cmb_CodigoEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCodEnvio();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = true;
            txt_codigoEnvio.Enabled = true;
            Txt_DirInicial.Enabled = true;
            txt_inicioTraslado.Enabled = true;
            cmb_sedeDestino.Enabled = true;
            cmb_Placa.Enabled = true;
            cmb_direccionFinal.Enabled = true;
            dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarCodEnvio();
            btn_Actualizar.Enabled = true;
           /* cmb_sedeDestino.DataSource = CapaDatos_TrasladoProductos.llenarCombobox();
            cmb_sedeDestino.ValueMember = "PK_id_Sede";

            cmb_direccionFinal.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
            cmb_direccionFinal.ValueMember = "PK_correlativo_Destino";
            cmb_Placa.DataSource = CapaDatos_TrasladoProductos.llenarPlaca();
            cmb_Placa.ValueMember = "PK_id_Vehiculos";*/

            

        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceptar");
        }

        private void dgv_mostrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int bandera = 1;
            if (bandera == 1)
            {
                txt_existencia.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else
            {
                txt_inicioTraslado.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[1].Value.ToString());
                Txt_DirInicial.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmb_sedeDestino.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmb_direccionFinal.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[4].Value.ToString());
                cmb_Placa.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[5].Value.ToString());
                //txt_codigoEnvio.Enabled = false;

                this.btn_continuar.Enabled = false;
                //btn_Guardar.Enabled = true;
                //dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBitacora bitacora = new frmBitacora();
            bitacora.Show();
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();                                
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_id_Sede, stock from TBL_DetalleInventarioBodega where FK_Codigo_Producto='" + txt_stock.Text + "'", con);
                //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);
                
            }
            dgv_mostrar.DataSource = tabla;
            btn_Aceptar.Enabled = false;
            
        }

        private void dgv_mostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int bandera = 1;
            if (btn_Aceptar.Enabled==false)
            {
                txt_existencia.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_codigoEnvio.Enabled = true;
                Txt_DirInicial.Enabled = true;
                txt_inicioTraslado.Enabled = true;
                cmb_sedeDestino.Enabled = true;
                cmb_Placa.Enabled = true;
                cmb_direccionFinal.Enabled = true;
                btn_Actualizar.Enabled = false;
                cmb_sedeDestino.DataSource = CapaDatos_TrasladoProductos.llenarCombobox();
                cmb_sedeDestino.ValueMember = "PK_id_Sede";

                cmb_direccionFinal.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
                cmb_direccionFinal.ValueMember = "PK_correlativo_Destino";
                cmb_Placa.DataSource = CapaDatos_TrasladoProductos.llenarPlaca();
                cmb_Placa.ValueMember = "PK_id_Vehiculos";
            }
            else
            {
                txt_codigoEnvio.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_inicioTraslado.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[1].Value.ToString());
                Txt_DirInicial.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmb_sedeDestino.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmb_direccionFinal.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[4].Value.ToString());
                cmb_Placa.Text = Convert.ToString(dgv_mostrar.Rows[e.RowIndex].Cells[5].Value.ToString());
                //txt_codigoEnvio.Enabled = false;

                this.btn_continuar.Enabled = false;
                //btn_Guardar.Enabled = true;
                //dgv_mostrar.DataSource = CapaDatos_TrasladoProductos.llenarDirFinal();
            }
        }
    }
}
