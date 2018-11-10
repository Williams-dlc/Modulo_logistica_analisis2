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
        Navegador nv = new Navegador();                                                     // CREACION DE INSTANCIA DE LA CLASE DEL NAVEGADOR
        public InterfazConsultaOrdenesDeDevolucion()
        {
            InitializeComponent();
        }

        private void InterfazConsultaDevoluciones_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("TBL_OrdenDeDevolucionEncabezado");           // CARGA DE DATOS AL DATAGRID
            Dgv_Devoluciones.DataSource = table2;
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
            new InterfazSolicitudDeDevoluciones(Dgv_Devoluciones).Show();                   // CARGA DE DATOS DEL DATAGRID AL FORM
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
