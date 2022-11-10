namespace LabParte3.Presentaciones
{
    partial class FormConsulta3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta3));
            this.rvConsulta3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblPromedio1 = new System.Windows.Forms.Label();
            this.nudPromedio1 = new System.Windows.Forms.NumericUpDown();
            this.nudPromedio2 = new System.Windows.Forms.NumericUpDown();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio2)).BeginInit();
            this.SuspendLayout();
            // 
            // rvConsulta3
            // 
            this.rvConsulta3.LocalReport.ReportEmbeddedResource = "LabParte3.Presentaciones.Reportes.Consulta3.ReporteConsulta3.rdlc";
            this.rvConsulta3.Location = new System.Drawing.Point(31, 230);
            this.rvConsulta3.Name = "rvConsulta3";
            this.rvConsulta3.ServerReport.BearerToken = null;
            this.rvConsulta3.Size = new System.Drawing.Size(732, 342);
            this.rvConsulta3.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(615, 173);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(183, 32);
            this.btnMostrar.TabIndex = 25;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(318, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Consulta N°3";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(452, 179);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(135, 20);
            this.dtpFecha2.TabIndex = 30;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(164, 179);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(135, 20);
            this.dtpFecha1.TabIndex = 29;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.Location = new System.Drawing.Point(345, 180);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 28;
            this.lblFecha2.Text = "Despues de: ";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.Location = new System.Drawing.Point(69, 180);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(78, 18);
            this.lblFecha1.TabIndex = 27;
            this.lblFecha1.Text = "Antes de: ";
            // 
            // lblPromedio1
            // 
            this.lblPromedio1.AutoSize = true;
            this.lblPromedio1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio1.Location = new System.Drawing.Point(6, 132);
            this.lblPromedio1.Name = "lblPromedio1";
            this.lblPromedio1.Size = new System.Drawing.Size(141, 18);
            this.lblPromedio1.TabIndex = 31;
            this.lblPromedio1.Text = "Promedio mayor a:";
            // 
            // nudPromedio1
            // 
            this.nudPromedio1.Location = new System.Drawing.Point(164, 131);
            this.nudPromedio1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPromedio1.Name = "nudPromedio1";
            this.nudPromedio1.Size = new System.Drawing.Size(63, 20);
            this.nudPromedio1.TabIndex = 32;
            // 
            // nudPromedio2
            // 
            this.nudPromedio2.Location = new System.Drawing.Point(452, 131);
            this.nudPromedio2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPromedio2.Name = "nudPromedio2";
            this.nudPromedio2.Size = new System.Drawing.Size(63, 20);
            this.nudPromedio2.TabIndex = 34;
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.AutoSize = true;
            this.lblPromedio2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio2.Location = new System.Drawing.Point(305, 132);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(141, 18);
            this.lblPromedio2.TabIndex = 33;
            this.lblPromedio2.Text = "Promedio mayor a:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(346, 610);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 23);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(27, 57);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(761, 62);
            this.lblEnunciado.TabIndex = 39;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 648);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.nudPromedio2);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.nudPromedio1);
            this.Controls.Add(this.lblPromedio1);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rvConsulta3);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "FormConsulta3";
            this.Text = "FormConsulta3";
            this.Load += new System.EventHandler(this.FormConsulta3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvConsulta3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblPromedio1;
        private System.Windows.Forms.NumericUpDown nudPromedio1;
        private System.Windows.Forms.NumericUpDown nudPromedio2;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEnunciado;
    }
}