using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDiseno;
using CapaLogica;
using OrdenesDeCompra.CapaDatos;

namespace OrdenesDeCompra.CapaInterfaz
{
    public partial class InterfazSeleccionDetalleOrdenDeCompra : PlantillaForms.Plantilla
    {
        public InterfazSeleccionDetalleOrdenDeCompra()
        {
            InitializeComponent();
        }

        public int NOrden;

        private void InterfazSeleccionDetalleOrdenDeCompra_Load(object sender, EventArgs e)
        {
            Txt_NOrden.Text = Convert.ToString(NOrden);
            CapaDatosCompras cd = new CapaDatosCompras();
            DataSet dt = cd.cargarCBBX("TBL_Producto", "Descripcion_Producto");
            Cbb_productoD.DataSource = dt.Tables[0].DefaultView;
            Cbb_productoD.ValueMember = "Descripcion_Producto";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            Txt_CodigoP.Text = cd.ExtraerCodigos(Cbb_productoD.Text, "PK_Codigo_Producto", "TBL_Producto", "Descripcion_Producto");
            string[] datos;
            datos = new string[3];
            datos = cd.cargarDatos1(Txt_CodigoP.Text);
            Txt_Marca.Text = datos[0];
            Txt_UnidadBase.Text = datos[1];
            Txt_Precio.Text = datos[2];


            DataSet ds;
            ds = cd.ConsultarDatos(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            int precio, cantidad;
            if (Txt_Precio.Text != "" && Txt_Cantidad.Text != "")
            {
                precio = Convert.ToInt32(Txt_Precio.Text);
                cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                Txt_Subtotal.Text = Convert.ToString(precio*cantidad);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            cd.InsertarDatosDetalle(Txt_NDetalle.Text, Txt_Cantidad.Text, Txt_Subtotal.Text, Txt_NOrden.Text, Txt_CodigoP.Text);

            clean();

            DataSet ds;
            ds = cd.ConsultarDatos(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];
        }


        public void clean()
        {
            Txt_NDetalle.Text = "";
            Txt_Cantidad.Text = "";
            Cbb_productoD.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Dgv_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_reference = "";
            string Id_reference2 = "";
            if (Dgv_detalle.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_detalle.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_detalle.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[0].Value);
                Id_reference2 = Convert.ToString(selectedRow.Cells[1].Value);
            }
            CapaDatosCompras cd = new CapaDatosCompras();
            cd.EliminarDatosDetalle(Id_reference,Id_reference2);
            DataSet ds;
            ds = cd.ConsultarDatos(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];
        }
    }
}
