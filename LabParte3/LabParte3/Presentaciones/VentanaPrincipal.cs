using LabParte3.Presentaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabParte3
{
    public partial class VentanaPrincipal : Form
    {
        private static VentanaPrincipal instancia;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public static VentanaPrincipal ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new VentanaPrincipal();
            }
            return instancia;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los autores de este proyecto son:\n\n• Freccia, Genaro Farid\n• Bergoglio, Felipe" +
                "\n• Cepeda, German\n• Virga, Santos José\n• Cuello, Cristian Santiago", "AUTORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta1.ObtenerInstancia().ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta3.ObtenerInstancia().ShowDialog();
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta2.ObtenerInstancia().ShowDialog();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta6.ObtenerInstancia().ShowDialog();
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta4.ObtenerInstancia().ShowDialog();
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta5.ObtenerInstancia().ShowDialog();
        }

        private void consulta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta7.ObtenerInstancia().ShowDialog();
        }

        private void consulta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta8.ObtenerInstancia().ShowDialog();
        }
    }
}
