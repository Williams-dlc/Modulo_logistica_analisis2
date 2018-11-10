using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDiseno;

namespace OrdenesDeCompra.CapaInterfaz
{
    public partial class InterfazConsultaCotizaciones : PlantillaForms.Plantilla
    {
        Navegador nv = new Navegador();

        public InterfazConsultaCotizaciones()
        {
            InitializeComponent();
        }

        private void InterfazConsultaCotizaciones_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("TBL_CotizacionEncabezado");
            dataGridView1.DataSource = table2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazSolicitudCotizaciones(dataGridView1).Show();                 // CARGAR DATOS DEL DATAGRID AL FORM
        }
    }
}
