﻿using System;
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
using logic;

namespace MUESTREOAUDITORIA
{
    public partial class docAuditoria : Form
    {

        Navegador nv = new Navegador();
        logicMA lg = new logicMA();

        string op = "";
        int currentRow = 0;


        public docAuditoria(DataGridView dvg, int mode)
        {
            InitializeComponent();
            cargarBodega();
            CargarDatosDoc(dvg,mode);
            cargarDataAudit();
        }


        //Data Audit

        void cargarDataAudit()
        {
            Dgv_Doc_Muestra.DataSource = lg.getDatosAudit();
        }


        // Data Bodega
        void cargarBodega()
        {
            Cbo_Bodega.DisplayMember = "name";
            Cbo_Bodega.ValueMember = "name";
            Cbo_Bodega.DataSource = lg.getBodegas();
        }





        //  Datos Documento
        private void CargarDatosDoc(DataGridView dvg, int mode)
        {

            string no = "";

            if (mode == 1)
            {
                currentRow = dvg.CurrentCell.RowIndex;


                foreach (DataGridViewRow row in dvg.Rows)
                {

                    if (row.Index == currentRow)
                    {

                        no = row.Cells[0].Value.ToString();

                        if (Equals(no,""))
                        {

                        }else
                        {
                            Txt_No_doc_muestreo.Text = row.Cells[0].Value.ToString();
                            Cbo_Bodega.SelectedIndex = lg.getIndexBodega(Convert.ToInt32(row.Cells[1].Value.ToString()));
                            Dtp_fecha_muestreo.Text = row.Cells[2].Value.ToString();
                            Txt_descripcion_muestreo.Text = row.Cells[3].Value.ToString();

                        }

                        
                    }


                }
            }

        }


        private void docAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            op = "editar";
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Txt_descripcion_muestreo.Enabled = true;
            Dtp_fecha_muestreo.Enabled = false;
            Cbo_Bodega.Enabled = false;
        }




        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Guardar.Enabled = false;
            Txt_descripcion_muestreo.Enabled = false;
            Dtp_fecha_muestreo.Enabled = false;
            Cbo_Bodega.Enabled = false;

            string descripcion = Txt_descripcion_muestreo.Text.ToString();
            string fecha = Dtp_fecha_muestreo.Value.ToString("yyyy-MM-dd");
            int codBodega = lg.getCodBodega(Cbo_Bodega.Text.ToString());
            int No = Convert.ToInt32(Txt_No_doc_muestreo.Text.ToString());


            if (Equals(op,"editar"))
            {


                if (lg.actualizarDocAuditoria(No, codBodega ,fecha, descripcion) == true)
                {
                    MessageBox.Show("Documento editado correctamente");
                    Dgv_Doc_Muestra.DataSource = lg.getDatosAudit();
                    Btn_Cancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al editar documento de auditoria!");
                }


            }



            if (Equals(op, "nuevo"))
            {
                if (lg.getCodigoEncabezado(codBodega) == 0)
                {
                    MessageBox.Show("Error, No existen un inventario en la bodega seleccionada");

                    Txt_descripcion_muestreo.Text = "";
                    Txt_No_doc_muestreo.Text = "";
                    Cbo_Bodega.SelectedIndex = -1;

                    Txt_descripcion_muestreo.Enabled = false;
                    Txt_No_doc_muestreo.Enabled = false;
                    Cbo_Bodega.Enabled = false;

                    Btn_Nuevo.Enabled = true;
                    Btn_Cancelar.Enabled = false;
                    Btn_Editar.Enabled = true;
                    Btn_Guardar.Enabled = false;
                    


                    // SI EXISTE INVENTARIO EN BODEGA SE REALIZA
                }
                else
                {
                    if (lg.crearDocAuditoria(No, codBodega, fecha, descripcion) == true)
                    {
                        MessageBox.Show(codBodega.ToString());
                        Btn_Cancelar.Enabled = false;

                        //GENERACION DE COPIA DE INVENTARIO RESPECTO A LA BODEGA

                        if (lg.generarCopiaInventario(No) == true)
                        {
                            MessageBox.Show("Documento creado Exitosamente");
                            Dgv_Doc_Muestra.DataSource = lg.getDatosAudit();
                        }
                        else
                        {
                            MessageBox.Show("Error en copia de auditoria");
                        }




                    }
                    else
                    {
                        MessageBox.Show("Error al guardar documento de auditoria!");
                    }
                }

               

            }


        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
           dataDocs dc = new dataDocs();
            dc.Show();
            this.Dispose();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dgv_Doc_Muestra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new MuestraAuditoria(Dgv_Doc_Muestra).Show();
            this.Hide();
        }

        private void Dgv_Doc_Muestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {

            op = "nuevo";

            Txt_descripcion_muestreo.Text = "";
            Txt_No_doc_muestreo.Text = "";

            Txt_No_doc_muestreo.Text = Convert.ToString(lg.getNoDoc());
            Dtp_fecha_muestreo.Value = DateTime.Now.Date;

            Btn_Nuevo.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Txt_descripcion_muestreo.Enabled = true;
            Dtp_fecha_muestreo.Enabled = true;
            Cbo_Bodega.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaMuestreoAuditoria.chm");
        }
    }
}
