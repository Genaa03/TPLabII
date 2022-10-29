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
    public partial class FormConsulta4 : Form
    {
        private static FormConsulta4 instancia;
        private Gestor gestor;
        public FormConsulta4()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta4 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta4();
            }
            return instancia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombos();
            this.rvConsulta4.RefreshReport();
        }

        private void cargarCombos()
        {

            cboCursos.DataSource = gestor.cargarCursos();
            cboCursos.ValueMember = "id_curso";
            cboCursos.DisplayMember = "descripcion";
            cboCursos.SelectedIndex = -1;

            cboEstadoAcademico.DataSource = gestor.cargarEstadosAcademicos();
            cboEstadoAcademico.ValueMember = "id_estado";
            cboEstadoAcademico.DisplayMember = "descripcion";
            cboEstadoAcademico.SelectedIndex = -1;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cboEstadoAcademico.SelectedIndex == -1 || cboCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string curso = cboCursos.Text;
                string estadoAcademico = cboEstadoAcademico.Text;

                DataTable tabla = gestor.consulta4(estadoAcademico, curso);

                if (tabla.Rows.Count > 0)
                {
                    rvConsulta4.LocalReport.DataSources.Clear();
                    rvConsulta4.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta4", tabla));
                    rvConsulta4.RefreshReport();
                }
                else
                {
                    rvConsulta4.LocalReport.DataSources.Clear();
                    rvConsulta4.RefreshReport();
                    MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
