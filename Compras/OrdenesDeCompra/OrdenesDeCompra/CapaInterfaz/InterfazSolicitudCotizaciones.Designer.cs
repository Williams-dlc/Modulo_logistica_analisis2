namespace OrdenesDeCompra.CapaInterfaz
{
    partial class InterfazSolicitudCotizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_fechaOrden = new System.Windows.Forms.TextBox();
            this.Txt_CodigoProveedor = new System.Windows.Forms.TextBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_NOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Solicitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cbo_Proveedores = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.Cbb_productoD = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_CodigoP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.Txt_NDetalle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Dgv_detalle = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.Text = "5506_Cotizaciones";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 648);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 17);
            this.label17.TabIndex = 100;
            this.label17.Text = "Fecha de la orden:";
            this.label17.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Nombre del proveedor:";
            // 
            // Txt_fechaOrden
            // 
            this.Txt_fechaOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechaOrden.Location = new System.Drawing.Point(41, 645);
            this.Txt_fechaOrden.Name = "Txt_fechaOrden";
            this.Txt_fechaOrden.Size = new System.Drawing.Size(194, 23);
            this.Txt_fechaOrden.TabIndex = 97;
            this.Txt_fechaOrden.Tag = "3";
            this.Txt_fechaOrden.Visible = false;
            this.Txt_fechaOrden.TextChanged += new System.EventHandler(this.Txt_fechaOrden_TextChanged);
            // 
            // Txt_CodigoProveedor
            // 
            this.Txt_CodigoProveedor.Enabled = false;
            this.Txt_CodigoProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoProveedor.Location = new System.Drawing.Point(254, 219);
            this.Txt_CodigoProveedor.Name = "Txt_CodigoProveedor";
            this.Txt_CodigoProveedor.ReadOnly = true;
            this.Txt_CodigoProveedor.Size = new System.Drawing.Size(195, 23);
            this.Txt_CodigoProveedor.TabIndex = 93;
            this.Txt_CodigoProveedor.Tag = "";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(682, 645);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.ReadOnly = true;
            this.Txt_total.Size = new System.Drawing.Size(150, 23);
            this.Txt_total.TabIndex = 91;
            this.Txt_total.Tag = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 90;
            this.label8.Text = "Total:";
            // 
            // Txt_NOrden
            // 
            this.Txt_NOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NOrden.Location = new System.Drawing.Point(254, 163);
            this.Txt_NOrden.Name = "Txt_NOrden";
            this.Txt_NOrden.Size = new System.Drawing.Size(578, 23);
            this.Txt_NOrden.TabIndex = 89;
            this.Txt_NOrden.Tag = "1";
            this.Txt_NOrden.TextChanged += new System.EventHandler(this.Txt_NOrden_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 88;
            this.label7.Text = "Numero de Cotizacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Fecha de la orden:";
            // 
            // Txt_Solicitante
            // 
            this.Txt_Solicitante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Solicitante.Location = new System.Drawing.Point(254, 191);
            this.Txt_Solicitante.Name = "Txt_Solicitante";
            this.Txt_Solicitante.Size = new System.Drawing.Size(578, 23);
            this.Txt_Solicitante.TabIndex = 83;
            this.Txt_Solicitante.Tag = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre del solicitante:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 80;
            this.label1.Text = "Cotizaciones";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cbo_Proveedores);
            this.panel3.Enabled = false;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(454, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 38);
            this.panel3.TabIndex = 94;
            // 
            // Cbo_Proveedores
            // 
            this.Cbo_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Proveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Proveedores.FormattingEnabled = true;
            this.Cbo_Proveedores.Location = new System.Drawing.Point(1, 7);
            this.Cbo_Proveedores.Name = "Cbo_Proveedores";
            this.Cbo_Proveedores.Size = new System.Drawing.Size(376, 25);
            this.Cbo_Proveedores.TabIndex = 50;
            this.Cbo_Proveedores.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.Txt_Precio);
            this.groupBox1.Controls.Add(this.Cbb_productoD);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_Cantidad);
            this.groupBox1.Controls.Add(this.Txt_CodigoP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Txt_Subtotal);
            this.groupBox1.Controls.Add(this.Txt_NDetalle);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 356);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btn_cancelar.BackgroundImage = global::OrdenesDeCompra.Properties.Resources.Cancel_32x32;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(794, 92);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(61, 60);
            this.btn_cancelar.TabIndex = 73;
            this.btn_cancelar.Text = "Limpiar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btn_guardar.BackgroundImage = global::OrdenesDeCompra.Properties.Resources.Save_32x32;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(794, 26);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 60);
            this.btn_guardar.TabIndex = 72;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Precio.Location = new System.Drawing.Point(203, 82);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.ReadOnly = true;
            this.Txt_Precio.Size = new System.Drawing.Size(245, 23);
            this.Txt_Precio.TabIndex = 71;
            this.Txt_Precio.Tag = "";
            // 
            // Cbb_productoD
            // 
            this.Cbb_productoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_productoD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_productoD.FormattingEnabled = true;
            this.Cbb_productoD.Location = new System.Drawing.Point(344, 53);
            this.Cbb_productoD.Name = "Cbb_productoD";
            this.Cbb_productoD.Size = new System.Drawing.Size(437, 25);
            this.Cbb_productoD.TabIndex = 69;
            this.Cbb_productoD.SelectedIndexChanged += new System.EventHandler(this.Cbb_productoD_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(145, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(470, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cantidad:";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(551, 82);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(230, 23);
            this.Txt_Cantidad.TabIndex = 62;
            this.Txt_Cantidad.Tag = "";
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            // 
            // Txt_CodigoP
            // 
            this.Txt_CodigoP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoP.Location = new System.Drawing.Point(203, 53);
            this.Txt_CodigoP.Name = "Txt_CodigoP";
            this.Txt_CodigoP.ReadOnly = true;
            this.Txt_CodigoP.Size = new System.Drawing.Size(135, 23);
            this.Txt_CodigoP.TabIndex = 68;
            this.Txt_CodigoP.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Subtotal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(125, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Producto:";
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subtotal.Location = new System.Drawing.Point(203, 111);
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.ReadOnly = true;
            this.Txt_Subtotal.Size = new System.Drawing.Size(578, 23);
            this.Txt_Subtotal.TabIndex = 64;
            this.Txt_Subtotal.Tag = "";
            // 
            // Txt_NDetalle
            // 
            this.Txt_NDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NDetalle.Location = new System.Drawing.Point(203, 26);
            this.Txt_NDetalle.Name = "Txt_NDetalle";
            this.Txt_NDetalle.Size = new System.Drawing.Size(578, 23);
            this.Txt_NDetalle.TabIndex = 66;
            this.Txt_NDetalle.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Numero de Detalle:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Dgv_detalle);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(176, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 182);
            this.panel4.TabIndex = 56;
            // 
            // Dgv_detalle
            // 
            this.Dgv_detalle.AllowDrop = true;
            this.Dgv_detalle.AllowUserToOrderColumns = true;
            this.Dgv_detalle.AllowUserToResizeColumns = false;
            this.Dgv_detalle.AllowUserToResizeRows = false;
            this.Dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle.EnableHeadersVisualStyles = false;
            this.Dgv_detalle.Location = new System.Drawing.Point(30, 3);
            this.Dgv_detalle.Name = "Dgv_detalle";
            this.Dgv_detalle.Size = new System.Drawing.Size(578, 176);
            this.Dgv_detalle.TabIndex = 46;
            this.Dgv_detalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_detalle_CellDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Location = new System.Drawing.Point(251, 248);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(615, 30);
            this.panel6.TabIndex = 96;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(580, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(25, 99);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 101;
            // 
            // InterfazSolicitudCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_fechaOrden);
            this.Controls.Add(this.Txt_CodigoProveedor);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_NOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Solicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Name = "InterfazSolicitudCotizaciones";
            this.Load += new System.EventHandler(this.InterfazSolicitudCotizaciones_Load);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Txt_Solicitante, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Txt_NOrden, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Txt_total, 0);
            this.Controls.SetChildIndex(this.Txt_CodigoProveedor, 0);
            this.Controls.SetChildIndex(this.Txt_fechaOrden, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.navegador1, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Txt_fechaOrden;
        public System.Windows.Forms.TextBox Txt_CodigoProveedor;
        public System.Windows.Forms.TextBox Txt_total;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Txt_NOrden;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Txt_Solicitante;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Cbo_Proveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.ComboBox Cbb_productoD;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Txt_Cantidad;
        public System.Windows.Forms.TextBox Txt_CodigoP;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox Txt_Subtotal;
        public System.Windows.Forms.TextBox Txt_NDetalle;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView Dgv_detalle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CapaDiseno.Navegador navegador1;
    }
}
