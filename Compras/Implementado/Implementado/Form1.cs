using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdenesDeCompra.CapaInterfaz;

namespace Implementado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfazConsultaOrdenesDeCompra cgsc = new InterfazConsultaOrdenesDeCompra();
            cgsc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfazConsultaOrdenesDeDevolucion form = new InterfazConsultaOrdenesDeDevolucion();
            form.Show();
            //Capa_Grafica_Solicitar_Devolucion cgsc = new Capa_Grafica_Solicitar_Devolucion();
            //cgsc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Capa_Grafica_Solicitud_de_Compra cgsc = new Capa_Grafica_Solicitud_de_Compra();
            //cgsc.Show();
        }
    }
}
