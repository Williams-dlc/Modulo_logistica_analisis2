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


namespace dll_Vehiculos
{
    public partial class frmtablavehiculos : Form
    {
        Navegador nv = new Navegador();
        public frmtablavehiculos()
        {
            InitializeComponent();
        }

        private void frmtablavehiculos_Load(object sender, EventArgs e)
        {
            DataTable table = nv.cargarDatos("TBL_Vehiculos");
            dgv_vehiculos.DataSource = table;
        }

        private void dgv_vehiculos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_vehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_vehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_vehiculos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            new frmvehiculo(dgv_vehiculos).Show();
        }
    }
}
