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

namespace MUESTREOAUDITORIA
{
    public partial class dataDocs : Form
    {
        Navegador nv = new Navegador();


        public dataDocs()
        {
            InitializeComponent();
        }




        private void Dgv_Data_Docs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new docAuditoria(Dgv_Data_Docs,1).Show();
            this.Hide();
        }

        private void dataDocs_Load(object sender, EventArgs e)
        {
            DataTable dt = nv.cargarDatos("TBL_Doc_Auditoria");
            Dgv_Data_Docs.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
