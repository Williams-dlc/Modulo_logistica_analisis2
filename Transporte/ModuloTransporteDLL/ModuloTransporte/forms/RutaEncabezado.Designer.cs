namespace ModuloTransporte.forms
{
    partial class RutaEncabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutaEncabezado));
            this.dgr = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(134, 71);
            this.dgr.Name = "dgr";
            this.dgr.Size = new System.Drawing.Size(504, 295);
            this.dgr.TabIndex = 0;
            this.dgr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 27);
            this.panel1.TabIndex = 39;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(684, 0);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(27, 27);
            this.Btn_Minimizar.TabIndex = 5;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(11, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 27);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(154)))), ((int)(((byte)(152)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(729, 2);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(27, 27);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "5201 Encabezado Ruta";
            // 
            // RutaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(767, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RutaEncabezado";
            this.Text = "RutaEncabezado";
            this.Load += new System.EventHandler(this.RutaEncabezado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label8;
    }
}