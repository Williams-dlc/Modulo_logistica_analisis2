namespace MantenimientoModelo
{
    partial class InterfazMantenimientoModelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_PK_id_modelo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Lbl_Ingreso = new System.Windows.Forms.Label();
            this.navegador2 = new CapaDiseno.Navegador();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "5610 Mantenimiento a Modelos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.Btn_Minimizar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1287, 42);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.BackgroundImage = global::MantenimientoModelo.Properties.Resources.minimize;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(1140, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.button1.BackgroundImage = global::MantenimientoModelo.Properties.Resources.Cancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1200, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MantenimientoModelo.Properties.Resources.transportadora;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 41);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Txt_PK_id_modelo
            // 
            this.Txt_PK_id_modelo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PK_id_modelo.Location = new System.Drawing.Point(611, 423);
            this.Txt_PK_id_modelo.Name = "Txt_PK_id_modelo";
            this.Txt_PK_id_modelo.Size = new System.Drawing.Size(313, 34);
            this.Txt_PK_id_modelo.TabIndex = 3;
            this.Txt_PK_id_modelo.Tag = "1";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(611, 493);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(313, 34);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.Tag = "2";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(402, 426);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(127, 26);
            this.Lbl_Id.TabIndex = 5;
            this.Lbl_Id.Text = "Id Modelo:";
            this.Lbl_Id.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(336, 493);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(193, 26);
            this.Lbl_Nombre.TabIndex = 6;
            this.Lbl_Nombre.Text = "Nombre Modelo:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(1, 57);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1284, 73);
            this.navegador1.TabIndex = 2;
            // 
            // Lbl_Ingreso
            // 
            this.Lbl_Ingreso.AutoSize = true;
            this.Lbl_Ingreso.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingreso.Location = new System.Drawing.Point(478, 274);
            this.Lbl_Ingreso.Name = "Lbl_Ingreso";
            this.Lbl_Ingreso.Size = new System.Drawing.Size(243, 34);
            this.Lbl_Ingreso.TabIndex = 7;
            this.Lbl_Ingreso.Text = "Ingreso de Datos";
            // 
            // navegador2
            // 
            this.navegador2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador2.DataGr = null;
            this.navegador2.Location = new System.Drawing.Point(3, 85);
            this.navegador2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador2.Name = "navegador2";
            this.navegador2.Procedimiento = null;
            this.navegador2.pubNombrechm = null;
            this.navegador2.pubNombreHtml = null;
            this.navegador2.Size = new System.Drawing.Size(1286, 92);
            this.navegador2.TabIndex = 8;
            // 
            // InterfazMantenimientoModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1287, 694);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.Lbl_Ingreso);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_PK_id_modelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazMantenimientoModelos";
            this.Text = "Id Modelo";
            this.Load += new System.EventHandler(this.InterfazMantenimientoModelos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Minimizar;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.TextBox Txt_PK_id_modelo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Ingreso;
        private CapaDiseno.Navegador navegador2;
    }
}