using LabParte3.Datos.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabParte3.Presentaciones
{
    public partial class FormConsulta6 : Form
    {
        private static FormConsulta6 instancia;
        private Gestor gestor;
        public FormConsulta6()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta6 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta6();
            }
            return instancia;
        }

        private void FormConsulta6_Load(object sender, EventArgs e)
        {

            this.rvConsulta6.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("La fecha desde es mayor que la de hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                DateTime fechaDesde = Convert.ToDateTime(dtpFechaDesde.Value.ToString());
                DateTime fechaHasta = Convert.ToDateTime(dtpFechaHasta.Value.ToString());

                tabla = gestor.consulta6(fechaDesde, fechaHasta);
                tabla2 = gestor.consultaPromedio();
            }

            if (tabla.Rows.Count > 0)
            {
                rvConsulta6.LocalReport.DataSources.Clear();
                rvConsulta6.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta6", tabla));
                rvConsulta6.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Promedio6", tabla2));
                rvConsulta6.RefreshReport();
            }
            else
            {
                rvConsulta6.LocalReport.DataSources.Clear();
                rvConsulta6.RefreshReport();
                MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
