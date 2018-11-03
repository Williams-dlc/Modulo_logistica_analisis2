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

namespace CapaDeDiseñoPolizasLogistica
{
    public partial class Btn_Enviar : Form
    {
        public Btn_Enviar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* DataSet ds;
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            ds = dmu.ConsultarDatosDePoliza();
            dataGridView1.DataSource = ds.Tables[0];*/
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
            lmu.ValidarInsertarDatosPoliza(Txt_id.Text, DTP_fecha.Value.ToString("yyyyMMdd"));
           // clean();
            //Fin guardar
        }
    }
}
