using LabParte3.Datos.Implementaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace LabParte3.Presentaciones
{
    public partial class FormConsulta3 : Form
    {
        private static FormConsulta3 instancia;
        private Gestor gestor;
        public FormConsulta3()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta3 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta3();
            }
            return instancia;
        }

        private void FormConsulta3_Load(object sender, EventArgs e)
        {
            dtpFecha1.MaxDate = DateTime.Today;
            dtpFecha2.MaxDate = DateTime.Today;
            this.rvConsulta3.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (dtpFecha1.Value == dtpFecha2.Value || dtpFecha1.Value > DateTime.Today || dtpFecha2.Value > DateTime.Today)
            {
                MessageBox.Show("Las fechas no pueden ser un futuro ni iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpFecha1.Value > dtpFecha2.Value)
            {
                MessageBox.Show("La fecha 1 no puede ser mayor que la fecha 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DateTime fecha1 = Convert.ToDateTime(dtpFecha1.Value.ToString());
                DateTime fecha2 = Convert.ToDateTime(dtpFecha2.Value.ToString());
                int promedio1 = (int)nudPromedio1.Value;
                int promedio2 = (int)nudPromedio2.Value;

                DataTable tabla = gestor.consulta3(promedio1, promedio2, fecha1, fecha2);

                if (tabla.Rows.Count > 0)
                {
                    rvConsulta3.LocalReport.DataSources.Clear();
                    rvConsulta3.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta3", tabla));
                    rvConsulta3.RefreshReport();
                }
                else
                {
                    rvConsulta3.LocalReport.DataSources.Clear();
                    rvConsulta3.RefreshReport();
                    MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }
    }
}
