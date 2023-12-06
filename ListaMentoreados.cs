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
    public partial class ListaMentoreados : Form
    {

        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public ListaMentoreados()
        {
            InitializeComponent();
        }

        private void ListaMentoreados_Load(object sender, EventArgs e)
        {

        }

        private void txtDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDNIBuscar_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (txtDNIBuscar.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                txtDNIBuscar.SelectionStart = txtDNIBuscar.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = txtDNIBuscar.Text.Trim();
            if (txtDNIBuscar.Text.Length < 8 || txtDNIBuscar.Text == "")
            {
                MessageBox.Show("El DNI debe tener 8 dígitos. Por favor revise los datos ingresados.");
            }
            else
            {

                if (!string.IsNullOrEmpty(dniABuscar))
                {
                    using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                    {
                        conexion.Open();

                        string consulta2 = "SELECT * FROM mentores WHERE DNI_MENTOR = @DNI";
                        using (OleDbCommand comando2 = new OleDbCommand(consulta2, conexion))
                        {
                            comando2.Parameters.AddWithValue("@DNI", dniABuscar);
                            try
                            {
                                OleDbDataReader reader2 = comando2.ExecuteReader();
                                if (reader2.Read())
                                {
                                    txtNombre.Text = reader2["NOMBRE"].ToString();
                                    txtApellido.Text = reader2["APELLIDO"].ToString();
                                    txtIdMentor.Text = reader2["id_mentor"].ToString();
                                    btnCargar.Enabled = true;

                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna persona registrada con el DNI proporcionado.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int idMentor = Convert.ToInt32(txtIdMentor.Text);


            // Realiza la búsqueda en la tabla Miembros según el id_celula
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // Consulta para obtener los registros de Miembros con el id_celula específico
                    string consulta = "SELECT id_miembro AS 'Nro Miembro', Nombre, Apellido " +
                                      "FROM Miembros " +
                                      "WHERE id_mentor = @id_mentor";

                    // Crear el adaptador de datos y el DataSet
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@id_mentor", idMentor);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla Miembros
                    conexion.Open();
                    adaptador.Fill(dataSet, "Miembros");
                    conexion.Close();

                    // Enlazar los datos al DataGridView dgvmiembros
                    dgvMentoreados.DataSource = dataSet.Tables["Miembros"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la tabla Miembros: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIdMentor.Text = "";
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
                        document.Add(new Paragraph("Mentoreados"));
                        document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                        // Agregar tabla para Mentoreados con estilo personalizado
                        document.Add(new Paragraph(""));
                        document.Add(DGVToTable(dgvMentoreados, true));
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
