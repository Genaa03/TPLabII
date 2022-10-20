namespace LabParte3.Presentaciones
{
    partial class FormConsulta1B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta1B));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cboTipoExamen = new System.Windows.Forms.ComboBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblTipoExamen = new System.Windows.Forms.Label();
            this.cboTecnicaturas = new System.Windows.Forms.ComboBox();
            this.lblTecnicatura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rvConsulta1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(612, 165);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(183, 32);
            this.btnMostrar.TabIndex = 24;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(409, 172);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaHasta.TabIndex = 23;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(166, 172);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaDesde.TabIndex = 22;
            // 
            // cboTipoExamen
            // 
            this.cboTipoExamen.FormattingEnabled = true;
            this.cboTipoExamen.Location = new System.Drawing.Point(560, 119);
            this.cboTipoExamen.Name = "cboTipoExamen";
            this.cboTipoExamen.Size = new System.Drawing.Size(135, 21);
            this.cboTipoExamen.TabIndex = 21;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(335, 173);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(53, 18);
            this.lblFechaHasta.TabIndex = 20;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(75, 172);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(59, 18);
            this.lblFechaDesde.TabIndex = 19;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblTipoExamen
            // 
            this.lblTipoExamen.AutoSize = true;
            this.lblTipoExamen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoExamen.Location = new System.Drawing.Point(403, 120);
            this.lblTipoExamen.Name = "lblTipoExamen";
            this.lblTipoExamen.Size = new System.Drawing.Size(125, 18);
            this.lblTipoExamen.TabIndex = 18;
            this.lblTipoExamen.Text = "Tipo de Examen:";
            // 
            // cboTecnicaturas
            // 
            this.cboTecnicaturas.FormattingEnabled = true;
            this.cboTecnicaturas.Location = new System.Drawing.Point(198, 119);
            this.cboTecnicaturas.Name = "cboTecnicaturas";
            this.cboTecnicaturas.Size = new System.Drawing.Size(135, 21);
            this.cboTecnicaturas.TabIndex = 17;
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicatura.Location = new System.Drawing.Point(75, 120);
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(91, 18);
            this.lblTecnicatura.TabIndex = 16;
            this.lblTecnicatura.Text = "Tecnicatura:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Consulta N°1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(351, 576);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rvConsulta1
            // 
            this.rvConsulta1.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta1.ReporteConsulta11.rdlc";
            this.rvConsulta1.Location = new System.Drawing.Point(36, 211);
            this.rvConsulta1.Name = "rvConsulta1";
            this.rvConsulta1.ServerReport.BearerToken = null;
            this.rvConsulta1.Size = new System.Drawing.Size(744, 349);
            this.rvConsulta1.TabIndex = 25;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(22, 47);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(773, 69);
            this.lblEnunciado.TabIndex = 26;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            // 
            // FormConsulta1B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 621);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.rvConsulta1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.cboTipoExamen);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblTipoExamen);
            this.Controls.Add(this.cboTecnicaturas);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormConsulta1B";
            this.Text = "Consulta N°1";
            this.Load += new System.EventHandler(this.FormConsulta1B_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ComboBox cboTipoExamen;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblTipoExamen;
        private System.Windows.Forms.ComboBox cboTecnicaturas;
        private System.Windows.Forms.Label lblTecnicatura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta1;
        private System.Windows.Forms.Label lblEnunciado;
    }
}