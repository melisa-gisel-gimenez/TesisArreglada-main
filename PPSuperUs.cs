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
    public partial class PPSuperUs : Form
    {
        public PPSuperUs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reunionesDeMentoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroReunionesMentor Form1 = new RegistroReunionesMentor();
            Form1.ShowDialog();
        }

        private void postulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostularADiscipulado Form1 = new PostularADiscipulado();
            Form1.ShowDialog();
        }

        private void PPSuperUs_Load(object sender, EventArgs e)
        {
            this.FormClosed += PPSuperUs_FormClosed;
        }

        private void PPSuperUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PPSuperUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inhabilitarMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InhabilitarPersonas Form1 = new InhabilitarPersonas();
            Form1.ShowDialog();
        }

        private void asignarMentorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarMentor Form1 = new AsignarMentor();
            Form1.ShowDialog();
        }

        private void listaDeMentoreadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMentoreados form1 = new ListaMentoreados();
            form1.ShowDialog();
        }

        private void altaDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonas Form1 = new AgregarPersonas();
            Form1.ShowDialog();
        }

        private void modificacionDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Personas form1 = new Modificar_Personas();
            form1.ShowDialog();
        }

        private void altaDeCélulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCelula form1 = new AltaCelula();
            form1.ShowDialog();
        }

        private void registroDeMiembrosEnCelulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarMiembrosCelula form1 = new AsignarMiembrosCelula();
            form1.ShowDialog();
        }

        private void listaDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembros form1 = new ListaMiembros();
            form1.ShowDialog();
        }

        private void listaDeCélulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembrosCelula form1 = new ListaMiembrosCelula();
            form1.ShowDialog();
        }

        private void asignarMentorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AsignarMentor form1 = new AsignarMentor();
            form1.ShowDialog();
        }

        private void modificarMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarMentor form1 = new ModificarMentor();
            form1.ShowDialog();
        }

        private void altaMentorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMentores form1 = new AltaMentores();
            form1.ShowDialog();
        }

        private void altaUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarios form1 = new AltaUsuarios();
            form1.ShowDialog();
        }

        private void revisarPostulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostulacionesRevisar form1 = new PostulacionesRevisar();
            form1.ShowDialog();
        }

        private void inhabilitarhabilitarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InhabilitarPersonas form1 = new InhabilitarPersonas();
            form1.ShowDialog();
        }

        private void altaDeMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMinisterios form1 = new AltaMinisterios();  
            form1.ShowDialog();
        }

        private void listaMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembros form1 = new ListaMiembros();
            form1.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMiembrosCelula form1 = new ListaMiembrosCelula();
            form1.ShowDialog();
        }

        private void listaMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiembrosMinisterios form1 = new MiembrosMinisterios();
            form1.ShowDialog();
        }

        private void reunionesDeMentoriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroReunionesMentor form1 = new RegistroReunionesMentor();
            form1.ShowDialog();
        }

        private void postulacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PostularADiscipulado form1 = new PostularADiscipulado();
            form1.ShowDialog();
        }

        private void agregarIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngresos form1 = new AgregarIngresos();
            form1.ShowDialog();
        }

        private void agregarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEgresos form1 = new AgregarEgresos();
            form1.ShowDialog();
        }

        private void generarInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeTesoreria form1 = new InformeTesoreria();
            form1.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe form1 = new AcercaDe();
            form1.ShowDialog();
        }
    }
}
