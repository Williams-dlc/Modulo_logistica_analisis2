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

namespace ModuloTransporte.forms
{
    public partial class RutaEncabezado : Form
    {

        Navegador nv = new Navegador();

        public RutaEncabezado()
        {
            InitializeComponent();
           
        }

        private void RutaEncabezado_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_ruta_encabezado");
            dgr.DataSource = tabla;
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new RutaEncabezadoMantenimiento(dgr).Show();
        }
    }
}
