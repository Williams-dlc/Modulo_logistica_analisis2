using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace dll_movimientoinventario
{
    public partial class frm_mov_inventario : Form
    {
        private DataGridView dgv_movimientos;
        Navegador nv = new Navegador();
        public frm_mov_inventario()
        {
            InitializeComponent();
            nv.dgv_datos(dgv_movimientos);
        }

        public frm_mov_inventario(DataGridView dgv_movimientos)
        {
            this.dgv_movimientos = dgv_movimientos;
        }

        private void frm_mov_inventario_Load(object sender, EventArgs e)
        {
           
 
            //cargamos combobox de id encabezado
            DataSet dt2 = nv.cargarCombobox("TBL_Enc_Doc_Inventario", "PK_Enc_Doc_Inventario");
            cmb_enc_doc.DataSource = dt2.Tables[0].DefaultView;
            cmb_enc_doc.ValueMember = "PK_Enc_Doc_Inventario";

            //cargamos combobox de codigo producto
            DataSet dt3 = nv.cargarCombobox("TBL_Producto", "PK_Codigo_Producto");
            cmb_producto.DataSource = dt3.Tables[0].DefaultView;
            cmb_producto.ValueMember = "PK_Codigo_Producto";

            //cargamos combobox de bodega
            DataSet dt4 = nv.cargarCombobox("TBL_DetalleInventarioBodega", "PK_DetalleInvetarioBodega");
            cmb_bodega.DataSource = dt4.Tables[0].DefaultView;
            cmb_bodega.ValueMember = "PK_DetalleInvetarioBodega";

            //insertamos las operaciones
            nv.ingresarTabla("TBL_Detalle_Doc_Invetario");
             }

        private void txt_total_Leave(object sender, EventArgs e)
        {
            int precio, cantidad, total;
            precio = Convert.ToInt32(txt_precio);
            cantidad = Convert.ToInt32(Txt_cantidad);
            total = precio * cantidad;
            txt_total.Text = total.ToString();
        }
    }
}
