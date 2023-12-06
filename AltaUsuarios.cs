using DocumentFormat.OpenXml.Office2010.PowerPoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Iglesia
{
    public partial class AltaUsuarios : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        //private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\juli_\OneDrive\Escritorio\pepe\BaseIglesiaproduccion.mdb";
        public AltaUsuarios()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }



        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = textBoxDNIBuscar.Text.Trim();

            if (textBoxDNIBuscar.Text.Length < 8 || textBoxDNIBuscar.Text == "")
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
                        string consulta = "SELECT * FROM usuarios WHERE DNI_User = @DNI_User";
                        using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@DNI", dniABuscar);
                            try
                            {
                                OleDbDataReader reader = comando.ExecuteReader();
                                if (reader.Read())
                                {
                                    MessageBox.Show("Esta persona ya está dada de alta como usuario, por favor verifique el DNI ingresado.");
                                }
                                else
                                {
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

                                                // Lee el valor del campo "inhabilitado"
                                                bool inhabilitado = Convert.ToBoolean(reader2["inhabilitado"]);

                                                // Establece el estado de los CheckBox según el valor de "inhabilitado"
                                                checkBoxInhabilitado.Checked = inhabilitado;
                                                checkBoxNo.Checked = !inhabilitado;

                                                if (checkBoxInhabilitado.Checked == true)
                                                {
                                                    MessageBox.Show("No puede dar de alta como usuario del sistema a una persona inhabilitada. Consulte con Administración o verifique el DNI ingresado");
                                                }

                                                if (checkBoxNo.Checked == true)
                                                {
                                                    txtNombreUsuario.Enabled = true;
                                                    txtPassword.Enabled = true;
                                                    comboBoxTipoUsuario.Enabled = true;
                                                    checkBoxAltaUser.Enabled = true;
                                                    buttonAceptar.Enabled = true;
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
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar el DNI en la base de datos: " + ex.Message);
                            }

                        }
                    }
                }
            }
        }



        private void textBoxDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDNIBuscar_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (textBoxDNIBuscar.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                textBoxDNIBuscar.SelectionStart = textBoxDNIBuscar.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }

        //GUARDA LA PASS ENCRIPTADA
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNombreUsuario.Text == "" || txtPassword.Text == "" || checkBoxAltaUser.Checked == false)
            {
                MessageBox.Show("No debe dejar campos vacíos. Por favor complete todos los campos.");
            }
            else
            {

                try
                {
                    // Encripta la contraseña
                    string contraseñaEncriptada = EncriptarContraseña(txtPassword.Text);

                    int idRolG = 0;  // Asigna un valor por defecto, puedes ajustar esto según tus necesidades

                    if (comboBoxTipoUsuario.Text == "Tesorero")
                    {
                        idRolG = 1;
                    }
                    else if (comboBoxTipoUsuario.Text == "Pastor")
                    {
                        idRolG = 2;
                    }
                    else if (comboBoxTipoUsuario.Text == "Administrador")
                    {
                        idRolG = 3;
                    }
                    else if (comboBoxTipoUsuario.Text == "Mentor")
                    {
                        idRolG = 4;
                    }

                    else if (comboBoxTipoUsuario.Text == "SuperU")
                    {
                        idRolG = 5;
                    }

                    // Prepara la consulta SQL con la contraseña encriptada
                    string consulta2 = "INSERT INTO Usuarios (DNI_User, NombreUsuario, Contraseña, tipo_usuario, habilitado) VALUES (" + int.Parse(textBoxDNIBuscar.Text) + ", '" + txtNombreUsuario.Text + "', '" + contraseñaEncriptada + "', '" + comboBoxTipoUsuario.Text + "', " + checkBoxAltaUser.Checked + ")";

                    using (OleDbCommand comando = new OleDbCommand(consulta2, conexion))
                    {
                        conexion.Open();
                        int cantidad = comando.ExecuteNonQuery();

                        if (cantidad < 1)
                        {
                            MessageBox.Show("Ocurrió un problema");
                        }
                        else
                        {
                            MessageBox.Show("Se registró el usuario con éxito");
                            conexion.Close();
                            this.Close();
                        }

                    }

                    //string dniABuscar = textBoxDNIBuscar.Text.Trim();

                    // SQL para agregar rol a tabla miembros
                    string consulta3 = "UPDATE Miembros SET id_rolg=" + "'" + idRolG + "'" + " WHERE DNI=" + int.Parse(textBoxDNIBuscar.Text);

                    using (OleDbCommand comando3 = new OleDbCommand(consulta3, conexion))
                    {
                        conexion.Open();
                        int cantidad = comando3.ExecuteNonQuery();

                        if (cantidad < 1)
                        {
                            MessageBox.Show("Ocurrió un problema al actualizar el rol en la tabla miembros");
                        }
                        else
                        {
                            MessageBox.Show("Se actualizó el rol correctamente");
                            this.Close();
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNIBuscar.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            checkBoxInhabilitado.Checked = false;
            comboBoxTipoUsuario.Text = string.Empty;
            checkBoxAltaUser.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaUsuarios_Load(object sender, EventArgs e)
        {

        }
        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte la contraseña a bytes
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);

                // Calcula el hash SHA256
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convierte el hash a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
