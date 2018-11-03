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
    public partial class frm_tabla_movimientos : Form
    {
        Navegador nv = new Navegador();
        public frm_tabla_movimientos()
        {
            InitializeComponent();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frm_operaciones(dgv_movimientos).Show();
        }

        private void frm_tabla_movimientos_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_Detalle_Doc_Invetario");
            dgv_movimientos.DataSource = tabla;
        }

        private void dgv_movimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
