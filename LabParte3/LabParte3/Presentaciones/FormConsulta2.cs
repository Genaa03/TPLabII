using LabParte3.Datos.Implementaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace LabParte3.Presentaciones
{
    public partial class FormConsulta2 : Form
    {
        private static FormConsulta2 instancia;
        private Gestor gestor;
        public FormConsulta2()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta2 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta2();
            }
            return instancia;
        }

        private void FormConsulta2_Load(object sender, EventArgs e)
        {
            nudAño.Maximum = DateTime.Now.Year;
            nudAño.Value = DateTime.Now.Year;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
                int año = (int)nudAño.Value;

                DataTable tabla = gestor.consulta2(año);

            if (tabla.Rows.Count > 0)
            {
                rvConsulta2.LocalReport.DataSources.Clear();
                rvConsulta2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta2", tabla));
                rvConsulta2.RefreshReport();
            }
            else
            {
                rvConsulta2.LocalReport.DataSources.Clear();
                rvConsulta2.RefreshReport();
                MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }
    }
}
