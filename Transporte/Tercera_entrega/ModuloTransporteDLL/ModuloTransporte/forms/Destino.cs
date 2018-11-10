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
    public partial class Destino : Form
    {
        Navegador nv = new Navegador();
        public Destino()
        {
            InitializeComponent();
        }

        private void Destino_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_destino");
            dgr.DataSource = tabla;
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new DestinoMantenimiento(dgr).Show();
        }
    }
}
