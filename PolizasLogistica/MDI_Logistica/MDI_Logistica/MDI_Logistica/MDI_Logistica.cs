using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordenes_de_Compra;
using MantenimientoModelo;
using MantenimientoMateriaPrima;
using Bodega;
using MantenimientosLinea;
using MantenimientoSedes;
using CapaDeDiseñoPolizasLogistica;

namespace MDI_Logistica
{
    public partial class MDI_Logistica : Form
    {
        public MDI_Logistica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.panel1.Size = this.Size;
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            Btn_Cerrar.Location = new Point(this.Width - 41, 0);
            Btn_Minimizar.Location = new Point(this.Width - 82, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime fecha = DateTime.Now;
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
            timer1.Interval = 1000;
            timer1.Start();
            panel2.Location = new Point(20, this.Height - 175);
            panel3.Location = new Point(this.Width - 300, this.Height - 115);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:hh:mm:ss}", DateTime.Now);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            panel2.Location = new Point(50, this.Height - 220);
            panel3.Location = new Point(this.Width - 350, this.Height - 220);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //this.panel1.Size = this.Size;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Capa_Grafica_Solicitud_de_Compra frm = new Capa_Grafica_Solicitud_de_Compra();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void MDI_Logistica_MdiChildActivate(object sender, EventArgs e)
        {
        }

        private void mantenimientosModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelosLogistica frm = new ModelosLogistica();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void mantenimientosMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazConsultaMateriaPrima frm = new InterfazConsultaMateriaPrima();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void mantenimientosCanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcaLogistica frm = new MarcaLogistica();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void mantenimientosSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SedesLogistica frm = new SedesLogistica();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void generarPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Enviar frm = new Btn_Enviar();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }
    }
}
