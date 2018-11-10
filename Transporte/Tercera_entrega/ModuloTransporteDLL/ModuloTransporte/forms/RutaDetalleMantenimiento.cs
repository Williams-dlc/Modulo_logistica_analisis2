using CapaDiseno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloTransporte.forms
{
    public partial class RutaDetalleMantenimiento : Form
    {
        Navegador nv = new Navegador();
        public RutaDetalleMantenimiento(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void RutaDetalleMantenimiento_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_ruta_encabezado");

            DataSet dt = nv.cargarCombobox("tbl_ruta_encabezado", "descripcion_ruta");
            comboBox1.DataSource = dt.Tables[0].DefaultView;
            comboBox1.ValueMember = "descripcion_ruta";

            DataSet dt2 = nv.cargarCombobox("TBL_Destino", "direccion");
            comboBox2.DataSource = dt2.Tables[0].DefaultView;
            comboBox2.ValueMember = "direccion";
        }
    }
}
