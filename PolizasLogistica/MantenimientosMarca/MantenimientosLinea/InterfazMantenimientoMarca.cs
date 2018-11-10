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
using MantenimientosLinea;

namespace MantenimientosLinea
{
    public partial class InterfazMantenimientoMarca : Form
    {
        Navegador nv = new Navegador();
        public InterfazMantenimientoMarca(DataGridView dataGridView1)
        {
           
            InitializeComponent();
            nv.dgv_datos(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InterfazMantenimientoLinea_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_Marca");

            DataSet dt = nv.cargarCombobox("TBL_Marca", "FK_Modelo");
            comboBox1.DataSource = dt.Tables[0].DefaultView;
            comboBox1.ValueMember = "FK_Modelo";
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
