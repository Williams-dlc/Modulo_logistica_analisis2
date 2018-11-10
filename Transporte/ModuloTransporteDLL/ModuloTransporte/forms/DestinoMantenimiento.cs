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
    public partial class DestinoMantenimiento : Form
    {
        Navegador nv = new Navegador();
        public DestinoMantenimiento(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void DestinoMantenimiento_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_destino");
       
        }
    }
}
