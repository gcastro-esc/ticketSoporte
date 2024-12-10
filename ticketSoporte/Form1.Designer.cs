namespace ticketSoporte
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dateFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cbEntorno = new System.Windows.Forms.ComboBox();
            this.lblEntorno = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lvReportes = new System.Windows.Forms.ListView();
            this.btnResumen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(302, -1);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(219, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Tech Guard Solutions";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(385, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(54, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(228, 59);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(367, 22);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Soluciones de Soporte IT confiables y rapidas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 88);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 31);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Registro de Ticket de Soporte Técnico  IT";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTicket
            // 
            this.gbTicket.Controls.Add(this.btnCancelar);
            this.gbTicket.Controls.Add(this.btnGenerar);
            this.gbTicket.Controls.Add(this.txtDescripcion);
            this.gbTicket.Controls.Add(this.lblDescripcion);
            this.gbTicket.Controls.Add(this.dateFechaReporte);
            this.gbTicket.Controls.Add(this.lblFecha);
            this.gbTicket.Controls.Add(this.cbPrioridad);
            this.gbTicket.Controls.Add(this.lblPrioridad);
            this.gbTicket.Controls.Add(this.cbEntorno);
            this.gbTicket.Controls.Add(this.lblEntorno);
            this.gbTicket.Controls.Add(this.cbTecnico);
            this.gbTicket.Controls.Add(this.lblTecnico);
            this.gbTicket.Controls.Add(this.txtCliente);
            this.gbTicket.Controls.Add(this.lblCliente);
            this.gbTicket.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicket.ForeColor = System.Drawing.Color.White;
            this.gbTicket.Location = new System.Drawing.Point(16, 122);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(795, 377);
            this.gbTicket.TabIndex = 4;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = " Solicitud de Atención de Soporte Técnico ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnCancelar.Location = new System.Drawing.Point(478, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(280, 45);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar Reporte";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnGenerar.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnGenerar.Location = new System.Drawing.Point(29, 321);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(280, 45);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Location = new System.Drawing.Point(346, 159);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(412, 141);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(342, 132);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(416, 22);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "DESCRIPCIÓN DE LA FALLA";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateFechaReporte
            // 
            this.dateFechaReporte.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dateFechaReporte.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dateFechaReporte.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaReporte.Location = new System.Drawing.Point(29, 277);
            this.dateFechaReporte.Name = "dateFechaReporte";
            this.dateFechaReporte.Size = new System.Drawing.Size(280, 23);
            this.dateFechaReporte.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 252);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(280, 22);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "FECHA  DE REPORTE";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Items.AddRange(new object[] {
            "Normal ",
            "Alta",
            "Urgente"});
            this.cbPrioridad.Location = new System.Drawing.Point(29, 217);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(280, 30);
            this.cbPrioridad.TabIndex = 7;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(29, 192);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(280, 22);
            this.lblPrioridad.TabIndex = 6;
            this.lblPrioridad.Text = "PRIORIDAD";
            this.lblPrioridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEntorno
            // 
            this.cbEntorno.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbEntorno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbEntorno.FormattingEnabled = true;
            this.cbEntorno.Items.AddRange(new object[] {
            "En Sitio",
            "Virtual ",
            "Telefónico"});
            this.cbEntorno.Location = new System.Drawing.Point(29, 159);
            this.cbEntorno.Name = "cbEntorno";
            this.cbEntorno.Size = new System.Drawing.Size(280, 30);
            this.cbEntorno.TabIndex = 5;
            // 
            // lblEntorno
            // 
            this.lblEntorno.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntorno.Location = new System.Drawing.Point(25, 132);
            this.lblEntorno.Name = "lblEntorno";
            this.lblEntorno.Size = new System.Drawing.Size(284, 22);
            this.lblEntorno.TabIndex = 4;
            this.lblEntorno.Text = "ENTORNO DE ATENCIÓN";
            this.lblEntorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTecnico
            // 
            this.cbTecnico.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Items.AddRange(new object[] {
            "Daenerys Targaryen",
            "Jon Snow",
            "Cersei Lannister",
            "Tyrion Lannister"});
            this.cbTecnico.Location = new System.Drawing.Point(29, 95);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(729, 30);
            this.cbTecnico.TabIndex = 3;
            // 
            // lblTecnico
            // 
            this.lblTecnico.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(29, 71);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(729, 22);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "TÉCNICO DE SOPORTE ASIGNADO";
            this.lblTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCliente.Location = new System.Drawing.Point(29, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(729, 27);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(29, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(729, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvReportes
            // 
            this.lvReportes.Location = new System.Drawing.Point(16, 504);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(795, 97);
            this.lvReportes.TabIndex = 5;
            this.lvReportes.UseCompatibleStateImageBehavior = false;
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnResumen.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnResumen.Location = new System.Drawing.Point(494, 607);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(280, 45);
            this.btnResumen.TabIndex = 14;
            this.btnResumen.Text = "Resumen de Reporte";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.lvReportes);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporte";
            this.Text = "TechGuard Solutions";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEntorno;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cbEntorno;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker dateFechaReporte;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListView lvReportes;
        private System.Windows.Forms.Button btnResumen;
    }
}

