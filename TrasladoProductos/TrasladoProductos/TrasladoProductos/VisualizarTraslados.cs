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

namespace TrasladoProductos
{
    public partial class VisualizarTraslados : Form
    {
        Navegador nv = new Navegador();
        public VisualizarTraslados()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualizarTraslados_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("TBL_Envio_Encabezado");
            dgv_Traslado.DataSource = tabla;
        }

        private void dgv_Traslado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //new GenerarTrasladoProductos(dgv_Traslado).Show();
        }

        private void btn_trasladar_Click(object sender, EventArgs e)
        {
            GenerarTraslado generar = new GenerarTraslado();
            generar.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAyuda_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/WILLI/Desktop/Traslado 2.0/Traslado de productos 2.0/Ayuda/AyudaTraslados.chm", "ayuda.html");
        }
    }
}
