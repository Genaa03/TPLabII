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
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los autores de este proyecto son:\n\n• Freccia, Genaro Farid\n• Bergoglio, Felipe" +
                "\n• Cepeda, German\n• Virga, Santos José\n• Cuello, Cristian Santiago", "AUTORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerInstancia().Hide();
            FormConsulta1B.ObtenerInstancia().ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
