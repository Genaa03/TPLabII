namespace LabParte3.Presentaciones
{
    partial class FormConsulta8
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
            this.lblConsultaN5 = new System.Windows.Forms.Label();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.lblAñoaRevisar = new System.Windows.Forms.Label();
            this.rvConsulta8 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaN5
            // 
            this.lblConsultaN5.AutoSize = true;
            this.lblConsultaN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaN5.Location = new System.Drawing.Point(203, 9);
            this.lblConsultaN5.Name = "lblConsultaN5";
            this.lblConsultaN5.Size = new System.Drawing.Size(108, 18);
            this.lblConsultaN5.TabIndex = 3;
            this.lblConsultaN5.Text = "Consulta N°8";
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(151, 46);
            this.nudAño.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(120, 20);
            this.nudAño.TabIndex = 4;
            this.nudAño.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // lblAñoaRevisar
            // 
            this.lblAñoaRevisar.AutoSize = true;
            this.lblAñoaRevisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoaRevisar.Location = new System.Drawing.Point(56, 46);
            this.lblAñoaRevisar.Name = "lblAñoaRevisar";
            this.lblAñoaRevisar.Size = new System.Drawing.Size(89, 16);
            this.lblAñoaRevisar.TabIndex = 5;
            this.lblAñoaRevisar.Text = "Año a revisar:";
            // 
            // rvConsulta8
            // 
            this.rvConsulta8.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta8.ReporteConsulta8.rdlc";
            this.rvConsulta8.Location = new System.Drawing.Point(48, 82);
            this.rvConsulta8.Name = "rvConsulta8";
            this.rvConsulta8.ServerReport.BearerToken = null;
            this.rvConsulta8.Size = new System.Drawing.Size(442, 333);
            this.rvConsulta8.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(226, 423);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(310, 39);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(180, 28);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FormConsulta8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 458);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rvConsulta8);
            this.Controls.Add(this.lblAñoaRevisar);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.lblConsultaN5);
            this.Name = "FormConsulta8";
            this.Text = "Consulta8";
            this.Load += new System.EventHandler(this.FormConsulta8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaN5;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblAñoaRevisar;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
    }
}