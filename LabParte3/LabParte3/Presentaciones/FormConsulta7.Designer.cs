namespace LabParte3.Presentaciones
{
    partial class FormConsulta7
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
            this.rvConsulta7 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsultaN5
            // 
            this.lblConsultaN5.AutoSize = true;
            this.lblConsultaN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaN5.Location = new System.Drawing.Point(300, 9);
            this.lblConsultaN5.Name = "lblConsultaN5";
            this.lblConsultaN5.Size = new System.Drawing.Size(108, 18);
            this.lblConsultaN5.TabIndex = 2;
            this.lblConsultaN5.Text = "Consulta N°7";
            // 
            // rvConsulta7
            // 
            this.rvConsulta7.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta7.ReporteConsulta7.rdlc";
            this.rvConsulta7.Location = new System.Drawing.Point(34, 78);
            this.rvConsulta7.Name = "rvConsulta7";
            this.rvConsulta7.ServerReport.BearerToken = null;
            this.rvConsulta7.Size = new System.Drawing.Size(636, 294);
            this.rvConsulta7.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(289, 41);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 31);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(320, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rvConsulta7);
            this.Controls.Add(this.lblConsultaN5);
            this.Name = "FormConsulta7";
            this.Text = "Consulta7";
            this.Load += new System.EventHandler(this.FormConsulta7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaN5;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta7;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
    }
}