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
    public partial class frm_operaciones : Form
    {
        Navegador nv = new Navegador();
        private DataGridView dgv_movimientos;

        public frm_operaciones()
        {
            InitializeComponent();
        }

        public frm_operaciones(DataGridView dgv_movimientos)
        {
            //metodo para referenciar el form que se esta utilizando, en este caso se utiliza this para referenciar al form actual
            nv.nombreForm(this);
            //metodo para cargar los datos de la fila seleccionada del datagrid a los textbox, se utiliza tag.
            nv.dgv_datos(dgv_movimientos); ;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_operaciones_Load(object sender, EventArgs e)
        {
            //cargamos los combox de operaciones
            DataSet dt = nv.cargarCombobox("TBL_Operaciones_Inv", "Tipo_Operacion_Inv");
            cmb_opc.DataSource = dt.Tables[0].DefaultView;
            cmb_opc.ValueMember = "Tipo_Operacion_Inv";

            //cargamos el combobox de codigo de proveedor
            DataSet dt2 = nv.cargarCombobox("TBL_Proveedor", "PK_codProveedor");
            cmb_proveedor.DataSource = dt2.Tables[0].DefaultView;
            cmb_opc.ValueMember = "PK_codProveedor";

            //cargamos el combobox de codigo de cliente
            DataSet dt3 = nv.cargarCombobox("", "PK_codCliente");
            cmb_cliente.DataSource = dt3.Tables[0].DefaultView;
            cmb_cliente.ValueMember = "PK_codCliente";

            //cargamos el combobox de codigo de catalogo de cuentas
           // DataSet dt4 = nv.cargarCombobox("tbl_catalogo_cuentas_contables", "id_cuenta");
            //cmb_cliente.DataSource = dt4.Tables[0].DefaultView;
            //cmb_cliente.ValueMember = "id_cuenta";
            //insertamos las operaciones
            nv.ingresarTabla("TBL_Enc_Doc_Inventario");

            //insertamos el encabezado de documento de inventario
            nv.otrasTablas("TBL_Operaciones_Inv", txt_idoperacion, txt_catalogo , txt_tipo_operacion, txt_idcuenta, txt_estado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_mov_inventario formmov = new frm_mov_inventario();
            formmov.Show();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
