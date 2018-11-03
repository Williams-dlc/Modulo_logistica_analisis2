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
    public partial class InterfazConsultaOrdenesDeCompra : PlantillaForms.Plantilla
    {
        Navegador nv = new Navegador();

        public InterfazConsultaOrdenesDeCompra()
        {
            InitializeComponent();
        }

        private void InterfazConsultaOrdenesDeCompra_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_OrdenDeCompraEncabezado");
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazSolicitudOrdenesDeCompra(dataGridView1).Show();
        }
    }
}
