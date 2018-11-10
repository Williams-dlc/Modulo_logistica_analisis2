using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioSesion;
using OrdenesDeCompra.CapaInterfaz;
using BITACORA;
using MantenimientoModelo;
using MantenimientosLinea;
using MantenimientoSedes;
using CapaDeDiseñoPolizasLogistica;
using TrasladoProductos;
using Ruta_Transporte.capaDiseno;
using Destino_Transporte.capaDiseno;
using MNTPRODUCTO;
using MUESTREOAUDITORIA;

namespace MDI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            DateTime fecha = DateTime.Now;
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
            timer1.Interval = 1000;
            timer1.Start();
            panel2.Location = new Point(20, this.Height - 175);
            panel3.Location = new Point(this.Width - 300, this.Height - 115);
            Btn_close.Location = new Point(this.Width - 41, 0);
            Btn_min.Location = new Point(this.Width - 82, 0);
            InicioSesionForm inicioSes = new InicioSesionForm();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();
        }


        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Usuario u = new Usuario();
            lbl_usuario.Text = u.obtenerUsuario();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:hh:mm:ss}", DateTime.Now);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void MDI_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ordenesDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.guardarCodigoApp("5511");
            InterfazConsultaOrdenesDeCompra frm = new InterfazConsultaOrdenesDeCompra();   // < ----Nombre del form
            frm.MdiParent = this;                                                          // < ----Asignacion de mdi padre
            frm.Show();                                                                    // < ----Mostrar el form
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void ordenesDeDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.guardarCodigoApp("5521");
            InterfazConsultaOrdenesDeDevolucion frm = new InterfazConsultaOrdenesDeDevolucion();   // < ----Nombre del form
            frm.MdiParent = this;                                                          // < ----Asignacion de mdi padre
            frm.Show();                                                                    // < ----Mostrar el form
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void mantenimientoModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelosLogistica frm = new ModelosLogistica();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void mantenimientoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcaLogistica frm = new MarcaLogistica();
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

        private void trasladoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarTraslados traslado = new VisualizarTraslados();
            traslado.MdiParent = this;
            traslado.Show();
            Application.DoEvents();
            traslado.Location = new Point((this.Width - traslado.Width) / 2, 0);
        }

        private void mantemientoSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SedesLogistica mant = new SedesLogistica();
            mant.MdiParent = this;
            mant.Show();
            Application.DoEvents();
            mant.Location = new Point((this.Width - mant.Width) / 2, 0);
        }

        private void mantenimientoDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.guardarCodigoApp("5201");
            ListadoDestino list = new ListadoDestino();
            list.MdiParent = this;
            list.Show();
            Application.DoEvents();
            list.Location = new Point((this.Width - list.Width) / 2, 0);
        }

        private void mantenimientoRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario();
            user.guardarCodigoApp("5202");
            ListadoRuta list = new ListadoRuta();
            list.MdiParent = this;
            list.Show();
            Application.DoEvents();
            list.Location = new Point((this.Width - list.Width) / 2, 0);
        }

        private void mantenimientoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MNTPRODUCTO.Grafica.dataProductos frm = new MNTPRODUCTO.Grafica.dataProductos();
            frm.MdiParent = this;                                                           
            frm.Show();                                                                     
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void muestreoYAuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataDocs frm = new dataDocs();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        private void cotizacionAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.guardarCodigoApp("5531");
            InterfazConsultaCotizaciones frm = new InterfazConsultaCotizaciones();   // < ----Nombre del form
            frm.MdiParent = this;                                                          // < ----Asignacion de mdi padre
            frm.Show();                                                                    // < ----Mostrar el form
            Application.DoEvents();
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);
        }

        /* EJEMPLO DE APERTURA DE UN FORM 
         * 
            Capa_Grafica_Solicitud_de_Compra frm = new Capa_Grafica_Solicitud_de_Compra();  <---- Nombre del form
            frm.MdiParent = this;                                                           <---- Asignacion de mdi padre
            frm.Show();                                                                     <---- Mostrar el form
            Application.DoEvents();                                                         
            frm.Location = new Point((this.Width - frm.Width) / 2, 0);                      <---- Centrado del form
         
         
         */
    }
}
