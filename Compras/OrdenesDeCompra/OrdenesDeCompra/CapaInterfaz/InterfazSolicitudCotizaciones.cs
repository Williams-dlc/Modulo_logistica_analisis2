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
    public partial class InterfazSolicitudCotizaciones : PlantillaForms.Plantilla
    {
        Navegador nv = new Navegador();                                                     // CREACION DE INSTANCIA DEL NAVEGADOR
        public InterfazSolicitudCotizaciones(DataGridView dg1)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dg1);
        }

        private void InterfazSolicitudCotizaciones_Load(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                                   // INTANCIA DE LA CAPA DE DATOS                                               
            nv.ingresarTabla("TBL_CotizacionEncabezado");                                                // CARGAR DATOS DE LA TABLA AL FORM
            Txt_CodigoProveedor.Text = "";
            Cbo_Proveedores.Text = "";

            /*NOTA IMPORTANTE. AUN NO ESTA IMPLEMENTADO LA SELECCION DE PROVEEDORES, POR ESO ESTA SECCION APARECE INHABILITADA EN EL FORM*/

            CapaDatosCompras cd2 = new CapaDatosCompras();                                       // INTANCIA A LA CAPA DE DATOS
            DataSet dt2 = cd2.cargarCBBX("TBL_Producto", "Descripcion_Producto");                 // CARGA DE COMBOBOX CON LOS NOMBRE DE LOS PRODUCTOS
            Cbb_productoD.DataSource = dt2.Tables[0].DefaultView;
            Cbb_productoD.ValueMember = "Descripcion_Producto";
            if (cd.existencias1(Txt_NOrden.Text, "PK_NumeroDeCotizacion", "TBL_CotizacionEncabezado") == 1)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_NOrden_TextChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                   // INSTANCIA DE LA CAPA DE DATOS
            if (Txt_NOrden.Text != "")                                                      // HABILITACION O DESHABILITACION DEL BOTON DE DETALLE SEGUN EL NUMERO DE ORDEN
            {
                DataSet ds;
                ds = cd.ConsultarDatos2(Txt_NOrden.Text);                                    // CARGA DEL DATAGRIDVIEW CON LOS DATOS DE LOS DEMAS DETALLES DE LA ORDEN
                Dgv_detalle.DataSource = ds.Tables[0];
                double suma = 0;
                foreach (DataGridViewRow row in Dgv_detalle.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        suma += Convert.ToDouble(row.Cells[4].Value);                       // SUMA DE SUBTOTALES PARA GENERAR EL TOTAL
                    }
                }

                this.Txt_total.Text = Convert.ToString(suma);                               // CARGA DEL TOTAL AL TEXTBOX
            }
            else
            {                                                 // DESHABILITACION DEL DETALLE
                DataTable dt = (DataTable)Dgv_detalle.DataSource;                           // VACIADO DEL DATAGRID
                dt.Clear();
                this.Txt_total.Text = "0";                                                  // TOTAL EN CERO
            }

            if (cd.existencias1(Txt_NOrden.Text, "PK_NumeroDeCotizacion", "TBL_CotizacionEncabezado") == 1)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void Cbb_productoD_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                                                                   // INSTANCIA A LA CAPA DE DATOS
            Txt_CodigoP.Text = cd.ExtraerCodigos(Cbb_productoD.Text, "PK_Codigo_Producto", "TBL_Producto", "Descripcion_Producto");         // EXTRACCION DEL CODIGO A TRAVES DEL NOMBRE
            string[] datos;
            datos = new string[3];
            datos = cd.cargarDatos1(Txt_CodigoP.Text);                                                                                      // CARGA DE DATOS DE PRODUCTOS, ESTO CON EL FIN DE SABER QUE PRODUCTO SE ESTA OPERANDO
            Txt_Precio.Text = datos[2];                                                                                                     // CARGA DE PRECIO


            DataSet ds;                                                                                                                     // CARGA DE DATAGRID CON OTROS DETALLES DE LA MISMA ORDEN
            ds = cd.ConsultarDatos2(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            int precio, cantidad;                                                                                                           // CALCULO DE SUBTOTAL
            if (Txt_Precio.Text != "" && Txt_Cantidad.Text != "")                                                                           // CONDICION PARA QUE CUANDO ALGUNO DE LOS DOS ESTE VACIO, EL SUBTOTAL NO SE PUEDA CALCULAR
            {
                precio = Convert.ToInt32(Txt_Precio.Text);
                cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                Txt_Subtotal.Text = Convert.ToString(precio * cantidad);                                                                      // CARGA DEL TEXTBOX DEL SUBTOTAL CON EL SUBTOTAL OBTENIDO DE CANTIDAD POR PRECIO
            }
        }

        public void clean()                                                                                                                 // FUNCION DE LIMPIAR
        {
            Txt_NDetalle.Text = "";
            Txt_Cantidad.Text = "";
            Cbb_productoD.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                                                                   // GUARDADO DE DATOS
            cd.InsertarDatosDetalle2(Txt_NDetalle.Text, Txt_Cantidad.Text, Txt_Subtotal.Text, Txt_NOrden.Text, Txt_CodigoP.Text);

            clean();                                                                                                                        // FUNCION DE LIMPIAR 

            DataSet ds;                                                                                                                     // CARGA DEL DATAGRID DE DETALES
            ds = cd.ConsultarDatos2(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];


            double suma = 0;
            foreach (DataGridViewRow row in Dgv_detalle.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    suma += Convert.ToDouble(row.Cells[4].Value);                       // SUMA DE SUBTOTALES PARA GENERAR EL TOTAL
                }
            }
            this.Txt_total.Text = Convert.ToString(suma);

            // GUARDADO DE DATOS
            cd.ActualizarTotal(Txt_total.Text, "PK_NumeroDeCotizacion", "TBL_CotizacionEncabezado", Txt_NOrden.Text);
        }

        private void Dgv_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_reference = "";                                                                                                       // FUNCION PARA ELIMINAR EL DETALLE, POR MEDIO DEL CODIGO DEL DETALLE Y EL DE EL NUMERO DE ORDEN, SE ELIMINA DANDO DOBLE CLICK EN EL REGISTRO QUE SE DESEA ELIMINAR
            string Id_reference2 = "";                                                                                                      // VARIABLES QUE GUARDAN EL ID
            if (Dgv_detalle.SelectedCells.Count > 0)                                                                                        // SELECCION DEL REGISTRO QUE SE DESEA ELIMINAR                           
            {
                int selectedrowindex = Dgv_detalle.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_detalle.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[0].Value);
                Id_reference2 = Convert.ToString(selectedRow.Cells[1].Value);
            }
            CapaDatosCompras cd = new CapaDatosCompras();                                                                                   // INSTANCIA A LA CAPA DE DATOS
            cd.EliminarDatosDetalle2(Id_reference, Id_reference2);                                                                            // LLAMADA A FUNCION DE ELIMINAR
            DataSet ds;
            ds = cd.ConsultarDatos2(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];


            double suma = 0;
            foreach (DataGridViewRow row in Dgv_detalle.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    suma += Convert.ToDouble(row.Cells[4].Value);                       // SUMA DE SUBTOTALES PARA GENERAR EL TOTAL
                }
            }
            this.Txt_total.Text = Convert.ToString(suma);

            // GUARDADO DE DATOS
            cd.ActualizarTotal(Txt_total.Text, "PK_NumeroOrden", "TBL_OrdenDeCompraEncabezado", Txt_NOrden.Text);               /// ACTUALIZAR LOS TOTALES DEL ENCABEZADO
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");                   //TOMAR LA FECHA DE UN DATE TIME Y PASARLO A UN TEXTBOX, ESTO PORQUE EL NAVEGADOR DA PROBLEMAS CON LOS DATETIMEPICKER
            Txt_fechaOrden.Text = fecha;
        }

        private void Txt_fechaOrden_TextChanged(object sender, EventArgs e)
        {
            if (Txt_fechaOrden.Text != "")
            {
                DateTime fecha = Convert.ToDateTime(Txt_fechaOrden.Text);                           //ASIGNACION DEL TEXTBOX A UN DATETIMEPICKER
                string fecha1 = fecha.ToString("yyyy/MM/dd");
                dateTimePicker1.Value = fecha;
            }
        }
    }
}
