using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logic;

namespace MUESTREOAUDITORIA
{
    public partial class MuestraAuditoria : Form
    {


        logicMA lg = new logicMA();

        int currentRow = 0;
        int no_Doc = 0;
        DataGridView referece;


        public MuestraAuditoria(DataGridView dvg)
        {
            InitializeComponent();
            CargarDetalleAudit(dvg);
            referece = dvg;
        }


        //DETALLE

        private void Detalle(int No_Doc)
        {
            Dgv_Detalle.DataSource = lg.getDetalleAudit(No_Doc);
            Txt_No_Doc.Text = Dgv_Detalle.Rows[0].Cells[0].Value.ToString();
            Txt_Cod_Prod.Text = Dgv_Detalle.Rows[0].Cells[1].Value.ToString();
            Txt_Cant_Logica.Text = Dgv_Detalle.Rows[0].Cells[2].Value.ToString();
            Txt_Cant_Fisica.Text = Dgv_Detalle.Rows[0].Cells[3].Value.ToString();
           
        }



        //  Datos Documento
        private void CargarDetalleAudit(DataGridView dvg)
        {

            currentRow = dvg.CurrentCell.RowIndex;


            foreach (DataGridViewRow row in dvg.Rows)
            {

                if (row.Index == currentRow)
                {
                    no_Doc = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Detalle(no_Doc);
                }


            }

        }

        private void MuestraAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            docAuditoria dc = new docAuditoria(referece,0);
            dc.Show();
            this.Dispose();
        }
    }
}
