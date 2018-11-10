namespace MantenimientosLinea
{
    partial class InterfazMantenimientoMarca
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
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Serie = new System.Windows.Forms.Label();
            this.Txt_StatusModelo = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_PK_id_modelo = new System.Windows.Forms.TextBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.Dtp_Año = new System.Windows.Forms.DateTimePicker();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Cbo_Modelo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 42);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.BackgroundImage = global::MantenimientosLinea.Properties.Resources.minimize1;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(1177, 1);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 22;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "5630 Mantenimiento a Marca";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Cerrar.BackgroundImage = global::MantenimientosLinea.Properties.Resources.Cancelar1;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Location = new System.Drawing.Point(1244, 1);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 21;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MantenimientosLinea.Properties.Resources.transportadora1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 41);
            this.panel2.TabIndex = 23;
            // 
            // Lbl_Serie
            // 
            this.Lbl_Serie.AutoSize = true;
            this.Lbl_Serie.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Serie.Location = new System.Drawing.Point(141, 503);
            this.Lbl_Serie.Name = "Lbl_Serie";
            this.Lbl_Serie.Size = new System.Drawing.Size(69, 26);
            this.Lbl_Serie.TabIndex = 14;
            this.Lbl_Serie.Text = "Serie:";
            // 
            // Txt_StatusModelo
            // 
            this.Txt_StatusModelo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_StatusModelo.Location = new System.Drawing.Point(292, 495);
            this.Txt_StatusModelo.Name = "Txt_StatusModelo";
            this.Txt_StatusModelo.Size = new System.Drawing.Size(313, 34);
            this.Txt_StatusModelo.TabIndex = 13;
            this.Txt_StatusModelo.Tag = "3";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(105, 432);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(105, 26);
            this.Lbl_Nombre.TabIndex = 12;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID.Location = new System.Drawing.Point(108, 362);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(102, 26);
            this.Lbl_ID.TabIndex = 11;
            this.Lbl_ID.Text = "Id Linea:";
            this.Lbl_ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(292, 429);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(313, 34);
            this.Txt_Nombre.TabIndex = 10;
            this.Txt_Nombre.Tag = "2";
            // 
            // Txt_PK_id_modelo
            // 
            this.Txt_PK_id_modelo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PK_id_modelo.Location = new System.Drawing.Point(292, 359);
            this.Txt_PK_id_modelo.Name = "Txt_PK_id_modelo";
            this.Txt_PK_id_modelo.Size = new System.Drawing.Size(313, 34);
            this.Txt_PK_id_modelo.TabIndex = 9;
            this.Txt_PK_id_modelo.Tag = "1";
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.Location = new System.Drawing.Point(754, 356);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(61, 26);
            this.Lbl_año.TabIndex = 16;
            this.Lbl_año.Text = "Año:";
            // 
            // Dtp_Año
            // 
            this.Dtp_Año.Location = new System.Drawing.Point(852, 356);
            this.Dtp_Año.Name = "Dtp_Año";
            this.Dtp_Año.Size = new System.Drawing.Size(313, 26);
            this.Dtp_Año.TabIndex = 23;
            this.Dtp_Año.Tag = "4";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(-1, 80);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1286, 92);
            this.navegador1.TabIndex = 27;
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.Location = new System.Drawing.Point(738, 480);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(100, 26);
            this.Lbl_Modelo.TabIndex = 20;
            this.Lbl_Modelo.Text = "Modelo:";
            // 
            // Cbo_Modelo
            // 
            this.Cbo_Modelo.FormattingEnabled = true;
            this.Cbo_Modelo.Location = new System.Drawing.Point(852, 478);
            this.Cbo_Modelo.Name = "Cbo_Modelo";
            this.Cbo_Modelo.Size = new System.Drawing.Size(313, 28);
            this.Cbo_Modelo.TabIndex = 28;
            // 
            // InterfazMantenimientoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1288, 806);
            this.Controls.Add(this.Cbo_Modelo);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Dtp_Año);
            this.Controls.Add(this.Lbl_año);
            this.Controls.Add(this.Lbl_Serie);
            this.Controls.Add(this.Txt_StatusModelo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_PK_id_modelo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazMantenimientoMarca";
            this.Text = "InterfazMantenimientoLinea";
            this.Load += new System.EventHandler(this.InterfazMantenimientoLinea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Serie;
        private System.Windows.Forms.TextBox Txt_StatusModelo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_PK_id_modelo;
        private System.Windows.Forms.Label Lbl_año;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.DateTimePicker Dtp_Año;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.ComboBox Cbo_Modelo;
    }
}