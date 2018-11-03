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
    public partial class RutaEncabezadoMantenimiento : Form
    {
        Navegador nv = new Navegador();

        public RutaEncabezadoMantenimiento(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void RutaEncabezadoMantenimiento_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_ruta_encabezado");

            DataSet dt = nv.cargarCombobox("tbl_vehiculos", "Marca");
            comboBox1.DataSource = dt.Tables[0].DefaultView;
            comboBox1.ValueMember = "Marca";

            DataSet dt2 = nv.cargarCombobox("tbl_envio", "Destino");
            comboBox2.DataSource = dt2.Tables[0].DefaultView;
            comboBox2.ValueMember = "Destino";

        }
    }
}
