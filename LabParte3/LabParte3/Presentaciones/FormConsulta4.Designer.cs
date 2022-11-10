namespace LabParte3.Presentaciones
{
    partial class FormConsulta4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConsultaN4 = new System.Windows.Forms.Label();
            this.cboEstadoAcademico = new System.Windows.Forms.ComboBox();
            this.lblEstadoAcademico = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.rvConsulta4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsultaN4
            // 
            this.lblConsultaN4.AutoSize = true;
            this.lblConsultaN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaN4.Location = new System.Drawing.Point(283, 9);
            this.lblConsultaN4.Name = "lblConsultaN4";
            this.lblConsultaN4.Size = new System.Drawing.Size(130, 24);
            this.lblConsultaN4.TabIndex = 0;
            this.lblConsultaN4.Text = "Consulta N°4";
            // 
            // cboEstadoAcademico
            // 
            this.cboEstadoAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoAcademico.FormattingEnabled = true;
            this.cboEstadoAcademico.Location = new System.Drawing.Point(158, 116);
            this.cboEstadoAcademico.Name = "cboEstadoAcademico";
            this.cboEstadoAcademico.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoAcademico.TabIndex = 1;
            // 
            // lblEstadoAcademico
            // 
            this.lblEstadoAcademico.AutoSize = true;
            this.lblEstadoAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAcademico.Location = new System.Drawing.Point(27, 118);
            this.lblEstadoAcademico.Name = "lblEstadoAcademico";
            this.lblEstadoAcademico.Size = new System.Drawing.Size(125, 16);
            this.lblEstadoAcademico.TabIndex = 2;
            this.lblEstadoAcademico.Text = "Estado Academico:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(304, 118);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 16);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso:";
            // 
            // cboCursos
            // 
            this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(355, 116);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(121, 21);
            this.cboCursos.TabIndex = 4;
            // 
            // rvConsulta4
            // 
            this.rvConsulta4.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta4.ReporteConsulta4.rdlc";
            this.rvConsulta4.Location = new System.Drawing.Point(30, 155);
            this.rvConsulta4.Name = "rvConsulta4";
            this.rvConsulta4.ServerReport.BearerToken = null;
            this.rvConsulta4.Size = new System.Drawing.Size(636, 246);
            this.rvConsulta4.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(311, 417);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(507, 113);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(176, 27);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(53, 45);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(591, 42);
            this.lblEnunciado.TabIndex = 40;
            this.lblEnunciado.Text = "Consulta que permite ver los alumnos con un estado academico y curso en particula" +
    "r, que se encuentran trabajando.";
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 478);
            this.ControlBox = false;
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rvConsulta4);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblEstadoAcademico);
            this.Controls.Add(this.cboEstadoAcademico);
            this.Controls.Add(this.lblConsultaN4);
            this.Name = "FormConsulta4";
            this.Text = "Consulta4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaN4;
        private System.Windows.Forms.ComboBox cboEstadoAcademico;
        private System.Windows.Forms.Label lblEstadoAcademico;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboCursos;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblEnunciado;
    }
}

