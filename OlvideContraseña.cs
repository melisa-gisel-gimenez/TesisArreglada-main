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

namespace arreglarTesis
{
    public partial class OlvideContraseña : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public OlvideContraseña()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string userBuscar = txtNombreUsuario.Text.Trim();

            if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Por favor Ingrese su nombre de usuario.");
            }
            else
            {

                if (!string.IsNullOrEmpty(userBuscar))
                {
                    using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                    {
                        conexion.Open();

                        string consulta = "SELECT * FROM usuarios WHERE NombreUsuario = @nombreUsuario";
                        using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombreUsuario", userBuscar);
                            try
                            {
                                OleDbDataReader reader = comando.ExecuteReader();

                                if (reader.Read())
                                {
                                    MessageBox.Show("Nombre de usuario Correcto. Continúe eligiendo su nueva contraseña");
                                    label3.Visible = true;
                                    label4.Visible = true;
                                    txtNuevaPass.Visible = true;
                                    txtRepetirPass.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("El nombre de usuario es incorrecto. por favor verifique que no haya errores de tipeo");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar el Usiario en la base de datos: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNuevaPass.Text == "" || txtRepetirPass.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacíos. Por favor complete todos los campos.");
            }
            else
            {
                try
                {
                    string nuevaPass = txtNuevaPass.Text;
                    string repetirPass = txtRepetirPass.Text;
                    string nombreUsuario = txtNombreUsuario.Text;

                    if (nuevaPass == repetirPass)
                    {
                        // Encripta la contraseña
                        string contraseñaEncriptada = EncriptarContraseña(txtRepetirPass.Text);

                        string consulta2 = "UPDATE Usuarios SET Contraseña = @contrasena WHERE NombreUsuario = @nombreUsuario";

                        using (OleDbCommand comando = new OleDbCommand(consulta2, conexion))
                        {
                            comando.Parameters.AddWithValue("@contrasena", contraseñaEncriptada);
                            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                            conexion.Open();
                            int cantidad = comando.ExecuteNonQuery();

                            if (cantidad < 1)
                            {
                                MessageBox.Show("Ocurrió un problema");
                            }
                            else
                            {
                                MessageBox.Show("Se registró la nueva contraseña con éxito");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no son iguales, por favor verifique los datos ingresados.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la nueva contraseña: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
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
    }
}
