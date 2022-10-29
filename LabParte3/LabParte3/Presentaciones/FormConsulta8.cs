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
    public partial class FormConsulta8 : Form
    {
        private static FormConsulta8 instancia;
        private Gestor gestor;
        public FormConsulta8()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta8 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta8();
            }
            return instancia;
        }

        private void FormConsulta8_Load(object sender, EventArgs e)
        {
            nudAño.Maximum = DateTime.Now.Year;
            nudAño.Value = DateTime.Now.Year;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int año = (int)nudAño.Value;

            DataTable tabla = gestor.consulta8(año);
            DataTable tabla2 = gestor.consultaPromedio();

            if(tabla.Rows.Count > 0)
            {
                rvConsulta8.LocalReport.DataSources.Clear();
                rvConsulta8.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta8", tabla));
                rvConsulta8.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Promedio8", tabla2));
                rvConsulta8.RefreshReport();
            }
            else
            {
                rvConsulta8.LocalReport.DataSources.Clear();
                rvConsulta8.RefreshReport();
                MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }
    }
}
