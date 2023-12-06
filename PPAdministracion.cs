using Iglesia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglarTesis
{
    public partial class PPAdministracion : Form
    {
        public PPAdministracion()
        {
            InitializeComponent();
        }

        private void mentoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonas Form1 = new AgregarPersonas();
            Form1.ShowDialog();
        }



        private void modificarPersonasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Modificar_Personas form1 = new Modificar_Personas();
            form1.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AcercaDe form1 = new AcercaDe();
            form1.ShowDialog();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembros Form1 = new ListaMiembros();
            Form1.ShowDialog();
        }

        private void PPAdministracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PPAdministracion_Load(object sender, EventArgs e)
        {
            this.FormClosed += PPAdministracion_FormClosed;
        }

        private void PPAdministracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registrarMiembrosDeCelulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCelula form1 = new AltaCelula();
            form1.ShowDialog();
        }

        private void listaDeMiembrosPorCelulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembrosCelula form = new ListaMiembrosCelula();
            form.ShowDialog();
        }

        private void listaMiembrosPorMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiembrosMinisterios form = new MiembrosMinisterios();
            form.ShowDialog();
        }

        private void asignarMiembrosACelulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarMiembrosCelula form1 = new AsignarMiembrosCelula();
            form1.ShowDialog();
        }
    }
}

