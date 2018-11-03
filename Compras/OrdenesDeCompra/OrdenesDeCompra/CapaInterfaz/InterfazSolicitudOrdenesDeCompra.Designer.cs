namespace OrdenesDeCompra.CapaInterfaz
{
    partial class InterfazSolicitudOrdenesDeCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_NOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Solicitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Aprobacion = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_detalle = new System.Windows.Forms.DataGridView();
            this.Txt_CodigoProveedor = new System.Windows.Forms.TextBox();
            this.Cbo_Proveedores = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_FOrden = new System.Windows.Forms.TextBox();
            this.Txt_FEntrega = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(687, 658);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(150, 23);
            this.Txt_total.TabIndex = 38;
            this.Txt_total.Tag = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(638, 661);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total:";
            // 
            // Txt_NOrden
            // 
            this.Txt_NOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NOrden.Location = new System.Drawing.Point(259, 217);
            this.Txt_NOrden.Name = "Txt_NOrden";
            this.Txt_NOrden.Size = new System.Drawing.Size(578, 27);
            this.Txt_NOrden.TabIndex = 35;
            this.Txt_NOrden.Tag = "1";
            this.Txt_NOrden.TextChanged += new System.EventHandler(this.Txt_NOrden_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Numero de Orden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Aprobacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha de la entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de la orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre del proveedor:";
            // 
            // Txt_Solicitante
            // 
            this.Txt_Solicitante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Solicitante.Location = new System.Drawing.Point(259, 250);
            this.Txt_Solicitante.Name = "Txt_Solicitante";
            this.Txt_Solicitante.Size = new System.Drawing.Size(578, 27);
            this.Txt_Solicitante.TabIndex = 25;
            this.Txt_Solicitante.Tag = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre del solicitante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Solicitud de Orden de Compra";
            // 
            // Txt_Aprobacion
            // 
            this.Txt_Aprobacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Aprobacion.Location = new System.Drawing.Point(259, 346);
            this.Txt_Aprobacion.Name = "Txt_Aprobacion";
            this.Txt_Aprobacion.ReadOnly = true;
            this.Txt_Aprobacion.Size = new System.Drawing.Size(578, 27);
            this.Txt_Aprobacion.TabIndex = 43;
            this.Txt_Aprobacion.Tag = "6";
            this.Txt_Aprobacion.Text = "0";
            this.Txt_Aprobacion.TextChanged += new System.EventHandler(this.Txt_Aprobacion_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(36, 141);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 45;
            this.navegador1.MouseHover += new System.EventHandler(this.navegador1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(30, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 23;
            // 
            // Dgv_detalle
            // 
            this.Dgv_detalle.AllowDrop = true;
            this.Dgv_detalle.AllowUserToOrderColumns = true;
            this.Dgv_detalle.AllowUserToResizeColumns = false;
            this.Dgv_detalle.AllowUserToResizeRows = false;
            this.Dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle.EnableHeadersVisualStyles = false;
            this.Dgv_detalle.Location = new System.Drawing.Point(29, 6);
            this.Dgv_detalle.Name = "Dgv_detalle";
            this.Dgv_detalle.Size = new System.Drawing.Size(578, 261);
            this.Dgv_detalle.TabIndex = 46;
            // 
            // Txt_CodigoProveedor
            // 
            this.Txt_CodigoProveedor.Enabled = false;
            this.Txt_CodigoProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoProveedor.Location = new System.Drawing.Point(259, 284);
            this.Txt_CodigoProveedor.Name = "Txt_CodigoProveedor";
            this.Txt_CodigoProveedor.ReadOnly = true;
            this.Txt_CodigoProveedor.Size = new System.Drawing.Size(195, 27);
            this.Txt_CodigoProveedor.TabIndex = 47;
            this.Txt_CodigoProveedor.Tag = "2";
            this.Txt_CodigoProveedor.TextChanged += new System.EventHandler(this.Txt_CodigoProveedor_TextChanged);
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
            this.Cbo_Proveedores.SelectedIndexChanged += new System.EventHandler(this.Cbo_Proveedores_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cbo_Proveedores);
            this.panel3.Location = new System.Drawing.Point(459, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 38);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Dgv_detalle);
            this.panel4.Location = new System.Drawing.Point(229, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 285);
            this.panel4.TabIndex = 56;
            // 
            // Txt_FOrden
            // 
            this.Txt_FOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FOrden.Location = new System.Drawing.Point(259, 315);
            this.Txt_FOrden.Name = "Txt_FOrden";
            this.Txt_FOrden.Size = new System.Drawing.Size(194, 27);
            this.Txt_FOrden.TabIndex = 57;
            this.Txt_FOrden.Tag = "4";
            this.Txt_FOrden.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_FEntrega
            // 
            this.Txt_FEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FEntrega.Location = new System.Drawing.Point(643, 315);
            this.Txt_FEntrega.Name = "Txt_FEntrega";
            this.Txt_FEntrega.Size = new System.Drawing.Size(194, 27);
            this.Txt_FEntrega.TabIndex = 58;
            this.Txt_FEntrega.Tag = "5";
            this.Txt_FEntrega.TextChanged += new System.EventHandler(this.Txt_FEntrega_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button3.BackgroundImage = global::OrdenesDeCompra.Properties.Resources.Search_32x32;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(162, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 60);
            this.button3.TabIndex = 59;
            this.button3.Text = "Detalle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InterfazSolicitudOrdenesDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_FEntrega);
            this.Controls.Add(this.Txt_CodigoProveedor);
            this.Controls.Add(this.Txt_FOrden);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_Aprobacion);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_NOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Solicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "InterfazSolicitudOrdenesDeCompra";
            this.Load += new System.EventHandler(this.InterfazSolicitudOrdenesDeCompra_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Txt_Solicitante, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Txt_NOrden, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Txt_total, 0);
            this.Controls.SetChildIndex(this.Txt_Aprobacion, 0);
            this.Controls.SetChildIndex(this.navegador1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.Txt_FOrden, 0);
            this.Controls.SetChildIndex(this.Txt_CodigoProveedor, 0);
            this.Controls.SetChildIndex(this.Txt_FEntrega, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Txt_total;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Txt_NOrden;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Txt_Solicitante;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Txt_Aprobacion;
        private CapaDiseno.Navegador navegador1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Txt_CodigoProveedor;
        public System.Windows.Forms.DataGridView Dgv_detalle;
        private System.Windows.Forms.ComboBox Cbo_Proveedores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox Txt_FEntrega;
        public System.Windows.Forms.TextBox Txt_FOrden;
        private System.Windows.Forms.Button button3;
    }
}
