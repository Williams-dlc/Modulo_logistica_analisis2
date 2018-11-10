using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDiseno;

namespace MNTPRODUCTO.Grafica
{
    public partial class mantenimientoProductos : Form
    {
        Navegador nv = new Navegador();
        int currentRow = 0;
        Data.dataLayer dt = new Data.dataLayer();
        string op = "";

        public mantenimientoProductos(DataGridView dgv, int mode)
        {
            InitializeComponent();
            cargarGrupo();
            cargarUnidadMedida();
            cargarTipo();
            cargarDatosProducto(dgv, mode);
        }



        void clear()
        {
            Txt_Cod_Producto.Text = "";
            Txt_Descripcion.Text = "";
            Txt_moneda.Text = "";
            Txt_Stock.Text = "";
            Txt_Precio.Text = "";
            Txt_Costo.Text = "";
            Cbo_Grupo_Producto.SelectedIndex = -1;
            Cbo_Tipo_Producto.SelectedIndex = -1;
            Cbo_Unidad_Medida.SelectedIndex = -1;
        }


        // GRUPO
        void cargarGrupo()
        {
            Cbo_Grupo_Producto.DisplayMember = "name";
            Cbo_Grupo_Producto.ValueMember = "name";
            Cbo_Grupo_Producto.DataSource = dt.getGrupo();
        }

        // UNIDAD DE MEDIDCA
        void cargarUnidadMedida()
        {
            Cbo_Unidad_Medida.DisplayMember = "name";
            Cbo_Unidad_Medida.ValueMember = "name";
            Cbo_Unidad_Medida.DataSource = dt.getUnidadMedida();
        }

        // TIPO
        void cargarTipo()
        {
            Cbo_Tipo_Producto.DisplayMember = "name";
            Cbo_Tipo_Producto.ValueMember = "name";
            Cbo_Tipo_Producto.DataSource = dt.getTipo();
        }





        //  Datos Documento
        private void cargarDatosProducto(DataGridView dvg, int mode)
        {

            if (mode == 1)
            {
                currentRow = dvg.CurrentCell.RowIndex;


                foreach (DataGridViewRow row in dvg.Rows)
                {

                    if (row.Index == currentRow)
                    {

                        Txt_Cod_Producto.Text = row.Cells[0].Value.ToString();
                        Txt_Descripcion.Text = row.Cells[5].Value.ToString();
                        Txt_moneda.Text = row.Cells[2].Value.ToString();
                        Txt_Stock.Text = row.Cells[6].Value.ToString();
                        Txt_Precio.Text = row.Cells[12].Value.ToString();
                        Txt_Costo.Text = row.Cells[13].Value.ToString();

                        Cbo_Grupo_Producto.SelectedIndex = dt.getIndexGrupo(Convert.ToInt32(row.Cells[1].Value.ToString()));
                       Cbo_Unidad_Medida.SelectedIndex = dt.getIndexMedida(Convert.ToInt32(row.Cells[3].Value.ToString()));
                       Cbo_Tipo_Producto.SelectedIndex = dt.getIndexTipo(Convert.ToInt32(row.Cells[4].Value.ToString()));
                        

                    }
                }
            }

        }



        private void mantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            op = "nuevo";

            Txt_Cod_Producto.Text = "";
            Txt_Descripcion.Text = "";
            Txt_moneda.Text = "";
            Txt_Stock.Text = "";
            Txt_Precio.Text = "";
            Txt_Costo.Text = "";
            Cbo_Grupo_Producto.SelectedIndex = -1;
            Cbo_Tipo_Producto.SelectedIndex = -1;
            Cbo_Unidad_Medida.SelectedIndex = -1;


            Txt_Cod_Producto.Text = Convert.ToString(dt.getNoSig());


            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_moneda.Enabled = true;
            Txt_Stock.Enabled = true;
            Txt_Precio.Enabled = true;
            Txt_Costo.Enabled = true;
            Cbo_Grupo_Producto.Enabled = true;
            Cbo_Tipo_Producto.Enabled = true;
            Cbo_Unidad_Medida.Enabled = true;
            Txt_Descripcion.Focus();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            op = "editar";
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Btn_Guardar.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_moneda.Enabled = true;
            Txt_Stock.Enabled = true;
            Txt_Precio.Enabled = true;
            Txt_Costo.Enabled = true;
            Cbo_Grupo_Producto.Enabled = true;
            Cbo_Tipo_Producto.Enabled = true;
            Cbo_Unidad_Medida.Enabled = true;
            Txt_Descripcion.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Btn_Cancelar.Enabled = false;
            Btn_Editar.Enabled = true;
            Btn_Guardar.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Txt_Descripcion.Enabled = false;
            Txt_moneda.Enabled = false;
            Txt_Stock.Enabled = false;
            Txt_Precio.Enabled = false;
            Txt_Costo.Enabled = false;
            Cbo_Grupo_Producto.Enabled = false;
            Cbo_Tipo_Producto.Enabled = false;
            Cbo_Unidad_Medida.Enabled = false;

            Txt_Cod_Producto.Text = "";
            Txt_Descripcion.Text = "";
            Txt_moneda.Text = "";
            Txt_Stock.Text = "";
            Txt_Precio.Text = "";
            Txt_Costo.Text = "";
            Cbo_Grupo_Producto.SelectedIndex = -1;
            Cbo_Tipo_Producto.SelectedIndex = -1;
            Cbo_Unidad_Medida.SelectedIndex = -1;

        }


  


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Guardar.Enabled = false;
            Txt_Descripcion.Enabled = false;
            Txt_moneda.Enabled = false;
            Txt_Stock.Enabled = false;
            Txt_Precio.Enabled = false;
            Txt_Costo.Enabled = false;
            Cbo_Grupo_Producto.Enabled = false;
            Cbo_Tipo_Producto.Enabled = false;
            Cbo_Unidad_Medida.Enabled = false;


            int cod = Convert.ToInt32(Txt_Cod_Producto.Text.ToString());
            string descripcion = Txt_Descripcion.Text.ToString();
            int unidadMedida = dt.getCodUMedida(Cbo_Unidad_Medida.Text.ToString());
            int grupo = dt.getCodGrupo(Cbo_Grupo_Producto.Text.ToString());
            int tipo = dt.getCodTipo(Cbo_Tipo_Producto.Text.ToString());
            int moneda = Convert.ToInt32(Txt_moneda.Text.ToString());
            int stock = Convert.ToInt32(Txt_Stock.Text.ToString());
            double precio = Convert.ToDouble(Txt_Precio.Text.ToString());
            double costo = Convert.ToDouble(Txt_Costo.Text.ToString());


            if (Equals(op, "editar"))
            {


                if (dt.actualizaProducto(cod, descripcion, unidadMedida, grupo, tipo, moneda, stock, precio, costo) == true)
                {
                    MessageBox.Show("Producto editado correctamente");
                    Btn_Cancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al editar producto!");
                }


            }



            if (Equals(op, "nuevo"))
            {

                if (dt.creaProducto(cod, descripcion, unidadMedida, grupo, tipo, moneda, stock, precio, costo) == true)
                {
                    MessageBox.Show("Producto guardado correctamente");
                    Btn_Cancelar.Enabled = false;
                    clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto!");
                    clear();
                }

            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            dataProductos dc = new dataProductos();
            dc.Show();
            this.Dispose();
        }
    }
}
