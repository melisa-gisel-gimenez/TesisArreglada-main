using arreglarTesis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    public partial class paginaprincipal : Form
    {
        public paginaprincipal()
        {
            InitializeComponent();
        }

        private void agregarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonas Form1 = new AgregarPersonas();
            Form1.ShowDialog();
        }

        private void modificarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Personas Form1 = new Modificar_Personas();
            Form1.ShowDialog();
        }

        private void inhabilitarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InhabilitarPersonas Form1 = new InhabilitarPersonas();
            Form1.ShowDialog();
        }

        private void asignarMentorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AsignarMentor Form1 = new AsignarMentor();
            Form1.ShowDialog();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarios Form1 = new AltaUsuarios();
            Form1.ShowDialog();
        }

        private void revisarPostuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostulacionesRevisar Form1 = new PostulacionesRevisar();
            Form1.ShowDialog();

        }

        private void altaMentoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMentores Form1 = new AltaMentores();
            Form1.ShowDialog();
        }

        private void modificarMentoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarMentor Form1 = new ModificarMentor();
            Form1.ShowDialog();
        }

        private void altaMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMinisterios Form1 = new AltaMinisterios();
            Form1.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe Form1 = new AcercaDe();
            Form1.ShowDialog();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembros Form1 = new ListaMiembros();
            Form1.ShowDialog();
        }

        private void paginaprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void paginaprincipal_Load(object sender, EventArgs e)
        {
            this.FormClosed += paginaprincipal_FormClosed;
        }

        private void paginaprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listaMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiembrosMinisterios form = new MiembrosMinisterios();
            form.ShowDialog();
        }

        private void listaMentoreadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMentoreados form1 = new ListaMentoreados();
            form1.ShowDialog();
        }
    }
}
