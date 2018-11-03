namespace OrdenesDeCompra.CapaInterfaz
{
    partial class InterfazConsultaOrdenesDeDevolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Devoluciones = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(237, 21);
            this.label11.Text = "5503_Ordenes de Devolucion";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(71, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Solicitud de Orden de Compra";
            // 
            // Dgv_Devoluciones
            // 
            this.Dgv_Devoluciones.AllowDrop = true;
            this.Dgv_Devoluciones.AllowUserToOrderColumns = true;
            this.Dgv_Devoluciones.AllowUserToResizeColumns = false;
            this.Dgv_Devoluciones.AllowUserToResizeRows = false;
            this.Dgv_Devoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Devoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Devoluciones.EnableHeadersVisualStyles = false;
            this.Dgv_Devoluciones.Location = new System.Drawing.Point(77, 199);
            this.Dgv_Devoluciones.Name = "Dgv_Devoluciones";
            this.Dgv_Devoluciones.Size = new System.Drawing.Size(785, 407);
            this.Dgv_Devoluciones.TabIndex = 40;
            this.Dgv_Devoluciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Devoluciones_CellDoubleClick);
            // 
            // InterfazConsultaOrdenesDeDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Devoluciones);
            this.Name = "InterfazConsultaOrdenesDeDevolucion";
            this.Load += new System.EventHandler(this.InterfazConsultaDevoluciones_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.Dgv_Devoluciones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Devoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Dgv_Devoluciones;
    }
}
