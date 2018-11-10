using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MantenimientoModelo;
using CapaDiseno;

namespace MantenimientoModelo
{
    public partial class ModelosLogistica : Form
    {
        Navegador nv = new Navegador();
        public ModelosLogistica()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelosLogistica_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_Modelo");
            dataGridView1.DataSource = tabla;
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           // new InterfazMantenimientoModelos(dataGridView1).Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazMantenimientoModelos(dataGridView1).Show();
        }
    }
}
