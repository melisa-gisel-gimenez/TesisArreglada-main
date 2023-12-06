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
    public partial class InformeTesoreria : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public InformeTesoreria()
        {
            InitializeComponent();

        }
        private void CargarDatosIngresos(DateTime fechaDesde, DateTime fechaHasta)
        {
            //string consulta = "SELECT * FROM Ingresos WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";
            string consulta = "SELECT I.Id_ingreso as 'Nro Ingreso', I.fecha as Fecha, I.id_tipoIngreso as 'Codigo', T.tipo_ingreso as 'Tipo Ingreso', I.detalle AS Detalle, I.monto AS Monto " +
                "FROM Ingresos I " +
                "INNER JOIN TipoIngreso T ON I.id_tipoIngreso = T.Id_tipoIngreso " +
                "WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    try
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);
                        DGVIngresos.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
        }

        private void CargarDatosEgresos(DateTime fechaDesde, DateTime fechaHasta)
        {
            //string consulta = "SELECT * FROM Egresos WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";
            //string consulta = "SELECT Id_egreso as 'Nro Egreso', fecha as Fecha, Id_tipoEgreso as 'Codigo tipo Egreso',  detalle AS Detalle, monto AS Monto FROM Egresos WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";
            string consulta = "SELECT E.Id_egreso as 'Nro Egreso', E.fecha as Fecha, E.Id_tipoEgreso as 'Codigo', T.tipo_Egreso as 'Tipo Egreso', E.detalle AS Detalle, E.monto AS Monto " +
                "FROM Egresos E " +
                "INNER JOIN TipoEgreso T ON E.Id_tipoEgreso = T.Id_tipoEgreso " +
                "WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    try
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);
                        DGVEgresos.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimePickerDesde.Value;
            DateTime fechaHasta = dateTimePickerHasta.Value;


            // Asegurarse de que la fecha hasta sea mayor o igual a la fecha desde
            if (fechaHasta <= fechaDesde)
            {
                MessageBox.Show("La fecha hasta debe ser mayor a la fecha desde.");
                return;
            }


            // Filtrar los datos con las fechas seleccionadas
            CargarDatosIngresos(fechaDesde, fechaHasta);
            CargarDatosEgresos(fechaDesde, fechaHasta);

            btnDescargar.Enabled = true;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargarInformePDF();
        }

        private void DescargarInformePDF()
        {
            string fechaDescarga = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Configurar SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF|*.pdf",
                Title = "Guardar Informe de Tesorería",
                FileName = "InformeTesoreria_" + fechaDescarga.Replace(":", "").Replace(" ", "_") + ".pdf"
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
                        document.Add(new Paragraph("Informe de Tesorería"));
                        document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                        // Agregar tabla para Ingresos con estilo personalizado
                        document.Add(new Paragraph("Ingresos"));
                        document.Add(DGVToTable(DGVIngresos, true));

                        // Agregar tabla para Egresos sin estilo adicional
                        document.Add(new Paragraph("Egresos"));
                        document.Add(DGVToTable(DGVEgresos, false));



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
            iText.Kernel.Colors.Color backgroundColor;
            if (isIncomeTable)
            {
                // Para la tabla de ingresos
                backgroundColor = new DeviceRgb(0, 128, 0); // Verde
            }
            else
            {
                // Para la tabla de egresos
                backgroundColor = new DeviceRgb(255, 0, 0); // Rojo
            }

            iText.Kernel.Colors.Color fontColor = iText.Kernel.Colors.ColorConstants.WHITE;

            // Configurar el estilo de fuente para los encabezados de columna
            Style headerCellStyle = new Style()
                .SetBackgroundColor(backgroundColor)
                .SetFontColor(fontColor)
                .SetBold();

            // Agregar encabezados de columna
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

        /*
        private Table DGVToTable(DataGridView dgv, bool isIncomeTable)
        {
            Table table = new Table(dgv.ColumnCount);

            // Configurar el color de fondo y el estilo de fuente para los encabezados de columna de ingresos
            iText.Kernel.Colors.Color backgroundColor = new DeviceRgb(0, 128, 0);
            iText.Kernel.Colors.Color fontColor = iText.Kernel.Colors.ColorConstants.WHITE;

            // Configurar el estilo de fuente para los encabezados de columna de ingresos
            Style headerCellStyle = new Style()
                .SetBackgroundColor(backgroundColor)
                .SetFontColor(fontColor)
                .SetBold();

            // Agregar encabezados de columna
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                Cell headerCell = new Cell().Add(new Paragraph(column.HeaderText));

                // Aplicar el estilo de encabezado solo para la tabla de ingresos
                if (isIncomeTable)
                {
                    headerCell.SetBackgroundColor((DeviceRgb)backgroundColor);
                    headerCell.SetFontColor((DeviceRgb)fontColor);
                    headerCell.SetBold();
                }

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
        */


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerHasta.Enabled = true;

        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
        }
    }


}


/* codigo viejo
private void DescargarInformePDF()
{
    string fechaDescarga = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    // Configurar SaveFileDialog
    SaveFileDialog saveFileDialog = new SaveFileDialog
    {
        Filter = "Archivos PDF|*.pdf",
        Title = "Guardar Informe de Tesorería",
        FileName = "InformeTesoreria_" + fechaDescarga.Replace(":", "").Replace(" ", "_") + ".pdf"
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
                document.Add(new Paragraph("Informe de Tesorería"));
                document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                // Agregar tabla para Ingresos
                document.Add(new Paragraph("Ingresos"));
                document.Add(DGVToTable(DGVIngresos));

                // Agregar tabla para Egresos
                document.Add(new Paragraph("Egresos"));
                document.Add(DGVToTable(DGVEgresos));                                                


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
*/


/* codigo viejo
private Table DGVToTable(DataGridView dgv)
{
    Table table = new Table(dgv.ColumnCount);

    // Agregar encabezados de columna
    foreach (DataGridViewColumn column in dgv.Columns)
    {
        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
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


private void btnSalir_Click(object sender, EventArgs e)
{
    this.Close();
}
}
}
*/
