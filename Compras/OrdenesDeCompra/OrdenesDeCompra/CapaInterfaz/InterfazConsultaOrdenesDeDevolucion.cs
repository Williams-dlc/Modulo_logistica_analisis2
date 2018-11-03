using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrdenesDeCompra.CapaDatos;
using CapaDiseno;

namespace OrdenesDeCompra.CapaInterfaz
{
    public partial class InterfazConsultaOrdenesDeDevolucion : PlantillaForms.Plantilla
    {
        Navegador nv = new Navegador();
        public InterfazConsultaOrdenesDeDevolucion()
        {
            InitializeComponent();
        }

        private void InterfazConsultaDevoluciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_OrdenDeDevolucionEncabezado");
            Dgv_Devoluciones.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Dgv_Devoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new InterfazSolicitudDeDevoluciones(Dgv_Devoluciones).Show();
        }
    }
}
