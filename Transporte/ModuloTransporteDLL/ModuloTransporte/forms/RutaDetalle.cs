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
    public partial class RutaDetalle : Form
    {
        Navegador nv = new Navegador();

        public RutaDetalle()
        {
            InitializeComponent();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {

        }

        private void RutaDetalle_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_ruta_detalle");
            dgr.DataSource = tabla;
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new RutaDetalleMantenimiento(dgr).Show();
        }
    }
}
