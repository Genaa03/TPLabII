namespace LabParte3.Presentaciones
{
    partial class FormConsulta2
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.lblPromedio1 = new System.Windows.Forms.Label();
            this.rvConsulta2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(352, 134);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(183, 32);
            this.btnMostrar.TabIndex = 26;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(147, 143);
            this.nudAño.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(63, 20);
            this.nudAño.TabIndex = 34;
            this.nudAño.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // lblPromedio1
            // 
            this.lblPromedio1.AutoSize = true;
            this.lblPromedio1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio1.Location = new System.Drawing.Point(101, 141);
            this.lblPromedio1.Name = "lblPromedio1";
            this.lblPromedio1.Size = new System.Drawing.Size(40, 18);
            this.lblPromedio1.TabIndex = 33;
            this.lblPromedio1.Text = "Año:";
            // 
            // rvConsulta2
            // 
            this.rvConsulta2.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta2.ReporteConsulta2.rdlc";
            this.rvConsulta2.Location = new System.Drawing.Point(35, 215);
            this.rvConsulta2.Name = "rvConsulta2";
            this.rvConsulta2.ServerReport.BearerToken = null;
            this.rvConsulta2.Size = new System.Drawing.Size(655, 337);
            this.rvConsulta2.TabIndex = 35;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(287, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Consulta N°2";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(310, 574);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 23);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 609);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rvConsulta2);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.lblPromedio1);
            this.Controls.Add(this.btnMostrar);
            this.Name = "FormConsulta2";
            this.Text = "FormConsulta2";
            this.Load += new System.EventHandler(this.FormConsulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblPromedio1;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
    }
}