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
            this.dgv_movimientos = dgv_movimientos;
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




            //insertamos las operaciones
            nv.ingresarTabla("TBL_Enc_Doc_Inventario");

            //insertamos el encabezado de documento de inventario
            nv.otrasTablas("TBL_Operaciones_Inv", txt_idoperacion, txt_tipo_operacion, txt_idcuenta, txt_estado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_mov_inventario formmov = new frm_mov_inventario();
            formmov.Show();
        }
    }
}
