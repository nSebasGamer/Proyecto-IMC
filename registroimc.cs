using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IMC__Login_
{
    public partial class registroimc : Form
    {
        private conexion mConexion;

        string genero = "";
        public registroimc()
        {
            InitializeComponent();
            mConexion = new conexion();
        }

        private void registroimc_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);

            if (age % 1 != 0)
            {
                MessageBox.Show("Error: la edad no puede llevar decimales");
            }
            else
            {
                //convertir cm a m

                double altura = height / 100;
                //elevar estatura al cuadrado
                double estatura = Math.Pow(altura, 2);

                //calcular IMC
                double IMC = weight / estatura;

                MessageBox.Show("El Usuario: " + name + " Tiene un IMC de: " + IMC.ToString());
                //subir a base de datos
                using (MySqlConnection conn = mConexion.GetConexion())
                {
                    conn.Open();
                    string query = @"INSERT INTO info_paciente(Masa_kg, Estatura_m, IMC, Género, Edad, Nombre) VALUES (@peso, @Estatura, @IMC, @Genero, @Edad, @Nombre)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@peso",weight);
                    cmd.Parameters.AddWithValue("@Estatura",altura);
                    cmd.Parameters.AddWithValue("@IMC", IMC);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Edad", age);
                    cmd.Parameters.AddWithValue("@Nombre", name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro Exitoso");

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
 
                    }

                }

            }


        }

        private void btnSexH_Click(object sender, EventArgs e)
        {
            genero = "Hombre";
            MessageBox.Show("Sexo guardado correctamente como: HOMBRE");
        }

        private void btnSexF_Click(object sender, EventArgs e)
        {
            genero = "Mujer";
            MessageBox.Show("Sexo guardado correctamente como: MUJER");
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
