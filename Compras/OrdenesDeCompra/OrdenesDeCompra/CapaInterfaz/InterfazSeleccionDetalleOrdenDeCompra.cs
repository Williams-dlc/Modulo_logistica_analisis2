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

        public int NOrden;                                                                      // VARIABLE PARA GUARDAR EL NUMERO DE ORDEN AL QUE SE LE AGREGA EL DETALLE

        private void InterfazSeleccionDetalleOrdenDeCompra_Load(object sender, EventArgs e)
        {
            Txt_NOrden.Text = Convert.ToString(NOrden);                                         // LLENADO DE UN TEXTBOX QUE CONTIENE EL NUMERO DE ENCABEZADO DE LA ORDEN
            CapaDatosCompras cd = new CapaDatosCompras();                                       // INTANCIA A LA CAPA DE DATOS
            DataSet dt = cd.cargarCBBX("TBL_Producto", "Descripcion_Producto");                 // CARGA DE COMBOBOX CON LOS NOMBRE DE LOS PRODUCTOS
            Cbb_productoD.DataSource = dt.Tables[0].DefaultView;                                
            Cbb_productoD.ValueMember = "Descripcion_Producto";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                                                                   // INSTANCIA A LA CAPA DE DATOS
            Txt_CodigoP.Text = cd.ExtraerCodigos(Cbb_productoD.Text, "PK_Codigo_Producto", "TBL_Producto", "Descripcion_Producto");         // EXTRACCION DEL CODIGO A TRAVES DEL NOMBRE
            string[] datos;                                                                                                                 
            datos = new string[3];                                                                                                          
            datos = cd.cargarDatos1(Txt_CodigoP.Text);                                                                                      // CARGA DE DATOS DE PRODUCTOS, ESTO CON EL FIN DE SABER QUE PRODUCTO SE ESTA OPERANDO
            Txt_Marca.Text = datos[0];                                                                                                      // CARGA DE MARCA
            //Txt_UnidadBase.Text = datos[1];                                                                                                 // CARGA DE UNIDAD DE MEDIDA
            Txt_Precio.Text = datos[2];                                                                                                     // CARGA DE PRECIO


            DataSet ds;                                                                                                                     // CARGA DE DATAGRID CON OTROS DETALLES DE LA MISMA ORDEN
            ds = cd.ConsultarDatos(Txt_NOrden.Text);                                                                                        
            Dgv_detalle.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            int precio, cantidad;                                                                                                           // CALCULO DE SUBTOTAL
            if (Txt_Precio.Text != "" && Txt_Cantidad.Text != "")                                                                           // CONDICION PARA QUE CUANDO ALGUNO DE LOS DOS ESTE VACIO, EL SUBTOTAL NO SE PUEDA CALCULAR
            {
                precio = Convert.ToInt32(Txt_Precio.Text);
                cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                Txt_Subtotal.Text = Convert.ToString(precio*cantidad);                                                                      // CARGA DEL TEXTBOX DEL SUBTOTAL CON EL SUBTOTAL OBTENIDO DE CANTIDAD POR PRECIO
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapaDatosCompras cd = new CapaDatosCompras();                                                                                   // GUARDADO DE DATOS
            cd.InsertarDatosDetalle(Txt_NDetalle.Text, Txt_Cantidad.Text, Txt_Subtotal.Text, Txt_NOrden.Text, Txt_CodigoP.Text);

            clean();                                                                                                                        // FUNCION DE LIMPIAR 

            DataSet ds;                                                                                                                     // CARGA DEL DATAGRID DE DETALES
            ds = cd.ConsultarDatos(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];
        }


        public void clean()                                                                                                                 // FUNCION DE LIMPIAR
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
            cd.EliminarDatosDetalle(Id_reference,Id_reference2);                                                                            // LLAMADA A FUNCION DE ELIMINAR
            DataSet ds;
            ds = cd.ConsultarDatos(Txt_NOrden.Text);
            Dgv_detalle.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
