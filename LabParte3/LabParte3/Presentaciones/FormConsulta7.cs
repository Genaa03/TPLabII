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
    public partial class FormConsulta7 : Form
    {
        private static FormConsulta7 instancia;
        private Gestor gestor;
        public FormConsulta7()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta7 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta7();
            }
            return instancia;
        }

        private void FormConsulta7_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = gestor.consulta7();
            DataTable tabla2 = gestor.consultaPromedio();

            if (tabla.Rows.Count > 0)
            {
                rvConsulta7.LocalReport.DataSources.Clear();
                rvConsulta7.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta7", tabla));
                rvConsulta7.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Promedio7", tabla2));
                rvConsulta7.RefreshReport();
            }
            else
            {
                rvConsulta7.LocalReport.DataSources.Clear();
                rvConsulta7.RefreshReport();
                MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
