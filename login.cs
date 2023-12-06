using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;
using arreglarTesis;

namespace Iglesia
{
    public partial class LoginJuli : Form
    {
        private OleDbConnection conexion;
        //private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\juli_\OneDrive\Escritorio\pepe\BaseIglesiaproduccion.mdb";
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        private string rol = "";

        public LoginJuli()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.White;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.Black;

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtPassword.PasswordChar = '*';
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, introduce tu nombre de usuario y contraseña.");
                return;
            }

            bool areCredentialsValid = VerifyCredentials(username, EncriptarContraseña(password));
            if (areCredentialsValid)
            {

                if (rol.Equals("Administrador"))
                {
                    PPAdministracion form = new PPAdministracion();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Tesorero"))
                {
                    PPTesoreria form = new PPTesoreria();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Mentor"))
                {
                    PPmentor form = new PPmentor();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Pastor"))
                {
                    paginaprincipal form = new paginaprincipal();
                    form.Show();
                    this.Hide();
                }

                else if (rol.Equals("SuperU"))
                {
                    PPSuperUs form = new PPSuperUs();
                    form.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            }
        }

        private bool VerifyCredentials(string username, string password)
        {
            bool result = false;
            string consulta = "SELECT * FROM usuarios WHERE nombreUsuario = @nombreUsuario AND contraseña = @clave ";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@nombreUsuario", username);
                comando.Parameters.AddWithValue("@clave", password);

                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        result = true;
                        rol = reader["tipo_usuario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Los datos proporcionados no son correctos.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            return result;
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

        private void LoginJuli_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvideContraseña form = new OlvideContraseña();
            form.ShowDialog();

        }
    }
}







