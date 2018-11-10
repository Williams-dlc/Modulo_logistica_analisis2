namespace TrasladoProductos
{
    partial class GenerarTraslado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarTraslado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_inicioTraslado = new System.Windows.Forms.TextBox();
            this.txt_codigoEnvio = new System.Windows.Forms.TextBox();
            this.lbl_CodigoEnvio = new System.Windows.Forms.Label();
            this.lbl_IdVehiculo = new System.Windows.Forms.Label();
            this.Lbl_DirFinal = new System.Windows.Forms.Label();
            this.lbl_FechaInicial = new System.Windows.Forms.Label();
            this.Lbl_DirInicial = new System.Windows.Forms.Label();
            this.Lbl_Destinatario = new System.Windows.Forms.Label();
            this.Txt_DirInicial = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.txt_codigoTraslado = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_TotalProductos = new System.Windows.Forms.TextBox();
            this.lbl_codigoTraslado = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_totalProductos = new System.Windows.Forms.Label();
            this.lbl_CodigoProducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_CodigoProducto = new System.Windows.Forms.ComboBox();
            this.cmb_CodigoEnvio = new System.Windows.Forms.ComboBox();
            this.cmb_sedeDestino = new System.Windows.Forms.ComboBox();
            this.cmb_direccionFinal = new System.Windows.Forms.ComboBox();
            this.cmb_Placa = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.dgv_mostrar = new System.Windows.Forms.DataGridView();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_SolicitudProducto = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.Existencia = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 45);
            this.panel1.TabIndex = 47;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(68, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(211, 18);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "5710_Traslado de productos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(843, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(886, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_inicioTraslado
            // 
            this.txt_inicioTraslado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicioTraslado.Location = new System.Drawing.Point(15, 247);
            this.txt_inicioTraslado.Name = "txt_inicioTraslado";
            this.txt_inicioTraslado.Size = new System.Drawing.Size(200, 26);
            this.txt_inicioTraslado.TabIndex = 125;
            this.txt_inicioTraslado.Tag = "2";
            // 
            // txt_codigoEnvio
            // 
            this.txt_codigoEnvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoEnvio.Location = new System.Drawing.Point(15, 194);
            this.txt_codigoEnvio.Name = "txt_codigoEnvio";
            this.txt_codigoEnvio.Size = new System.Drawing.Size(200, 26);
            this.txt_codigoEnvio.TabIndex = 121;
            this.txt_codigoEnvio.Tag = "1";
            this.txt_codigoEnvio.Text = " ";
            // 
            // lbl_CodigoEnvio
            // 
            this.lbl_CodigoEnvio.AutoSize = true;
            this.lbl_CodigoEnvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoEnvio.Location = new System.Drawing.Point(12, 173);
            this.lbl_CodigoEnvio.Name = "lbl_CodigoEnvio";
            this.lbl_CodigoEnvio.Size = new System.Drawing.Size(131, 18);
            this.lbl_CodigoEnvio.TabIndex = 120;
            this.lbl_CodigoEnvio.Text = "Codigo de Envio";
            // 
            // lbl_IdVehiculo
            // 
            this.lbl_IdVehiculo.AutoSize = true;
            this.lbl_IdVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdVehiculo.Location = new System.Drawing.Point(437, 221);
            this.lbl_IdVehiculo.Name = "lbl_IdVehiculo";
            this.lbl_IdVehiculo.Size = new System.Drawing.Size(121, 18);
            this.lbl_IdVehiculo.TabIndex = 119;
            this.lbl_IdVehiculo.Text = "Placa Vehiculo";
            // 
            // Lbl_DirFinal
            // 
            this.Lbl_DirFinal.AutoSize = true;
            this.Lbl_DirFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DirFinal.Location = new System.Drawing.Point(231, 277);
            this.Lbl_DirFinal.Name = "Lbl_DirFinal";
            this.Lbl_DirFinal.Size = new System.Drawing.Size(119, 18);
            this.Lbl_DirFinal.TabIndex = 118;
            this.Lbl_DirFinal.Text = "Direccion Final";
            // 
            // lbl_FechaInicial
            // 
            this.lbl_FechaInicial.AutoSize = true;
            this.lbl_FechaInicial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicial.Location = new System.Drawing.Point(12, 226);
            this.lbl_FechaInicial.Name = "lbl_FechaInicial";
            this.lbl_FechaInicial.Size = new System.Drawing.Size(214, 18);
            this.lbl_FechaInicial.TabIndex = 114;
            this.lbl_FechaInicial.Text = "Fecha de inicio del traslado";
            // 
            // Lbl_DirInicial
            // 
            this.Lbl_DirInicial.AutoSize = true;
            this.Lbl_DirInicial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DirInicial.Location = new System.Drawing.Point(231, 224);
            this.Lbl_DirInicial.Name = "Lbl_DirInicial";
            this.Lbl_DirInicial.Size = new System.Drawing.Size(130, 18);
            this.Lbl_DirInicial.TabIndex = 117;
            this.Lbl_DirInicial.Text = "Direccion Inicial";
            // 
            // Lbl_Destinatario
            // 
            this.Lbl_Destinatario.AutoSize = true;
            this.Lbl_Destinatario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Destinatario.Location = new System.Drawing.Point(12, 277);
            this.Lbl_Destinatario.Name = "Lbl_Destinatario";
            this.Lbl_Destinatario.Size = new System.Drawing.Size(205, 18);
            this.Lbl_Destinatario.TabIndex = 115;
            this.Lbl_Destinatario.Text = "Sede Destinatario (idSede)";
            // 
            // Txt_DirInicial
            // 
            this.Txt_DirInicial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DirInicial.Location = new System.Drawing.Point(234, 242);
            this.Txt_DirInicial.Name = "Txt_DirInicial";
            this.Txt_DirInicial.Size = new System.Drawing.Size(200, 26);
            this.Txt_DirInicial.TabIndex = 116;
            this.Txt_DirInicial.Tag = "3";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.Image")));
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ingresar.Location = new System.Drawing.Point(40, 65);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(61, 60);
            this.btn_ingresar.TabIndex = 126;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(690, 288);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(126, 41);
            this.btn_continuar.TabIndex = 127;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // txt_codigoTraslado
            // 
            this.txt_codigoTraslado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoTraslado.Location = new System.Drawing.Point(12, 394);
            this.txt_codigoTraslado.Name = "txt_codigoTraslado";
            this.txt_codigoTraslado.Size = new System.Drawing.Size(200, 26);
            this.txt_codigoTraslado.TabIndex = 128;
            this.txt_codigoTraslado.Tag = "4";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(234, 394);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(200, 26);
            this.txt_Descripcion.TabIndex = 129;
            this.txt_Descripcion.Tag = "4";
            // 
            // txt_TotalProductos
            // 
            this.txt_TotalProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalProductos.Location = new System.Drawing.Point(440, 394);
            this.txt_TotalProductos.Name = "txt_TotalProductos";
            this.txt_TotalProductos.Size = new System.Drawing.Size(200, 26);
            this.txt_TotalProductos.TabIndex = 130;
            this.txt_TotalProductos.Tag = "4";
            // 
            // lbl_codigoTraslado
            // 
            this.lbl_codigoTraslado.AutoSize = true;
            this.lbl_codigoTraslado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoTraslado.Location = new System.Drawing.Point(9, 373);
            this.lbl_codigoTraslado.Name = "lbl_codigoTraslado";
            this.lbl_codigoTraslado.Size = new System.Drawing.Size(151, 18);
            this.lbl_codigoTraslado.TabIndex = 133;
            this.lbl_codigoTraslado.Text = "Codigo de traslado";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(231, 373);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(191, 18);
            this.lbl_descripcion.TabIndex = 134;
            this.lbl_descripcion.Text = "Descripcion de Producto";
            // 
            // lbl_totalProductos
            // 
            this.lbl_totalProductos.AutoSize = true;
            this.lbl_totalProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalProductos.Location = new System.Drawing.Point(437, 373);
            this.lbl_totalProductos.Name = "lbl_totalProductos";
            this.lbl_totalProductos.Size = new System.Drawing.Size(138, 18);
            this.lbl_totalProductos.TabIndex = 135;
            this.lbl_totalProductos.Text = "Total de producto";
            // 
            // lbl_CodigoProducto
            // 
            this.lbl_CodigoProducto.AutoSize = true;
            this.lbl_CodigoProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoProducto.Location = new System.Drawing.Point(12, 429);
            this.lbl_CodigoProducto.Name = "lbl_CodigoProducto";
            this.lbl_CodigoProducto.Size = new System.Drawing.Size(158, 18);
            this.lbl_CodigoProducto.TabIndex = 136;
            this.lbl_CodigoProducto.Text = "Codigo de Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 137;
            this.label6.Text = "Codigo Envio";
            // 
            // cmb_CodigoProducto
            // 
            this.cmb_CodigoProducto.FormattingEnabled = true;
            this.cmb_CodigoProducto.Location = new System.Drawing.Point(15, 450);
            this.cmb_CodigoProducto.Name = "cmb_CodigoProducto";
            this.cmb_CodigoProducto.Size = new System.Drawing.Size(197, 21);
            this.cmb_CodigoProducto.TabIndex = 138;
            this.cmb_CodigoProducto.SelectedIndexChanged += new System.EventHandler(this.cmb_CodigoProducto_SelectedIndexChanged);
            // 
            // cmb_CodigoEnvio
            // 
            this.cmb_CodigoEnvio.FormattingEnabled = true;
            this.cmb_CodigoEnvio.Location = new System.Drawing.Point(234, 450);
            this.cmb_CodigoEnvio.Name = "cmb_CodigoEnvio";
            this.cmb_CodigoEnvio.Size = new System.Drawing.Size(200, 21);
            this.cmb_CodigoEnvio.TabIndex = 139;
            this.cmb_CodigoEnvio.SelectedIndexChanged += new System.EventHandler(this.cmb_CodigoEnvio_SelectedIndexChanged);
            // 
            // cmb_sedeDestino
            // 
            this.cmb_sedeDestino.FormattingEnabled = true;
            this.cmb_sedeDestino.Location = new System.Drawing.Point(15, 308);
            this.cmb_sedeDestino.Name = "cmb_sedeDestino";
            this.cmb_sedeDestino.Size = new System.Drawing.Size(197, 21);
            this.cmb_sedeDestino.TabIndex = 140;
            this.cmb_sedeDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmb_direccionFinal
            // 
            this.cmb_direccionFinal.FormattingEnabled = true;
            this.cmb_direccionFinal.Location = new System.Drawing.Point(234, 308);
            this.cmb_direccionFinal.Name = "cmb_direccionFinal";
            this.cmb_direccionFinal.Size = new System.Drawing.Size(197, 21);
            this.cmb_direccionFinal.TabIndex = 141;
            this.cmb_direccionFinal.SelectedIndexChanged += new System.EventHandler(this.cmb_direccionFinal_SelectedIndexChanged);
            // 
            // cmb_Placa
            // 
            this.cmb_Placa.FormattingEnabled = true;
            this.cmb_Placa.Location = new System.Drawing.Point(440, 242);
            this.cmb_Placa.Name = "cmb_Placa";
            this.cmb_Placa.Size = new System.Drawing.Size(197, 21);
            this.cmb_Placa.TabIndex = 142;
            this.cmb_Placa.SelectedIndexChanged += new System.EventHandler(this.cmb_Placa_SelectedIndexChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(161, 65);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(61, 60);
            this.btn_Guardar.TabIndex = 143;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(101, 65);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(61, 60);
            this.btn_editar.TabIndex = 144;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refrescar.Location = new System.Drawing.Point(467, 65);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(61, 60);
            this.btn_refrescar.TabIndex = 149;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgv_mostrar
            // 
            this.dgv_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar.Location = new System.Drawing.Point(15, 478);
            this.dgv_mostrar.Name = "dgv_mostrar";
            this.dgv_mostrar.Size = new System.Drawing.Size(906, 211);
            this.dgv_mostrar.TabIndex = 156;
            this.dgv_mostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_CellContentClick);
            this.dgv_mostrar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_CellContentDoubleClick);
            this.dgv_mostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_CellDoubleClick);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(690, 242);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(126, 41);
            this.btn_Actualizar.TabIndex = 160;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(690, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 161;
            this.button1.Text = "Bitacora";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_SolicitudProducto
            // 
            this.lbl_SolicitudProducto.AutoSize = true;
            this.lbl_SolicitudProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SolicitudProducto.Location = new System.Drawing.Point(12, 139);
            this.lbl_SolicitudProducto.Name = "lbl_SolicitudProducto";
            this.lbl_SolicitudProducto.Size = new System.Drawing.Size(134, 18);
            this.lbl_SolicitudProducto.TabIndex = 162;
            this.lbl_SolicitudProducto.Text = "Codigo Producto";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(161, 136);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(200, 26);
            this.txt_stock.TabIndex = 163;
            this.txt_stock.Tag = "1";
            // 
            // txt_existencia
            // 
            this.txt_existencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.Location = new System.Drawing.Point(676, 131);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(200, 26);
            this.txt_existencia.TabIndex = 164;
            this.txt_existencia.Tag = "1";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(390, 136);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(116, 26);
            this.btn_Aceptar.TabIndex = 165;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // Existencia
            // 
            this.Existencia.AutoSize = true;
            this.Existencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(517, 139);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(140, 18);
            this.Existencia.TabIndex = 166;
            this.Existencia.Text = "Producto en stock";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(39, 65);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 167;
            // 
            // GenerarTraslado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.lbl_SolicitudProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.dgv_mostrar);
            this.Controls.Add(this.cmb_Placa);
            this.Controls.Add(this.cmb_direccionFinal);
            this.Controls.Add(this.cmb_sedeDestino);
            this.Controls.Add(this.cmb_CodigoEnvio);
            this.Controls.Add(this.cmb_CodigoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_CodigoProducto);
            this.Controls.Add(this.lbl_totalProductos);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_codigoTraslado);
            this.Controls.Add(this.txt_TotalProductos);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_codigoTraslado);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.txt_inicioTraslado);
            this.Controls.Add(this.txt_codigoEnvio);
            this.Controls.Add(this.lbl_CodigoEnvio);
            this.Controls.Add(this.lbl_IdVehiculo);
            this.Controls.Add(this.Lbl_DirFinal);
            this.Controls.Add(this.lbl_FechaInicial);
            this.Controls.Add(this.Lbl_DirInicial);
            this.Controls.Add(this.Lbl_Destinatario);
            this.Controls.Add(this.Txt_DirInicial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarTraslado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarTraslado";
            this.Load += new System.EventHandler(this.GenerarTraslado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_inicioTraslado;
        private System.Windows.Forms.TextBox txt_codigoEnvio;
        private System.Windows.Forms.Label lbl_CodigoEnvio;
        private System.Windows.Forms.Label lbl_IdVehiculo;
        private System.Windows.Forms.Label Lbl_DirFinal;
        private System.Windows.Forms.Label lbl_FechaInicial;
        private System.Windows.Forms.Label Lbl_DirInicial;
        private System.Windows.Forms.Label Lbl_Destinatario;
        private System.Windows.Forms.TextBox Txt_DirInicial;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.TextBox txt_codigoTraslado;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_TotalProductos;
        private System.Windows.Forms.Label lbl_codigoTraslado;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_totalProductos;
        private System.Windows.Forms.Label lbl_CodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_CodigoProducto;
        private System.Windows.Forms.ComboBox cmb_CodigoEnvio;
        private System.Windows.Forms.ComboBox cmb_sedeDestino;
        private System.Windows.Forms.ComboBox cmb_direccionFinal;
        private System.Windows.Forms.ComboBox cmb_Placa;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView dgv_mostrar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_SolicitudProducto;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label Existencia;
        private CapaDiseno.Navegador navegador1;
    }
}