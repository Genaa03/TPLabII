namespace LabParte3.Presentaciones
{
    partial class FormConsulta5
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
            this.lblTecnicatura = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboTecnicaturas = new System.Windows.Forms.ComboBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.rvConsulta5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsultaN5
            // 
            this.lblConsultaN5.AutoSize = true;
            this.lblConsultaN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaN5.Location = new System.Drawing.Point(285, 13);
            this.lblConsultaN5.Name = "lblConsultaN5";
            this.lblConsultaN5.Size = new System.Drawing.Size(130, 24);
            this.lblConsultaN5.TabIndex = 1;
            this.lblConsultaN5.Text = "Consulta N°5";
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicatura.Location = new System.Drawing.Point(29, 122);
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(81, 16);
            this.lblTecnicatura.TabIndex = 3;
            this.lblTecnicatura.Text = "Tecnicatura:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(262, 123);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 16);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia:";
            // 
            // cboTecnicaturas
            // 
            this.cboTecnicaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnicaturas.FormattingEnabled = true;
            this.cboTecnicaturas.Location = new System.Drawing.Point(116, 121);
            this.cboTecnicaturas.Name = "cboTecnicaturas";
            this.cboTecnicaturas.Size = new System.Drawing.Size(121, 21);
            this.cboTecnicaturas.TabIndex = 5;
            this.cboTecnicaturas.SelectionChangeCommitted += new System.EventHandler(this.cboTecnicaturas_SelectedIndexChanged);
            // 
            // cboMaterias
            // 
            this.cboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(325, 121);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(121, 21);
            this.cboMaterias.TabIndex = 6;
            // 
            // rvConsulta5
            // 
            this.rvConsulta5.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta5.ReporteConsulta5.rdlc";
            this.rvConsulta5.Location = new System.Drawing.Point(32, 175);
            this.rvConsulta5.Name = "rvConsulta5";
            this.rvConsulta5.ServerReport.BearerToken = null;
            this.rvConsulta5.Size = new System.Drawing.Size(636, 246);
            this.rvConsulta5.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(313, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(485, 114);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(183, 32);
            this.btnMostrar.TabIndex = 25;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(50, 37);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(601, 61);
            this.lblEnunciado.TabIndex = 41;
            this.lblEnunciado.Text = "Consulta que permite ver los datos de los alumnos que se encuentran libres en una" +
    " materia elegida y al profesor que dicto esa materia, solo si el alumno el año a" +
    "nterior aprobo una materia o mas.";
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 477);
            this.ControlBox = false;
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rvConsulta5);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.cboTecnicaturas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.lblConsultaN5);
            this.Name = "FormConsulta5";
            this.Text = "Consulta5";
            this.Load += new System.EventHandler(this.FormConsulta5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaN5;
        private System.Windows.Forms.Label lblTecnicatura;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboTecnicaturas;
        private System.Windows.Forms.ComboBox cboMaterias;
        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblEnunciado;
    }
}