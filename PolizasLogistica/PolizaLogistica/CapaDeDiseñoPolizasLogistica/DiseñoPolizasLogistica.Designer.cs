namespace CapaDeDiseñoPolizasLogistica
{
    partial class FormGenerarPoliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarPoliza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_nombreForm = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Fin = new System.Windows.Forms.Label();
            this.Lbl_No_Poliza = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Lbl_Concepto = new System.Windows.Forms.Label();
            this.Lbl_GenerarPoliza = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_Carga_Datos = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_poliza = new System.Windows.Forms.Button();
            this.Dgv_Poliza = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Poliza)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Lbl_nombreForm);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.transportadora1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(5, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 41);
            this.panel2.TabIndex = 1;
            // 
            // Lbl_nombreForm
            // 
            this.Lbl_nombreForm.AutoSize = true;
            this.Lbl_nombreForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreForm.Location = new System.Drawing.Point(52, 7);
            this.Lbl_nombreForm.Name = "Lbl_nombreForm";
            this.Lbl_nombreForm.Size = new System.Drawing.Size(259, 28);
            this.Lbl_nombreForm.TabIndex = 2;
            this.Lbl_nombreForm.Text = "5410_Polizas logistica";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.Cancelar;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1191, 3);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 1;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.minimize;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.Location = new System.Drawing.Point(1144, 1);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 0;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Dtp_FechaInicio
            // 
            this.Dtp_FechaInicio.Location = new System.Drawing.Point(223, 66);
            this.Dtp_FechaInicio.Name = "Dtp_FechaInicio";
            this.Dtp_FechaInicio.Size = new System.Drawing.Size(325, 26);
            this.Dtp_FechaInicio.TabIndex = 1;
            // 
            // Dtp_FechaFin
            // 
            this.Dtp_FechaFin.Location = new System.Drawing.Point(223, 113);
            this.Dtp_FechaFin.Name = "Dtp_FechaFin";
            this.Dtp_FechaFin.Size = new System.Drawing.Size(325, 26);
            this.Dtp_FechaFin.TabIndex = 2;
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(42, 68);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(162, 23);
            this.Lbl_Fecha_Inicio.TabIndex = 3;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio";
            // 
            // Lbl_Fecha_Fin
            // 
            this.Lbl_Fecha_Fin.AutoSize = true;
            this.Lbl_Fecha_Fin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Fin.Location = new System.Drawing.Point(65, 116);
            this.Lbl_Fecha_Fin.Name = "Lbl_Fecha_Fin";
            this.Lbl_Fecha_Fin.Size = new System.Drawing.Size(136, 23);
            this.Lbl_Fecha_Fin.TabIndex = 4;
            this.Lbl_Fecha_Fin.Text = "Fecha de Fin";
            // 
            // Lbl_No_Poliza
            // 
            this.Lbl_No_Poliza.AutoSize = true;
            this.Lbl_No_Poliza.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Poliza.Location = new System.Drawing.Point(28, 60);
            this.Lbl_No_Poliza.Name = "Lbl_No_Poliza";
            this.Lbl_No_Poliza.Size = new System.Drawing.Size(188, 23);
            this.Lbl_No_Poliza.TabIndex = 10;
            this.Lbl_No_Poliza.Text = "Numero de Poliza:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(133, 117);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(77, 23);
            this.Lbl_Fecha.TabIndex = 13;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(272, 60);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(325, 26);
            this.Txt_id.TabIndex = 14;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Location = new System.Drawing.Point(272, 114);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(325, 26);
            this.Dtp_fecha.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Txt_Tipo);
            this.panel3.Controls.Add(this.Lbl_Concepto);
            this.panel3.Controls.Add(this.Lbl_GenerarPoliza);
            this.panel3.Controls.Add(this.Dtp_fecha);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Txt_id);
            this.panel3.Controls.Add(this.Lbl_Fecha);
            this.panel3.Controls.Add(this.Lbl_No_Poliza);
            this.panel3.Location = new System.Drawing.Point(219, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 242);
            this.panel3.TabIndex = 19;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(272, 161);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(325, 26);
            this.Txt_Tipo.TabIndex = 22;
            // 
            // Lbl_Concepto
            // 
            this.Lbl_Concepto.AutoSize = true;
            this.Lbl_Concepto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Concepto.Location = new System.Drawing.Point(101, 161);
            this.Lbl_Concepto.Name = "Lbl_Concepto";
            this.Lbl_Concepto.Size = new System.Drawing.Size(115, 23);
            this.Lbl_Concepto.TabIndex = 21;
            this.Lbl_Concepto.Text = "Concepto:";
            // 
            // Lbl_GenerarPoliza
            // 
            this.Lbl_GenerarPoliza.AutoSize = true;
            this.Lbl_GenerarPoliza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GenerarPoliza.Location = new System.Drawing.Point(328, 15);
            this.Lbl_GenerarPoliza.Name = "Lbl_GenerarPoliza";
            this.Lbl_GenerarPoliza.Size = new System.Drawing.Size(182, 28);
            this.Lbl_GenerarPoliza.TabIndex = 19;
            this.Lbl_GenerarPoliza.Text = "Generar Poliza";
            this.Lbl_GenerarPoliza.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.archivo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(660, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "Poliza";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Lbl_Carga_Datos);
            this.panel4.Controls.Add(this.Btn_Buscar);
            this.panel4.Controls.Add(this.Btn_poliza);
            this.panel4.Controls.Add(this.Lbl_Fecha_Fin);
            this.panel4.Controls.Add(this.Lbl_Fecha_Inicio);
            this.panel4.Controls.Add(this.Dtp_FechaFin);
            this.panel4.Controls.Add(this.Dtp_FechaInicio);
            this.panel4.Location = new System.Drawing.Point(161, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(937, 171);
            this.panel4.TabIndex = 21;
            // 
            // Lbl_Carga_Datos
            // 
            this.Lbl_Carga_Datos.AutoSize = true;
            this.Lbl_Carga_Datos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Carga_Datos.Location = new System.Drawing.Point(396, 18);
            this.Lbl_Carga_Datos.Name = "Lbl_Carga_Datos";
            this.Lbl_Carga_Datos.Size = new System.Drawing.Size(160, 28);
            this.Lbl_Carga_Datos.TabIndex = 22;
            this.Lbl_Carga_Datos.Text = "Cagar Datos";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_Buscar.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.Search_32x32;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Buscar.Location = new System.Drawing.Point(659, 66);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(80, 70);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_poliza
            // 
            this.Btn_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_poliza.BackgroundImage = global::CapaDeDiseñoPolizasLogistica.Properties.Resources.Save_32x32;
            this.Btn_poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_poliza.Location = new System.Drawing.Point(784, 68);
            this.Btn_poliza.Name = "Btn_poliza";
            this.Btn_poliza.Size = new System.Drawing.Size(79, 71);
            this.Btn_poliza.TabIndex = 6;
            this.Btn_poliza.Text = "Cargar";
            this.Btn_poliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_poliza.UseVisualStyleBackColor = false;
            this.Btn_poliza.Click += new System.EventHandler(this.Btn_poliza_Click);
            // 
            // Dgv_Poliza
            // 
            this.Dgv_Poliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Poliza.Location = new System.Drawing.Point(87, 560);
            this.Dgv_Poliza.Name = "Dgv_Poliza";
            this.Dgv_Poliza.RowTemplate.Height = 28;
            this.Dgv_Poliza.Size = new System.Drawing.Size(1088, 261);
            this.Dgv_Poliza.TabIndex = 22;
            // 
            // FormGenerarPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1244, 862);
            this.Controls.Add(this.Dgv_Poliza);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenerarPoliza";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGenerarPoliza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Poliza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_nombreForm;
        private System.Windows.Forms.DateTimePicker Dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFin;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Fecha_Fin;
        private System.Windows.Forms.Button Btn_poliza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_No_Poliza;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_GenerarPoliza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Carga_Datos;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.Label Lbl_Concepto;
        private System.Windows.Forms.DataGridView Dgv_Poliza;
    }
}