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
    public partial class AsignarMiembrosCelula : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public AsignarMiembrosCelula()
        {
            InitializeComponent();
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

                        string consulta2 = "SELECT * FROM miembros WHERE DNI = @DNI";
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
                                    txtIdCelula.Text = reader2["id_celula"].ToString();
                                    // Lee el valor del campo "inhabilitado"
                                    bool inhabilitado = Convert.ToBoolean(reader2["inhabilitado"]);

                                    // Establece el estado de los CheckBox según el valor de "inhabilitado"
                                    checkBoxInhabilitado.Checked = inhabilitado;

                                    int idCelula = Convert.ToInt32(reader2["id_celula"]);

                                    if (idCelula > 0)
                                    {
                                        MessageBox.Show("Esta persona ya pertenece a una celula. Por favor verifique el DNI ingresado");
                                    }
                                    else
                                    {
                                        if (checkBoxInhabilitado.Checked == true)
                                        {
                                            MessageBox.Show("No puede asignar a una persona inhabilitada. Consulte con Administración o verifique el DNI ingresado");
                                        }
                                        else
                                        {
                                            comboBoxCelula.Enabled = true;
                                            buttonAceptar.Enabled = true;
                                        }

                                    }




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

        private void CargarIdCelulaEnComboBox()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
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
                    comboBoxCelula.DataSource = dataSet.Tables["Celula"];
                    comboBoxCelula.DisplayMember = "id_celula";
                    comboBoxCelula.ValueMember = "id_celula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los id_celula: " + ex.Message);
            }
        }



        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            ActualizarTablaMiembros();
            actualizarCantidadCelula();
        }

        private void ActualizarTablaMiembros()
        {
            // Obtén el id_celula seleccionado en el ComboBox
            int idCelulaSeleccionado = Convert.ToInt32(comboBoxCelula.SelectedValue);
            int idMiembro = Convert.ToInt32(txtIdMiembro.Text);
            // Establece la cadena de conexión

            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Establece la consulta para actualizar la tabla Miembros
                    string consultaActualizarMiembros = "UPDATE Miembros SET id_celula = @IdCelula " +
                              "WHERE id_miembro = @IdMiembro";

                    // Crea y configura el comando con los parámetros necesarios
                    using (OleDbCommand comandoActualizarMiembros = new OleDbCommand(consultaActualizarMiembros, conexion))
                    {
                        comandoActualizarMiembros.Parameters.AddWithValue("@IdCelula", idCelulaSeleccionado);
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

        private void buttonListaCelula_Click_1(object sender, EventArgs e)
        {
            ListaMiembrosCelula form1 = new ListaMiembrosCelula();
            form1.ShowDialog();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            txtDNIBuscar.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIdMiembro.Text = "";
            txtIdCelula.Text = "";
            checkBoxInhabilitado.Checked = false;
        }

        private void AsignarMiembrosCelula_Load_1(object sender, EventArgs e)
        {
            CargarIdCelulaEnComboBox();
        }

        private void actualizarCantidadCelula()
        {
            int idCelulaSeleccionado = Convert.ToInt32(comboBoxCelula.SelectedValue);

            // Establece la cadena de conexión
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Ahora, actualizamos la cantidad en la tabla Celula
            string consultaActualizarCelula = "UPDATE Celula SET cantidad = cantidad + 1 WHERE Id_celula = @IdCelula";

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                using (OleDbCommand comandoActualizarCelula = new OleDbCommand(consultaActualizarCelula, conexion))
                {
                    comandoActualizarCelula.Parameters.AddWithValue("@IdCelula", idCelulaSeleccionado);

                    try
                    {
                        conexion.Open();

                        int filasAfectadasActualizarCelula = comandoActualizarCelula.ExecuteNonQuery();

                        if (filasAfectadasActualizarCelula > 0)
                        {
                            MessageBox.Show("Se actualizó la cantidad en la tabla Celula con éxito.");
                            //CargarCelulas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la cantidad en la tabla Celula.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la cantidad en la tabla Celula: " + ex.Message);
                    }
                }
            }
        }

    }
}
           
    

