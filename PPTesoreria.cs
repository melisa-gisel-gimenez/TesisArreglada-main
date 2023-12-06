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
    public partial class PPTesoreria : Form
    {
        public PPTesoreria()
        {
            InitializeComponent();
        }

        private void generarInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeTesoreria form1 = new InformeTesoreria();
            form1.ShowDialog();

        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AcercaDe Form1 = new AcercaDe();
            Form1.ShowDialog();
        }



        private void agregarIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngresos Form1 = new AgregarIngresos();
            Form1.ShowDialog();
        }

        private void agregarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEgresos Form1 = new AgregarEgresos();
            Form1.ShowDialog();
        }

        private void PPTesoreria_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void PPTesoreria_Load(object sender, EventArgs e)
        {
            this.FormClosed += PPTesoreria_FormClosed;
        }

        private void PPTesoreria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
