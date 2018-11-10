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
using BIT;
namespace dll_Vehiculos
{
    public partial class frmvehiculo : Form
    {
        Navegador nv2 = new Navegador();
        private DataGridView dgv_vehiculos;

        public frmvehiculo()
        {
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(dgv_vehiculos);
        }

        public frmvehiculo(DataGridView dgv_vehiculos)
        {
            //metodo para referenciar el form que se esta utilizando, en este caso se utiliza this para referenciar al form actual
            nv2.nombreForm(this);
            //metodo para cargar los datos de la fila seleccionada del datagrid a los textbox, se utiliza tag.
            nv2.dgv_datos(dgv_vehiculos);
        }

        private void frmvehiculo_Load(object sender, EventArgs e)
        {
            //cargamos los combox de codigo de modelo
            DataSet dt = nv2.cargarCombobox("TBL_Modelo", "PK_id_modelo");
            cmb_codmodelo.DataSource = dt.Tables[0].DefaultView;
            cmb_codmodelo.ValueMember = "PK_id_modelo";
            //cargamos los combox de codigo de empleado
            DataSet dt2 = nv2.cargarCombobox("tbl_empleados", "ID_Empleado");
            cmb_codmodelo.DataSource = dt2.Tables[0].DefaultView;
            cmb_codmodelo.ValueMember = "ID_Empleado";
            //cargamos los combox de grupo de producto
            DataSet dt3 = nv2.cargarCombobox("TBL_Grupo_de_Producto", "PK_Codigo_Grupo_de_Productos");
            cmb_codmodelo.DataSource = dt2.Tables[0].DefaultView;
            cmb_codmodelo.ValueMember = "PK_Codigo_Grupo_de_Productos";


            //se ingresa la informacion a la tabla
            nv2.ingresarTabla("TBL_Vehiculos");
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
