using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloTransporte;
using ModuloTransporte.forms;

namespace TestTransporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RutaEncabezado rutaEncabezado = new RutaEncabezado();
            rutaEncabezado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RutaDetalle rutaDetalle = new RutaDetalle();
            rutaDetalle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Destino destino = new Destino();
            destino.Show();
        }
    }
}
