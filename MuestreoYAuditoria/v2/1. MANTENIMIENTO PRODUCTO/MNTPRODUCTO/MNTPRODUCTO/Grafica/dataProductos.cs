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

namespace MNTPRODUCTO.Grafica
{
    public partial class dataProductos : Form
    {

        Navegador nv = new Navegador();
        
        public dataProductos()
        {
            InitializeComponent();
            cargarData();
            
        }

        void cargarData()
        {
            Dgv_Productos.DataSource = nv.cargarDatos("TBL_Producto");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataProductos_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void Dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mantenimientoProductos mnt = new mantenimientoProductos(Dgv_Productos, 1);
            mnt.Show();
            this.Hide();
        }
    }
}
