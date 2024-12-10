namespace ticketSoporte
{
    partial class frmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumen));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.lblFalla = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblEntorno = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 31);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Resumen de Ticket de Soporte";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(165, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(54, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(360, 26);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Tech Guard Solutions";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.lblFalla);
            this.gbResumen.Controls.Add(this.lblFecha);
            this.gbResumen.Controls.Add(this.lblPrioridad);
            this.gbResumen.Controls.Add(this.lblEntorno);
            this.gbResumen.Controls.Add(this.lblTecnico);
            this.gbResumen.Controls.Add(this.lblCliente);
            this.gbResumen.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.ForeColor = System.Drawing.Color.White;
            this.gbResumen.Location = new System.Drawing.Point(19, 115);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(344, 320);
            this.gbResumen.TabIndex = 7;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = " Ticket # ";
            // 
            // lblFalla
            // 
            this.lblFalla.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalla.Location = new System.Drawing.Point(15, 163);
            this.lblFalla.Name = "lblFalla";
            this.lblFalla.Size = new System.Drawing.Size(315, 139);
            this.lblFalla.TabIndex = 5;
            this.lblFalla.Text = "Descripción de la Falla";
            this.lblFalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 129);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(315, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de Reporte";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.BackColor = System.Drawing.Color.White;
            this.lblPrioridad.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.lblPrioridad.Location = new System.Drawing.Point(203, 95);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(122, 25);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            this.lblPrioridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntorno
            // 
            this.lblEntorno.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntorno.Location = new System.Drawing.Point(15, 95);
            this.lblEntorno.Name = "lblEntorno";
            this.lblEntorno.Size = new System.Drawing.Size(122, 25);
            this.lblEntorno.TabIndex = 2;
            this.lblEntorno.Text = "Entorno";
            this.lblEntorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTecnico
            // 
            this.lblTecnico.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(15, 56);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(315, 25);
            this.lblTecnico.TabIndex = 1;
            this.lblTecnico.Text = "Técnico";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(15, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(315, 25);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnImprimir.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnImprimir.Location = new System.Drawing.Point(19, 444);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(344, 45);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir Ticket";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(384, 501);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResumen";
            this.Text = "Ticket - TechGuard Solutions";
            this.Load += new System.EventHandler(this.frmResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbResumen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox gbResumen;
        public System.Windows.Forms.Label lblTecnico;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblEntorno;
        public System.Windows.Forms.Label lblFalla;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}