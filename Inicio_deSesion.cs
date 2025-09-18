using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace IMC__Login_
{
    public partial class Inicio_deSesion : Form
    {
        private conexion mConexion;
        public Inicio_deSesion()
        {
            InitializeComponent();
            mConexion = new conexion();
        }

        private void Inicio_deSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == " " || password == " ")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = mConexion.GetConexion())
             {

                    conn.Open();
                string query = "SELECT COUNT(*) FROM acceso WHERE Usuario = @Username AND Contraseña = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    
                    MessageBox.Show("¡Inicio de sesión exitoso!" + "\n Bienvenido: " + username);


                    this.Hide();
                    
                    menuprincipal menuprincipal = new menuprincipal();
                    menuprincipal.Show();

                    // Guardar el nombre de usuario en la sesión




                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}

