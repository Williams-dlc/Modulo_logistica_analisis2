﻿namespace dll_movimientoinventario
{
    partial class frm_operaciones
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_idcuenta = new System.Windows.Forms.TextBox();
            this.txt_tipo_operacion = new System.Windows.Forms.TextBox();
            this.txt_idoperacion = new System.Windows.Forms.TextBox();
            this.lbl_estadoopc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estado_enc = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_id_enc = new System.Windows.Forms.TextBox();
            this.cmb_opc = new System.Windows.Forms.ComboBox();
            this.lbl_estado_enc = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_opc = new System.Windows.Forms.Label();
            this.lbl_id_enc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cod_proveedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_catalogo = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.Btn_Minimizar);
            this.panel2.Controls.Add(this.lbl_titulo);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 27);
            this.panel2.TabIndex = 22;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.BackgroundImage = global::dll_movimientoinventario.Properties.Resources.minimize;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(790, 0);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(27, 27);
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(33, 6);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(241, 19);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "5101 - Operaciones Inventario";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.btn_cerrar.BackgroundImage = global::dll_movimientoinventario.Properties.Resources.Cancelar;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(821, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(27, 27);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::dll_movimientoinventario.Properties.Resources.transportadora;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 27);
            this.panel1.TabIndex = 1;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(193, 260);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(121, 20);
            this.txt_estado.TabIndex = 29;
            // 
            // txt_idcuenta
            // 
            this.txt_idcuenta.Location = new System.Drawing.Point(193, 235);
            this.txt_idcuenta.Name = "txt_idcuenta";
            this.txt_idcuenta.Size = new System.Drawing.Size(121, 20);
            this.txt_idcuenta.TabIndex = 28;
            // 
            // txt_tipo_operacion
            // 
            this.txt_tipo_operacion.Location = new System.Drawing.Point(193, 209);
            this.txt_tipo_operacion.Name = "txt_tipo_operacion";
            this.txt_tipo_operacion.Size = new System.Drawing.Size(121, 20);
            this.txt_tipo_operacion.TabIndex = 27;
            // 
            // txt_idoperacion
            // 
            this.txt_idoperacion.Location = new System.Drawing.Point(193, 165);
            this.txt_idoperacion.Name = "txt_idoperacion";
            this.txt_idoperacion.Size = new System.Drawing.Size(121, 20);
            this.txt_idoperacion.TabIndex = 26;
            // 
            // lbl_estadoopc
            // 
            this.lbl_estadoopc.AutoSize = true;
            this.lbl_estadoopc.Location = new System.Drawing.Point(87, 263);
            this.lbl_estadoopc.Name = "lbl_estadoopc";
            this.lbl_estadoopc.Size = new System.Drawing.Size(43, 13);
            this.lbl_estadoopc.TabIndex = 25;
            this.lbl_estadoopc.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Id_cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de operacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id_ Operacion:";
            // 
            // txt_estado_enc
            // 
            this.txt_estado_enc.Location = new System.Drawing.Point(607, 301);
            this.txt_estado_enc.Name = "txt_estado_enc";
            this.txt_estado_enc.Size = new System.Drawing.Size(140, 20);
            this.txt_estado_enc.TabIndex = 41;
            this.txt_estado_enc.Tag = "4";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.CustomFormat = "YYYY-MM-DD";
            this.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Fecha.Location = new System.Drawing.Point(607, 275);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(140, 20);
            this.txt_Fecha.TabIndex = 40;
            this.txt_Fecha.Tag = "3";
            // 
            // txt_id_enc
            // 
            this.txt_id_enc.Location = new System.Drawing.Point(607, 168);
            this.txt_id_enc.Name = "txt_id_enc";
            this.txt_id_enc.Size = new System.Drawing.Size(140, 20);
            this.txt_id_enc.TabIndex = 39;
            this.txt_id_enc.Tag = "1";
            // 
            // cmb_opc
            // 
            this.cmb_opc.FormattingEnabled = true;
            this.cmb_opc.Location = new System.Drawing.Point(607, 194);
            this.cmb_opc.Name = "cmb_opc";
            this.cmb_opc.Size = new System.Drawing.Size(140, 21);
            this.cmb_opc.TabIndex = 38;
            this.cmb_opc.Tag = "1";
            // 
            // lbl_estado_enc
            // 
            this.lbl_estado_enc.AutoSize = true;
            this.lbl_estado_enc.Location = new System.Drawing.Point(445, 304);
            this.lbl_estado_enc.Name = "lbl_estado_enc";
            this.lbl_estado_enc.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado_enc.TabIndex = 37;
            this.lbl_estado_enc.Text = "Estado:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(445, 281);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 36;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_opc
            // 
            this.lbl_opc.AutoSize = true;
            this.lbl_opc.Location = new System.Drawing.Point(445, 197);
            this.lbl_opc.Name = "lbl_opc";
            this.lbl_opc.Size = new System.Drawing.Size(47, 13);
            this.lbl_opc.TabIndex = 35;
            this.lbl_opc.Text = "Opcion :";
            // 
            // lbl_id_enc
            // 
            this.lbl_id_enc.AutoSize = true;
            this.lbl_id_enc.Location = new System.Drawing.Point(445, 171);
            this.lbl_id_enc.Name = "lbl_id_enc";
            this.lbl_id_enc.Size = new System.Drawing.Size(134, 13);
            this.lbl_id_enc.TabIndex = 34;
            this.lbl_id_enc.Text = "Id encabezado documento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(399, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 60);
            this.button1.TabIndex = 42;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cod_proveedor
            // 
            this.lbl_cod_proveedor.AutoSize = true;
            this.lbl_cod_proveedor.Location = new System.Drawing.Point(445, 224);
            this.lbl_cod_proveedor.Name = "lbl_cod_proveedor";
            this.lbl_cod_proveedor.Size = new System.Drawing.Size(109, 13);
            this.lbl_cod_proveedor.TabIndex = 43;
            this.lbl_cod_proveedor.Text = "Codigo de proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Codigo de cliente";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(607, 221);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(140, 21);
            this.cmb_proveedor.TabIndex = 45;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(607, 248);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(140, 21);
            this.cmb_cliente.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Catalogo:";
            // 
            // txt_catalogo
            // 
            this.txt_catalogo.Location = new System.Drawing.Point(193, 187);
            this.txt_catalogo.Name = "txt_catalogo";
            this.txt_catalogo.Size = new System.Drawing.Size(121, 20);
            this.txt_catalogo.TabIndex = 49;
            this.txt_catalogo.Tag = "2";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(2, 32);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 50;
            // 
            // frm_operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_catalogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_idcuenta);
            this.Controls.Add(this.txt_tipo_operacion);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.txt_idoperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_estadoopc);
            this.Controls.Add(this.lbl_cod_proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_estado_enc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.txt_id_enc);
            this.Controls.Add(this.cmb_opc);
            this.Controls.Add(this.lbl_estado_enc);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_opc);
            this.Controls.Add(this.lbl_id_enc);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_operaciones";
            this.Text = "frm_operaciones";
            this.Load += new System.EventHandler(this.frm_operaciones_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_idcuenta;
        private System.Windows.Forms.TextBox txt_tipo_operacion;
        private System.Windows.Forms.TextBox txt_idoperacion;
        private System.Windows.Forms.Label lbl_estadoopc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_estado_enc;
        private System.Windows.Forms.DateTimePicker txt_Fecha;
        private System.Windows.Forms.TextBox txt_id_enc;
        private System.Windows.Forms.ComboBox cmb_opc;
        private System.Windows.Forms.Label lbl_estado_enc;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_opc;
        private System.Windows.Forms.Label lbl_id_enc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cod_proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_catalogo;
        private CapaDiseno.Navegador navegador1;
    }
}