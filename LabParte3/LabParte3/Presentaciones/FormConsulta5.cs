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
    public partial class FormConsulta5 : Form
    {
        private static FormConsulta5 instancia;
        private Gestor gestor;
        public FormConsulta5()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        public static FormConsulta5 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormConsulta5();
            }
            return instancia;
        }

        private void FormConsulta5_Load(object sender, EventArgs e)
        {
            cargarTecnicaturas();
        }

        private void cargarTecnicaturas()
        {
            cboTecnicaturas.DataSource = gestor.cargarTecnicaturas();
            cboTecnicaturas.ValueMember = "id_tecnicatura";
            cboTecnicaturas.DisplayMember = "descripcion";
            cboTecnicaturas.SelectedIndex = -1;
        }

        private void cargarMaterias(int idTec)
        {
            if((int)cboTecnicaturas.SelectedValue == 6)
            {
                cboMaterias.DataSource = gestor.cargarTodasMaterias();
            }
            else
            {
                cboMaterias.DataSource = gestor.cargarMaterias(idTec);
            }

            cboMaterias.ValueMember = "id_materia";
            cboMaterias.DisplayMember = "nombre_materia";
            cboMaterias.SelectedIndex = -1;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ObtenerInstancia().Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void cboTecnicaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTecnicaturas.SelectedIndex != -1)
            {
                cargarMaterias((int)cboTecnicaturas.SelectedValue);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cboTecnicaturas.SelectedIndex == -1 || cboMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int IdMateria = (int)cboMaterias.SelectedValue;

                DataTable tabla = gestor.consulta5(IdMateria);

                if (tabla.Rows.Count > 0)
                {
                    rvConsulta5.LocalReport.DataSources.Clear();
                    rvConsulta5.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Consulta5", tabla));
                    rvConsulta5.RefreshReport();
                }
                else
                {
                    rvConsulta5.LocalReport.DataSources.Clear();
                    rvConsulta5.RefreshReport();
                    MessageBox.Show("No se encontraron resultados.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
