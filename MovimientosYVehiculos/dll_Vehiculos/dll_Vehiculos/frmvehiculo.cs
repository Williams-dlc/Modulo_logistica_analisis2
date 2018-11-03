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

namespace dll_Vehiculos
{
    public partial class frmvehiculo : Form
    {
        Navegador nv = new Navegador();
        private DataGridView dgv_vehiculos;

        public frmvehiculo()
        {
            InitializeComponent();
            nv.dgv_datos(dgv_vehiculos);
        }

        public frmvehiculo(DataGridView dgv_vehiculos)
        {
            this.dgv_vehiculos = dgv_vehiculos;
        }

        private void frmvehiculo_Load(object sender, EventArgs e)
        {
            //cargamos los combox de codigo de modelo
            DataSet dt = nv.cargarCombobox("TBL_Modelo", "PK_id_modelo");
            cmb_codmodelo.DataSource = dt.Tables[0].DefaultView;
            cmb_codmodelo.ValueMember = "PK_id_modelo";
            //cargamos los combox de modelo
            DataSet dt2 = nv.cargarCombobox("TBL_Modelo", "nombre");
            cmb_codmodelo.DataSource = dt2.Tables[0].DefaultView;
            cmb_codmodelo.ValueMember = "nombre";
   

            //se ingresa la informacion a la tabla
            nv.ingresarTabla("TBL_Vehiculos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
