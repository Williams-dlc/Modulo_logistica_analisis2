using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosPolizaLogistica;
using CapaLogicaPolizaLogistica;
using System.IO;
using BIT;

namespace CapaDeDiseñoPolizasLogistica
{
    public partial class FormGenerarPoliza : Form
    {
        public FormGenerarPoliza()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGenerarPoliza_Load(object sender, EventArgs e)
        {
            
            DataSet ds;
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            ds = dmu.DatosDetalle();
            Dgv_Poliza.DataSource = ds.Tables[0];
            
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_poliza_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardad
            LogicaPolizaLogistica lmu = new LogicaPolizaLogistica();
            lmu.ValidarInsertarDatosPoliza(Txt_id.Text, Dtp_fecha.Value.ToString("yyyyMMdd"), Txt_Tipo.Text);
            //Fin guardar
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //Mostrar datos en DataGrid
            DataSet ds;
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            ds = dmu.ConsultarDatos(Dtp_FechaInicio.Value.ToString("yyyyMMdd"), Dtp_FechaFin.Value.ToString("yyyyMMdd"));
            Dgv_Poliza.DataSource = ds.Tables[0];
        }
    }
}
