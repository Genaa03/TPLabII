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
    public partial class FormConsulta1 : Form
    {
        private static FormConsulta1 instancia;
        private Gestor gestor;
        public FormConsulta1()
        {
            gestor = new Gestor();
            InitializeComponent();
        }

        private void FormConsulta1B_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.MaxDate = DateTime.Today;
            dtpFechaHasta.MaxDate = DateTime.Today;
            cargarCombos();
            this.rvConsulta1.RefreshReport();
            this.rvConsulta1.RefreshReport();
        }

        private void cargarCombos()
        {
            cboTecnicaturas.DataSource = gestor.cargarTecnicaturas();
            cboTecnicaturas.DisplayMember = "descripcion";
            cboTecnicaturas.ValueMember = "id_tecnicatura";
            cboTecnicaturas.SelectedIndex = -1;

            cboTipoExamen.DataSource = gestor.cargarTiposDeExamenes();
            cboTipoExamen.DisplayMember = "descripcion";
            cboTipoExamen.ValueMember = "id_tipo_examen";
            cboTipoExamen.SelectedIndex = -1;
        }

        public static FormConsulta1 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta1();
            }
            return instancia;
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            if(cboTecnicaturas.SelectedIndex == -1 || cboTipoExamen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("La fecha desde es mayor que la de hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tabla = new DataTable();

                DateTime fechaDesde = Convert.ToDateTime(dtpFechaDesde.Value.ToString());
                DateTime fechaHasta = Convert.ToDateTime(dtpFechaHasta.Value.ToString());
                string tecnicatura = cboTecnicaturas.Text;
                string tipoExamen = cboTipoExamen.Text;

                if(cboTecnicaturas.Text == "Todas")
                {
                    tabla = gestor.consulta1_todos_tec(tipoExamen, fechaDesde, fechaHasta);
                }
                if (cboTipoExamen.Text == "Todos")
                {
                    tabla = gestor.consulta1_todos_ex(tecnicatura, fechaDesde, fechaHasta);
                }
                if (cboTecnicaturas.Text == "Todas" && cboTipoExamen.Text == "Todos")
                {
                    tabla = gestor.consulta1_todos(fechaDesde, fechaHasta);
                }
                if (cboTecnicaturas.Text != "Todas" && cboTipoExamen.Text != "Todos")
                {
                    tabla = gestor.consulta1(tipoExamen,tecnicatura,fechaDesde, fechaHasta);
                }




                if (tabla.Rows.Count > 0)
                {
                    rvConsulta1.LocalReport.DataSources.Clear();
                    rvConsulta1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsConsulta11Reporte", tabla));
                    rvConsulta1.RefreshReport();
                }
                else
                {
                    rvConsulta1.LocalReport.DataSources.Clear();
                    rvConsulta1.RefreshReport();
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
