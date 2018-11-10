namespace dll_movimientoinventario
{
    partial class frm_mov_inventario
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
            this.lbl_id_enc_doc = new System.Windows.Forms.Label();
            this.lbl_cod_producto = new System.Windows.Forms.Label();
            this.lbl_detalle_bodega = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_etado_detalle_doc = new System.Windows.Forms.Label();
            this.cmb_enc_doc = new System.Windows.Forms.ComboBox();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.cmb_bodega = new System.Windows.Forms.ComboBox();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_estado_detalle = new System.Windows.Forms.TextBox();
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
            this.panel2.TabIndex = 21;
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
            this.lbl_titulo.Size = new System.Drawing.Size(263, 19);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "5100 - Movimiento de inventarios";
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
            // lbl_id_enc_doc
            // 
            this.lbl_id_enc_doc.AutoSize = true;
            this.lbl_id_enc_doc.Location = new System.Drawing.Point(112, 213);
            this.lbl_id_enc_doc.Name = "lbl_id_enc_doc";
            this.lbl_id_enc_doc.Size = new System.Drawing.Size(140, 13);
            this.lbl_id_enc_doc.TabIndex = 0;
            this.lbl_id_enc_doc.Text = "Id_encabezado documento:";
            // 
            // lbl_cod_producto
            // 
            this.lbl_cod_producto.AutoSize = true;
            this.lbl_cod_producto.Location = new System.Drawing.Point(112, 240);
            this.lbl_cod_producto.Name = "lbl_cod_producto";
            this.lbl_cod_producto.Size = new System.Drawing.Size(88, 13);
            this.lbl_cod_producto.TabIndex = 1;
            this.lbl_cod_producto.Text = "Codigo producto:";
            // 
            // lbl_detalle_bodega
            // 
            this.lbl_detalle_bodega.AutoSize = true;
            this.lbl_detalle_bodega.Location = new System.Drawing.Point(112, 267);
            this.lbl_detalle_bodega.Name = "lbl_detalle_bodega";
            this.lbl_detalle_bodega.Size = new System.Drawing.Size(82, 13);
            this.lbl_detalle_bodega.TabIndex = 2;
            this.lbl_detalle_bodega.Text = "Detalle bodega:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(114, 294);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(114, 13);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Cantidad del producto:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(458, 213);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(113, 13);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio del producto Q:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(458, 240);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 13);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total Q:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(458, 267);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(48, 13);
            this.lbl_costo.TabIndex = 6;
            this.lbl_costo.Text = "Costo Q:";
            // 
            // lbl_etado_detalle_doc
            // 
            this.lbl_etado_detalle_doc.AutoSize = true;
            this.lbl_etado_detalle_doc.Location = new System.Drawing.Point(458, 294);
            this.lbl_etado_detalle_doc.Name = "lbl_etado_detalle_doc";
            this.lbl_etado_detalle_doc.Size = new System.Drawing.Size(43, 13);
            this.lbl_etado_detalle_doc.TabIndex = 7;
            this.lbl_etado_detalle_doc.Text = "Estado:";
            // 
            // cmb_enc_doc
            // 
            this.cmb_enc_doc.FormattingEnabled = true;
            this.cmb_enc_doc.Location = new System.Drawing.Point(270, 213);
            this.cmb_enc_doc.Name = "cmb_enc_doc";
            this.cmb_enc_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_enc_doc.TabIndex = 8;
            this.cmb_enc_doc.Tag = "1";
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(270, 240);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(121, 21);
            this.cmb_producto.TabIndex = 9;
            this.cmb_producto.Tag = "2";
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.FormattingEnabled = true;
            this.cmb_bodega.Location = new System.Drawing.Point(270, 267);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Size = new System.Drawing.Size(123, 21);
            this.cmb_bodega.TabIndex = 10;
            this.cmb_bodega.Tag = "3";
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(270, 294);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(123, 20);
            this.Txt_cantidad.TabIndex = 11;
            this.Txt_cantidad.Tag = "4";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(611, 213);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 12;
            this.txt_precio.Tag = "5";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(611, 239);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 13;
            this.txt_total.Tag = "6";
            this.txt_total.Leave += new System.EventHandler(this.txt_total_Leave);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(611, 267);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 20);
            this.txt_costo.TabIndex = 14;
            this.txt_costo.Tag = "7";
            // 
            // txt_estado_detalle
            // 
            this.txt_estado_detalle.Location = new System.Drawing.Point(611, 294);
            this.txt_estado_detalle.Name = "txt_estado_detalle";
            this.txt_estado_detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_estado_detalle.TabIndex = 15;
            this.txt_estado_detalle.Tag = "8";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(0, 32);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 22;
            // 
            // frm_mov_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_estado_detalle);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.cmb_enc_doc);
            this.Controls.Add(this.Txt_cantidad);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.cmb_bodega);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_id_enc_doc);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_cod_producto);
            this.Controls.Add(this.lbl_etado_detalle_doc);
            this.Controls.Add(this.lbl_detalle_bodega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mov_inventario";
            this.Text = "frm_mov_inventario";
            this.Load += new System.EventHandler(this.frm_mov_inventario_Load);
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
        private System.Windows.Forms.TextBox txt_estado_detalle;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.ComboBox cmb_bodega;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.ComboBox cmb_enc_doc;
        private System.Windows.Forms.Label lbl_etado_detalle_doc;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_detalle_bodega;
        private System.Windows.Forms.Label lbl_cod_producto;
        private System.Windows.Forms.Label lbl_id_enc_doc;
        private CapaDiseno.Navegador navegador1;
    }
}