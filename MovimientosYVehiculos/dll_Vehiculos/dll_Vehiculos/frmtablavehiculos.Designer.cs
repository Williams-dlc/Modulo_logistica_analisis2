namespace dll_Vehiculos
{
    partial class frmtablavehiculos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.pnl_encabezado = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.pnl_encabezado);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 27);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.BackgroundImage = global::dll_Vehiculos.Properties.Resources.minimize;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(739, 0);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(27, 27);
            this.Btn_Minimizar.TabIndex = 5;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // pnl_encabezado
            // 
            this.pnl_encabezado.BackgroundImage = global::dll_Vehiculos.Properties.Resources.transportadora;
            this.pnl_encabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_encabezado.Location = new System.Drawing.Point(8, 1);
            this.pnl_encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_encabezado.Name = "pnl_encabezado";
            this.pnl_encabezado.Size = new System.Drawing.Size(27, 27);
            this.pnl_encabezado.TabIndex = 1;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Cerrar.BackgroundImage = global::dll_Vehiculos.Properties.Resources.Cancelar;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Location = new System.Drawing.Point(779, 0);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(27, 27);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(50, 6);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(127, 19);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "5680-Vehiculos";
            // 
            // dgv_vehiculos
            // 
            this.dgv_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehiculos.Location = new System.Drawing.Point(51, 74);
            this.dgv_vehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.RowTemplate.Height = 28;
            this.dgv_vehiculos.Size = new System.Drawing.Size(715, 403);
            this.dgv_vehiculos.TabIndex = 2;
            this.dgv_vehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehiculos_CellContentClick);
            this.dgv_vehiculos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehiculos_CellContentDoubleClick);
            // 
            // frmtablavehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.dgv_vehiculos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtablavehiculos";
            this.Text = "frmtablavehiculos";
            this.Load += new System.EventHandler(this.frmtablavehiculos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Panel pnl_encabezado;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
    }
}