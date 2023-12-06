using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglarTesis
{
    public partial class AltaCelula : Form
    {
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptador;
        private DataSet dataSet;
        public AltaCelula()
        {
            InitializeComponent();
        }

        private void ConfigurarDGV()
        {
            // Configura el DataGridView (DGV) para que no genere automáticamente las columnas.
            DGVCelulas.AutoGenerateColumns = false;

            // Crea y agrega las columnas manualmente en el orden deseado.

            // Columna id_celula
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id_celula"; // Nombre de la columna en el origen de datos
            colId.HeaderText = "Nro de Celula";
            colId.DisplayIndex = 0;
            DGVCelulas.Columns.Add(colId);

            /* olumna ID Lider
            DataGridViewTextBoxColumn colIdMentor = new DataGridViewTextBoxColumn();
            colIdMentor.DataPropertyName = "Id_liderCelula"; // Nombre de la columna en el origen de datos
            colIdMentor.HeaderText = " Lider N°";
            colIdMentor.DisplayIndex = 1;
            DGVCelulas.Columns.Add(colIdMentor);

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre"; // Nombre de la columna en el origen de datos
            colNombre.HeaderText = "Nombre";
            colNombre.DisplayIndex = 2;
            DGVCelulas.Columns.Add(colNombre);

            // Columna Apellido
            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.DataPropertyName = "Apellido"; // Nombre de la columna en el origen de datos
            colApellido.HeaderText = "Apellido";
            colApellido.DisplayIndex = 3;
            DGVCelulas.Columns.Add(colApellido);
            */

            // Columna Cantidad
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "cantidad"; // Nombre de la columna en el origen de datos
            colCantidad.HeaderText = "Cantidad de Miembros";
            colCantidad.DisplayIndex = 4;
            DGVCelulas.Columns.Add(colCantidad);


        }

        private void CargarCelulas()
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);

            /*
            string consulta = "SELECT C.id_celula,C.cantidad, L.id_liderCelula,M.Nombre,M.Apellido " +
                              "FROM (celula AS C "+                
                              "INNER JOIN LiderCelula AS L ON C.id_celula = L.id_celula) "+
                              "INNER JOIN Miembros AS M ON L.id_miembro = M.id_miembro ";
            */

            string consulta = "Select * FROM Celula;";


            // Crea un adaptador de datos para ejecutar la consulta y llenar el DataSet.
            adaptador = new OleDbDataAdapter(consulta, conexion);

            // Crea un DataSet para almacenar los datos.
            dataSet = new DataSet();

            // Abre la conexión y llena el DataSet con los datos de la tabla Miembros.
            conexion.Open();
            adaptador.Fill(dataSet, "Celula");  // Utilizando "Celula" como alias
            conexion.Close();

            try
            {
                // Enlaza el DataGridView (DGV1) con el DataSet.
                DGVCelulas.DataSource = dataSet.Tables["Celula"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enlazar datos al DataGridView: " + ex.Message);
            }
        }

        private void AltaCelula_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            CargarCelulas();
        }

        private void btnAgregarCelula_Click(object sender, EventArgs e)
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);
            conexion.Open();

            string consulta3 = "INSERT INTO Celula (cantidad) VALUES ('0');";

            OleDbCommand comando1 = new OleDbCommand(consulta3, conexion);


            int cantidad = comando1.ExecuteNonQuery();


            if (cantidad < 1)
            {
                MessageBox.Show("Ocurrió un problema");
            }
            else
            {
                MessageBox.Show("Se creo la célula con exito!");
            }
            conexion.Close();
            CargarCelulas();
        }

        private void DGVCelulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCelula.Text = DGVCelulas.Rows[DGVCelulas.CurrentRow.Index].Cells[0].Value.ToString();

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

        private void txtDNIBuscar_TextChanged_1(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = txtDNIBuscar.Text.Trim();

            if (txtDNIBuscar.Text.Length < 8 || txtDNIBuscar.Text == "")
            {
                MessageBox.Show("El DNI debe tener 8 dígitos. Por favor, revise los datos ingresados.");
            }
            else
            {
                if (!string.IsNullOrEmpty(dniABuscar))
                {
                    string consulta2 = "SELECT * FROM miembros WHERE DNI = @DNI";

                    // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
                    string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

                    using (OleDbConnection conexion = new OleDbConnection(connectionString))
                    {
                        conexion.Open();

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
                                    txtIdMiembro.Text = reader2["id_miembro"].ToString();
                                    txtEtapa.Text = reader2["id_etapaespiritual"].ToString();
                                    txtRol2.Text = reader2["id_rol2"].ToString();



                                    // Verificar las condiciones adicionales
                                    int idEtapaEspiritual = Convert.ToInt32(reader2["id_etapaespiritual"]);
                                    int idRol2 = Convert.ToInt32(reader2["id_rol2"]);

                                    if (idEtapaEspiritual > 1 && idRol2 == 0)
                                    {
                                        btnAltaLider.Enabled = true;
                                    }

                                    if (idEtapaEspiritual > 1 && idRol2 > 0)
                                    {
                                        btnAltaLider.Enabled = false;
                                        MessageBox.Show("La persona ya es lider de una celula. Elija otro miembro por favor");
                                    }

                                    if (idEtapaEspiritual < 2)
                                    {
                                        btnAltaLider.Enabled = false;
                                        MessageBox.Show("La persona no tiene el rango suficiente. Por favor elija otro miembro.");
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("No se encontro una persona que cumpla con las condiciones indicada. Verifique los datos.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                            }
                        }
                    } // La conexión se cerrará automáticamente al salir del bloque using
                }
            }
        }



        /* codigo q funciona anterior
        private void btnBuscar_Click(object sender, EventArgs e)
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
                    string consulta2 = "SELECT * FROM miembros WHERE DNI = @DNI";

                    
                    // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
                    string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

                    using (OleDbConnection conexion = new OleDbConnection(connectionString))
                    {
                        conexion.Open();

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
                                    txtIdMiembro.Text = reader2["id_miembro"].ToString();
                                    btnAltaLider.Enabled = true;
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
                    } // La conexión se cerrará automáticamente al salir del bloque using
                }
            }
        }
        */

        private void btnAltaLider_Click(object sender, EventArgs e)
        {
            // Verifica que ambos TextBox tengan valores
            if (!string.IsNullOrEmpty(txtIdCelula.Text) && !string.IsNullOrEmpty(txtIdMiembro.Text))
            {
                // Convierte los valores de los TextBox a tipos adecuados (puede ser int u otro tipo según la estructura de tus tablas)
                int idCelula = Convert.ToInt32(txtIdCelula.Text);
                int idMiembro = Convert.ToInt32(txtIdMiembro.Text);

                // Establece la cadena de conexión
                string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Define la consulta de inserción
                    string consultaInsertar = "INSERT INTO LiderCelula (Id_celula, Id_miembro) VALUES (@IdCelula, @IdMiembro)";

                    // Crea y configura el comando con los parámetros necesarios
                    using (OleDbCommand comandoInsertar = new OleDbCommand(consultaInsertar, conexion))
                    {
                        comandoInsertar.Parameters.AddWithValue("@IdCelula", idCelula);
                        comandoInsertar.Parameters.AddWithValue("@IdMiembro", idMiembro);

                        try
                        {
                            // Abre la conexión, ejecuta la consulta de inserción y cierra la conexión
                            conexion.Open();
                            int filasAfectadas = comandoInsertar.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Se asignó el líder de la célula con éxito.");

                                // Ahora, actualizamos la cantidad en la tabla Celula
                                string consultaActualizarCelula = "UPDATE Celula SET cantidad = cantidad + 1 WHERE Id_celula = @IdCelula";

                                using (OleDbCommand comandoActualizarCelula = new OleDbCommand(consultaActualizarCelula, conexion))
                                {
                                    comandoActualizarCelula.Parameters.AddWithValue("@IdCelula", idCelula);

                                    int filasAfectadasActualizarCelula = comandoActualizarCelula.ExecuteNonQuery();

                                    if (filasAfectadasActualizarCelula > 0)
                                    {
                                        MessageBox.Show("Se actualizó la cantidad en la tabla Celula con éxito.");
                                        CargarCelulas();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar la cantidad en la tabla Celula.");
                                    }
                                }
                            }

                            else
                            {
                                MessageBox.Show("No se pudo asignar el líder de la célula. Verifica los datos e intenta nuevamente.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al asignar líder de la célula: " + ex.Message);
                        }
                        finally
                        {
                            conexion.Close();
                            ActualizarTablaMiembros();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los valores de Id Celula e Id Miembro.");
            }
        }

        private void ActualizarTablaMiembros()
        {
            int idCelula = Convert.ToInt32(txtIdCelula.Text);
            int idMiembro = Convert.ToInt32(txtIdMiembro.Text);
            // Establece la cadena de conexión

            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Establece la consulta para actualizar la tabla Miembros
                    string consultaActualizarMiembros = "UPDATE Miembros SET id_celula = @IdCelula, id_rol2 = 1 " +
                              "WHERE id_miembro = @IdMiembro";

                    // Crea y configura el comando con los parámetros necesarios
                    using (OleDbCommand comandoActualizarMiembros = new OleDbCommand(consultaActualizarMiembros, conexion))
                    {
                        comandoActualizarMiembros.Parameters.AddWithValue("@IdCelula", idCelula);
                        comandoActualizarMiembros.Parameters.AddWithValue("@IdMiembro", idMiembro);

                        // Abre la conexión, ejecuta la consulta de actualización y cierra la conexión
                        conexion.Open();
                        int filasAfectadasActualizarMiembros = comandoActualizarMiembros.ExecuteNonQuery();

                        if (filasAfectadasActualizarMiembros > 0)
                        {
                            MessageBox.Show("Se actualizó la tabla Miembros con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la tabla Miembros.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tabla Miembros: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaMiembrosCelula form1 = new ListaMiembrosCelula();
            form1.ShowDialog();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNIBuscar.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

        }
    }

}


