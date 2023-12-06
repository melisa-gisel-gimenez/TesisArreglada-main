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
    public partial class ListaMiembrosCelula : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public ListaMiembrosCelula()
        {
            InitializeComponent();
        }

        private void ListaMiembrosCelula_Load(object sender, EventArgs e)
        {
            CargarIdCelulaEnComboBox();
        }

        private void CargarIdCelulaEnComboBox()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Consulta para obtener los id_celula desde la tabla Celula
                    string consulta = "SELECT id_celula FROM Celula";

                    // Crear el adaptador de datos y el DataSet
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla Celula
                    conexion.Open();
                    adaptador.Fill(dataSet, "Celula");
                    conexion.Close();

                    // Enlazar los datos al ComboBox
                    comboIdCelula.DataSource = dataSet.Tables["Celula"];
                    comboIdCelula.DisplayMember = "id_celula";
                    comboIdCelula.ValueMember = "id_celula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los id_celula: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtén el id_celula seleccionado en el ComboBox
            int idCelulaSeleccionado = Convert.ToInt32(comboIdCelula.SelectedValue);

            // Realiza la búsqueda en la tabla Miembros según el id_celula
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Consulta para obtener los registros de Miembros con el id_celula específico
                    string consulta = "SELECT id_miembro AS 'Nro Miembro', Nombre, Apellido " +
                                      "FROM Miembros " +
                                      "WHERE id_celula = @IdCelula";

                    // Crear el adaptador de datos y el DataSet
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdCelula", idCelulaSeleccionado);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla Miembros
                    conexion.Open();
                    adaptador.Fill(dataSet, "Miembros");
                    conexion.Close();

                    // Enlazar los datos al DataGridView dgvmiembros
                    dgvmiembros.DataSource = dataSet.Tables["Miembros"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la tabla Miembros: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        document.Add(new Paragraph("Miembros Celula"));
                        document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                        // Agregar tabla para Miembros con estilo personalizado
                        document.Add(new Paragraph(""));
                        document.Add(DGVToTable(dgvmiembros, true));
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

