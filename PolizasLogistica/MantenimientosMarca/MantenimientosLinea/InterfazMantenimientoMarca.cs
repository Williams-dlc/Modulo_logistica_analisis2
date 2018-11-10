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
        Navegador nv2 = new Navegador();
        public InterfazMantenimientoMarca(DataGridView dataGridView1)
        {
           
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(dataGridView1);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InterfazMantenimientoLinea_Load(object sender, EventArgs e)
        {

            DataSet dt = nv2.cargarCombobox("TBL_Marca", "FK_Modelo");
            Cbo_Modelo.DataSource = dt.Tables[0].DefaultView;
            Cbo_Modelo.ValueMember = "FK_Modelo";
            nv2.ingresarTabla("TBL_Marca");

           // nv2.ingresarTabla("TBL_Marca");

            /* DataSet dt = nv.cargarCombobox("TBL_Marca", "FK_Modelo");
             comboBox1.DataSource = dt.Tables[0].DefaultView;
             comboBox1.ValueMember = "FK_Modelo";*/

           
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
