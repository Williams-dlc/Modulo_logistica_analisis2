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
    public partial class GenerarReporteTraslado : Form
    {
        Navegador nv = new Navegador();
        CapaDatos_TrasladoProductos conexion = new CapaDatos_TrasladoProductos();
        public GenerarReporteTraslado(DataGridView dgv_Traslado)
        {
            InitializeComponent();
            nv.dgv_datos(dgv_Traslado);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void GenerarReporteTraslado_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("TBL_Envio_Encabezado");

            //nv.otrasTablas("TBL_Sede", txt_CodigoDetalle, txt_Descripcion, txt_totalProducto, txt_FKcodProd, txt_FKcondEnc);

            /*DataSet dt5 = nv.cargarCombobox("tbl_destino", "PK_correlativo_destino");
            comboBox1.DataSource = dt5.Tables[0].DefaultView;
            comboBox1.ValueMember = "PK_correlativo_destino";

            DataSet dt4 = nv.cargarCombobox("tbl_sede", "PK_id_Sede");
            cmb_Sede.DataSource = dt4.Tables[0].DefaultView;
            cmb_Sede.ValueMember = "PK_id_Sede";

            DataSet dt6 = nv.cargarCombobox("tbl_vehiculos", "PK_id_Vehiculos");
            cmb_Vehiculos.DataSource = dt6.Tables[0].DefaultView;
            cmb_Vehiculos.ValueMember = "PK_id_Vehiculos";*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
