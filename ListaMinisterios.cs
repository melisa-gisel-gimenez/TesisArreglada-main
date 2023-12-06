using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.Layout.Borders;
using iText.Layout.Properties;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Collections.Generic;
using iText.Kernel.Colors;

namespace arreglarTesis
{
    public partial class MiembrosMinisterios : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public MiembrosMinisterios()
        {
            InitializeComponent();
        }

        private void CargarMinisterios()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString)) // Reemplaza cadenaConexion con tu cadena de conexión real
                {
                    string consulta = "SELECT Id_ministerio, nombreMinisterio FROM Ministerios";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    DataTable tablaMinisterios = new DataTable();
                    adaptador.Fill(tablaMinisterios);

                    // Enlazar datos al ComboBox
                    comboBoxMini.DataSource = tablaMinisterios;
                    comboBoxMini.ValueMember = "Id_ministerio";
                    comboBoxMini.DisplayMember = "nombreMinisterio";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ministerios: " + ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiembrosMinisterios_Load(object sender, EventArgs e)
        {
            CargarMinisterios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el id_ministerio seleccionado en el ComboBox
                int idMinisterioSeleccionado = Convert.ToInt32(comboBoxMini.SelectedValue);

                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    string consulta = "SELECT id_miembro AS 'Nro Miembro', Nombre, Apellido " +
                                      "FROM Miembros " +
                                      "WHERE id_ministerio = @IdMinisterio";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdMinisterio", idMinisterioSeleccionado);

                    DataTable tablaMiembros = new DataTable();
                    adaptador.Fill(tablaMiembros);

                    // Enlazar datos al DataGridView dgvmiembros
                    dgvMiembrosMini.DataSource = tablaMiembros;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar miembros: " + ex.Message);
            }
        }

        private void DescargarInformePDF()
        {
            string fechaDescarga = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Configurar SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta y el nombre de archivo seleccionados
                string filePath = saveFileDialog.FileName;

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Agregar título e información de fecha
                        document.Add(new Paragraph("Miembros Ministerio"));
                        document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                        // Agregar tabla para Mentoreados con estilo personalizado
                        document.Add(new Paragraph(""));
                        document.Add(DGVToTable(dgvMiembrosMini, true));
                    }
                }

                MessageBox.Show("Informe generado y guardado como '" + Path.GetFileName(filePath) + "'");

                // Abrir automáticamente el archivo PDF después de guardarlo
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        private Table DGVToTable(DataGridView dgv, bool isIncomeTable)
        {
            Table table = new Table(dgv.ColumnCount);

            // Configurar el color de fondo y el estilo de fuente para los encabezados de columna
            iText.Kernel.Colors.Color backgroundColor = new DeviceRgb(0, 0, 128); // Azul
            iText.Kernel.Colors.Color fontColor = iText.Kernel.Colors.ColorConstants.WHITE;

            // Configurar el estilo de fuente para los encabezados de columna
            Style headerCellStyle = new Style()
                .SetBackgroundColor(backgroundColor)
                .SetFontColor(fontColor)
                .SetBold();

            // Agregar encabezados de columna con estilo
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                Cell headerCell = new Cell().Add(new Paragraph(column.HeaderText));
                // Aplicar el estilo de encabezado
                headerCell.SetBackgroundColor((DeviceRgb)backgroundColor);
                headerCell.SetFontColor((DeviceRgb)fontColor);
                headerCell.SetBold();

                table.AddHeaderCell(headerCell);
            }

            // Agregar datos
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                }
            }

            return table;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargarInformePDF();
        }

    }
}
