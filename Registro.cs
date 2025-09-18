using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMC__Login_
{
    
    public partial class Registro : Form
    {
        private conexion mConexion;
        string genero = "";
        public Registro()
        {
            InitializeComponent();
            mConexion = new conexion();
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            string usuario = txtuser.Text;
            string contraseña = txtcontra.Text;
            string sexo = genero;


            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Por favor llena todos los campos.");
                return;
            }

            using (MySqlConnection conn = mConexion.GetConexion())
            {
                conn.Open();
                string query = @"INSERT INTO acceso(Usuario, Género, Contraseña) VALUES (@usuario, @genero, @contraseña)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@genero", sexo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente!");
                    this.Hide();



                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("El nombre de usuario ya existe.");
                    else
                        MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
        }

        private void mBtn_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Mujer";
        }

        private void HBtn_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Hombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
