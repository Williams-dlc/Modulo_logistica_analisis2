namespace MDI
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_close = new System.Windows.Forms.Button();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Lbl_nombreForm = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantemientoSedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeDevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPolizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestreoYAuditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionAProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelHora);
            this.panel2.Controls.Add(this.labelFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 101);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_usuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(880, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 101);
            this.panel3.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Usuario";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(87, 69);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(19, 20);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Moneda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(83, 40);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(19, 20);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "--";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(83, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(19, 20);
            this.labelFecha.TabIndex = 7;
            this.labelFecha.Text = "--";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel4.Controls.Add(this.Btn_close);
            this.panel4.Controls.Add(this.Btn_min);
            this.panel4.Controls.Add(this.Lbl_nombreForm);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1139, 41);
            this.panel4.TabIndex = 10;
            // 
            // Btn_close
            // 
            this.Btn_close.BackgroundImage = global::MDI.Properties.Resources.Cancelar;
            this.Btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_close.Location = new System.Drawing.Point(1082, -1);
            this.Btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(41, 41);
            this.Btn_close.TabIndex = 14;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Btn_min
            // 
            this.Btn_min.BackgroundImage = global::MDI.Properties.Resources.minimize;
            this.Btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_min.Location = new System.Drawing.Point(1037, -1);
            this.Btn_min.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(41, 41);
            this.Btn_min.TabIndex = 13;
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // Lbl_nombreForm
            // 
            this.Lbl_nombreForm.AutoSize = true;
            this.Lbl_nombreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreForm.Location = new System.Drawing.Point(50, 9);
            this.Lbl_nombreForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombreForm.Name = "Lbl_nombreForm";
            this.Lbl_nombreForm.Size = new System.Drawing.Size(126, 20);
            this.Lbl_nombreForm.TabIndex = 10;
            this.Lbl_nombreForm.Text = "5000 Logistica";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::MDI.Properties.Resources.transportadora;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(5, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 41);
            this.panel5.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.catalogosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoModeloToolStripMenuItem,
            this.mantenimientoMarcaToolStripMenuItem,
            this.mantemientoSedesToolStripMenuItem,
            this.mantenimientoRutasToolStripMenuItem,
            this.mantenimientoDestinosToolStripMenuItem,
            this.mantenimientoProductosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoModeloToolStripMenuItem
            // 
            this.mantenimientoModeloToolStripMenuItem.Name = "mantenimientoModeloToolStripMenuItem";
            this.mantenimientoModeloToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantenimientoModeloToolStripMenuItem.Text = "Mantenimiento Modelo";
            this.mantenimientoModeloToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoModeloToolStripMenuItem_Click);
            // 
            // mantenimientoMarcaToolStripMenuItem
            // 
            this.mantenimientoMarcaToolStripMenuItem.Name = "mantenimientoMarcaToolStripMenuItem";
            this.mantenimientoMarcaToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantenimientoMarcaToolStripMenuItem.Text = "Mantenimiento Marca";
            this.mantenimientoMarcaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoMarcaToolStripMenuItem_Click);
            // 
            // mantemientoSedesToolStripMenuItem
            // 
            this.mantemientoSedesToolStripMenuItem.Name = "mantemientoSedesToolStripMenuItem";
            this.mantemientoSedesToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantemientoSedesToolStripMenuItem.Text = "Mantemiento Sedes";
            this.mantemientoSedesToolStripMenuItem.Click += new System.EventHandler(this.mantemientoSedesToolStripMenuItem_Click);
            // 
            // mantenimientoRutasToolStripMenuItem
            // 
            this.mantenimientoRutasToolStripMenuItem.Name = "mantenimientoRutasToolStripMenuItem";
            this.mantenimientoRutasToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantenimientoRutasToolStripMenuItem.Text = "Mantenimiento Rutas";
            this.mantenimientoRutasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoRutasToolStripMenuItem_Click);
            // 
            // mantenimientoDestinosToolStripMenuItem
            // 
            this.mantenimientoDestinosToolStripMenuItem.Name = "mantenimientoDestinosToolStripMenuItem";
            this.mantenimientoDestinosToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantenimientoDestinosToolStripMenuItem.Text = "Mantenimiento Destinos";
            this.mantenimientoDestinosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDestinosToolStripMenuItem_Click);
            // 
            // mantenimientoProductosToolStripMenuItem
            // 
            this.mantenimientoProductosToolStripMenuItem.Name = "mantenimientoProductosToolStripMenuItem";
            this.mantenimientoProductosToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.mantenimientoProductosToolStripMenuItem.Text = "Mantenimiento Productos";
            this.mantenimientoProductosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProductosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeCompraToolStripMenuItem,
            this.generarPolizaToolStripMenuItem,
            this.trasladoDeProductosToolStripMenuItem,
            this.muestreoYAuditoriaToolStripMenuItem});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeCompraToolStripMenuItem1,
            this.ordenesDeDevolucionToolStripMenuItem,
            this.cotizacionAProveedoresToolStripMenuItem});
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.ordenesDeCompraToolStripMenuItem.Text = "Compras";
            // 
            // ordenesDeCompraToolStripMenuItem1
            // 
            this.ordenesDeCompraToolStripMenuItem1.Name = "ordenesDeCompraToolStripMenuItem1";
            this.ordenesDeCompraToolStripMenuItem1.Size = new System.Drawing.Size(257, 24);
            this.ordenesDeCompraToolStripMenuItem1.Text = "Ordenes de compra";
            this.ordenesDeCompraToolStripMenuItem1.Click += new System.EventHandler(this.ordenesDeCompraToolStripMenuItem1_Click);
            // 
            // ordenesDeDevolucionToolStripMenuItem
            // 
            this.ordenesDeDevolucionToolStripMenuItem.Name = "ordenesDeDevolucionToolStripMenuItem";
            this.ordenesDeDevolucionToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.ordenesDeDevolucionToolStripMenuItem.Text = "Ordenes de devolucion";
            this.ordenesDeDevolucionToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeDevolucionToolStripMenuItem_Click);
            // 
            // generarPolizaToolStripMenuItem
            // 
            this.generarPolizaToolStripMenuItem.Name = "generarPolizaToolStripMenuItem";
            this.generarPolizaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.generarPolizaToolStripMenuItem.Text = "Generar Poliza";
            this.generarPolizaToolStripMenuItem.Click += new System.EventHandler(this.generarPolizaToolStripMenuItem_Click);
            // 
            // trasladoDeProductosToolStripMenuItem
            // 
            this.trasladoDeProductosToolStripMenuItem.Name = "trasladoDeProductosToolStripMenuItem";
            this.trasladoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.trasladoDeProductosToolStripMenuItem.Text = "Traslado de Productos";
            this.trasladoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.trasladoDeProductosToolStripMenuItem_Click);
            // 
            // muestreoYAuditoriaToolStripMenuItem
            // 
            this.muestreoYAuditoriaToolStripMenuItem.Name = "muestreoYAuditoriaToolStripMenuItem";
            this.muestreoYAuditoriaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.muestreoYAuditoriaToolStripMenuItem.Text = "Muestreo y auditoria";
            this.muestreoYAuditoriaToolStripMenuItem.Click += new System.EventHandler(this.muestreoYAuditoriaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cotizacionAProveedoresToolStripMenuItem
            // 
            this.cotizacionAProveedoresToolStripMenuItem.Name = "cotizacionAProveedoresToolStripMenuItem";
            this.cotizacionAProveedoresToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.cotizacionAProveedoresToolStripMenuItem.Text = "Cotizacion a proveedores";
            this.cotizacionAProveedoresToolStripMenuItem.Click += new System.EventHandler(this.cotizacionAProveedoresToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1139, 713);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MDI";
            this.Text = "Menu Principal Seguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MDI_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label Lbl_nombreForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeDevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPolizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantemientoSedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestreoYAuditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionAProveedoresToolStripMenuItem;
    }
}

