using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDiseno;
using OrdenesDeCompra.CapaDatos;

namespace OrdenesDeCompra.CapaInterfaz
{
    public partial class InterfazSolicitudOrdenesDeCompra : PlantillaForms.Plantilla
    {
        Navegador nv = new Navegador();
        public InterfazSolicitudOrdenesDeCompra(DataGridView dg1)
        {
            InitializeComponent();
            nv.dgv_datos(dg1);
        }

        private void InterfazSolicitudOrdenesDeCompra_Load(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            nv.ingresarTabla("TBL_OrdenDeCompraEncabezado");
            Txt_CodigoProveedor.Text = "";
            Cbo_Proveedores.Text = "";
            DataSet dt = cd.cargarCBBX("TBL_Provedor", "Nombre");
            Cbo_Proveedores.DataSource = dt.Tables[0].DefaultView;
            Cbo_Proveedores.ValueMember = "Nombre";
        }

        private void navegador1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String.Format("{0:yyyy-MM-dd}", Txt_FOrden.Text);
        }

        private void Txt_FEntrega_TextChanged(object sender, EventArgs e)
        {
            String.Format("{0:yyyy-MM-dd}", Txt_FEntrega.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterfazSeleccionDetalleOrdenDeCompra form = new InterfazSeleccionDetalleOrdenDeCompra();
            form.NOrden = Convert.ToInt32(Txt_NOrden.Text);
            form.Show();
        }

        private void Txt_NOrden_TextChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            if (Txt_NOrden.Text != "")
            {
                button1.Enabled = true;

                DataSet ds;
                ds = cd.ConsultarDatos(Txt_NOrden.Text);
                Dgv_detalle.DataSource = ds.Tables[0];
            }
            else
            {
                button1.Enabled = false;
                DataTable dt = (DataTable)Dgv_detalle.DataSource;
                dt.Clear();
            }

        }

        private void Cbo_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            Txt_CodigoProveedor.Text = cd.ExtraerCodigos(Cbo_Proveedores.Text, "PK_codProveedor", "TBL_Provedor", "Nombre");
        }

        private void Txt_CodigoProveedor_TextChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();
            Txt_CodigoProveedor.Text = cd.ExtraerCodigos(Cbo_Proveedores.Text, "PK_codProveedor", "TBL_Provedor", "Nombre");
        }

        private void Txt_Aprobacion_TextChanged(object sender, EventArgs e)
        {
            Txt_Aprobacion.Text = "0";
        }
    }
}
