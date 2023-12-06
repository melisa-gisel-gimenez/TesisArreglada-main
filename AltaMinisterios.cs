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

namespace Iglesia
{
    public partial class AltaMinisterios : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        private OleDbDataAdapter adaptador;
        private DataSet dataSet;
        public AltaMinisterios()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
            CargarMinisterios();
        }

        private void CargarMinisterios()
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);

            // Define la consulta SQL para seleccionar los registros con ID_Mentor vacío.
            string consulta = "SELECT id_ministerio AS Nro_Ministerio, nombreMinisterio AS Nombre_Ministerio FROM ministerios";

            // Crea un adaptador de datos para ejecutar la consulta y llenar el DataSet.
            adaptador = new OleDbDataAdapter(consulta, conexion);

            // Crea un DataSet para almacenar los datos.
            dataSet = new DataSet();

            // Abre la conexión y llena el DataSet con los datos de la tabla Miembros.
            conexion.Open();
            adaptador.Fill(dataSet, "Ministerios");
            conexion.Close();

            // Enlaza el DataGridView (DGV1) con el DataSet.
            DGVMini.DataSource = dataSet.Tables["Ministerios"];
        }
        private void buttonCrearMinisterio_Click(object sender, EventArgs e)
        {
            if (textBoxNombreMini.Text == "")
            {
                MessageBox.Show("Por favor, escriba un nombre para el Ministerio que quiere crear. No debe quedar el campo vacío.");
            }
            else
            {

                string consulta = "INSERT INTO Ministerios (nombreMinisterio) VALUES ('" + textBoxNombreMini.Text + "');";

                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                conexion.Open();

                int cantidad3 = comando.ExecuteNonQuery();

                if (cantidad3 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro el nuevo Ministerio correctamente");
                }
                conexion.Close();
                CargarMinisterios();

            }
        }

        private void txtDNIBuscar_TextChanged(object sender, EventArgs e)
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

        private void txtDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }




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

                    // No necesitas abrir la conexión aquí
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
                                    txtRoli.Text = reader2["id_roli"].ToString();



                                    // Verificar las condiciones adicionales
                                    int idEtapaEspiritual = Convert.ToInt32(reader2["id_etapaespiritual"]);
                                    int idRoli = Convert.ToInt32(reader2["id_roli"]);

                                    if (idEtapaEspiritual > 1 && idRoli == 0)
                                    {
                                        btnAsignarLider.Enabled = true;
                                    }

                                    if (idEtapaEspiritual > 1 && idRoli > 0)
                                    {
                                        btnAsignarLider.Enabled = false;
                                        MessageBox.Show("La persona ya es lider de un ministerio. Elija otro miembro por favor");
                                    }

                                    if (idEtapaEspiritual < 2)
                                    {
                                        btnAsignarLider.Enabled = false;
                                        MessageBox.Show("La persona no tiene el rango suficiente. Por favor elija otro miembro.");
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
                    } // La conexión se cerrará automáticamente al salir del bloque using
                }
            }
        }



        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreMini.Text = string.Empty;
        }



        private void textBoxNombreMini_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            buttonCrearMinisterio.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGVMini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMinisterio.Text = DGVMini.Rows[DGVMini.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void btnAsignarLider_Click(object sender, EventArgs e)
        {
            // Verifica que ambos TextBox tengan valores
            if (!string.IsNullOrEmpty(txtIdMinisterio.Text) && !string.IsNullOrEmpty(txtIdMiembro.Text))
            {
                // Convierte los valores de los TextBox a tipos adecuados (puede ser int u otro tipo según la estructura de tus tablas)
                int idministerio = Convert.ToInt32(txtIdMinisterio.Text);
                int idMiembro = Convert.ToInt32(txtIdMiembro.Text);

                // Establece la cadena de conexión
                string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Define la consulta de inserción
                    string consultaInsertar = "INSERT INTO lideresMinisterios (id_ministerio, Id_miembro) VALUES (@id_ministerio, @IdMiembro)";

                    // Crea y configura el comando con los parámetros necesarios
                    using (OleDbCommand comandoInsertar = new OleDbCommand(consultaInsertar, conexion))
                    {
                        comandoInsertar.Parameters.AddWithValue("@id_ministerio", idministerio);
                        comandoInsertar.Parameters.AddWithValue("@IdMiembro", idMiembro);

                        try
                        {
                            // Abre la conexión, ejecuta la consulta de inserción y cierra la conexión
                            conexion.Open();
                            int filasAfectadas = comandoInsertar.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Se asignó el líder del ministerio con éxito.");


                            }

                            else
                            {
                                MessageBox.Show("No se pudo asignar el líder al ministerio. Verifica los datos e intenta nuevamente.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al asignar líder al ministerio: " + ex.Message);
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
                MessageBox.Show("Por favor, ingrese los valores de Id ministerio e Id Miembro.");
            }
        }

        private void ActualizarTablaMiembros()
        {
            int idministerio = Convert.ToInt32(txtIdMinisterio.Text);
            int idMiembro = Convert.ToInt32(txtIdMiembro.Text);
            // Establece la cadena de conexión

            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Establece la consulta para actualizar la tabla Miembros
                    string consultaActualizarMiembros = "UPDATE Miembros SET id_ministerio = @id_ministerio, id_roli = 2  " +
                              "WHERE id_miembro = @IdMiembro";

                    // Crea y configura el comando con los parámetros necesarios
                    using (OleDbCommand comandoActualizarMiembros = new OleDbCommand(consultaActualizarMiembros, conexion))
                    {
                        comandoActualizarMiembros.Parameters.AddWithValue("@id_ministerio", idministerio);
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
    }
}
