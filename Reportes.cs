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
using System.Xml.Linq;

namespace IMC__Login_
{
    public partial class Reportes : Form
    {
        private conexion mConexion;
        public Reportes()
        {
            InitializeComponent();
            mConexion = new conexion();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombre.Text;

           
            int numPaciente = 0;
            double masaKg = 0;
            double estaturaM = 0;
            double imc = 0;
            string generoBD = "";
            int edadBD = 0;
            string edoSalud = "";
            string nombreBD = "";

            using (MySqlConnection conn = mConexion.GetConexion())
            {
                conn.Open();

                string query = @"SELECT Num_paciente, Masa_kg, Estatura_m, IMC,
                                Género, Edad, Edo_Salud, Nombre
                         FROM info_paciente
                         WHERE Nombre = @nombre
                         LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreBuscar);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            numPaciente = reader.GetInt32(reader.GetOrdinal("Num_paciente"));
                            masaKg = reader.IsDBNull(reader.GetOrdinal("Masa_kg")) ? 0 : reader.GetDouble(reader.GetOrdinal("Masa_kg"));
                            estaturaM = reader.IsDBNull(reader.GetOrdinal("Estatura_m")) ? 0 : reader.GetDouble(reader.GetOrdinal("Estatura_m"));
                            imc = reader.IsDBNull(reader.GetOrdinal("IMC")) ? 0 : reader.GetDouble(reader.GetOrdinal("IMC"));
                            generoBD = reader.IsDBNull(reader.GetOrdinal("Género")) ? "" : reader.GetString(reader.GetOrdinal("Género"));
                            edadBD = reader.IsDBNull(reader.GetOrdinal("Edad")) ? 0 : reader.GetInt32(reader.GetOrdinal("Edad"));
                            edoSalud = reader.IsDBNull(reader.GetOrdinal("Edo_Salud")) ? "" : reader.GetString(reader.GetOrdinal("Edo_Salud"));
                            nombreBD = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? "" : reader.GetString(reader.GetOrdinal("Nombre"));

                            resultados.Visible = true;
                            //cambiar lbl
                            panel1.Visible = true;
                            lblEdad.Text = edadBD.ToString();
                            lblAltura.Text = estaturaM.ToString();
                            lblPeso.Text = masaKg.ToString();
                            lblSexo.Text = generoBD.ToString();
                            lblimc.Text = imc.ToString();
                        }

                        else
                        {
                            MessageBox.Show("nombre no encontrado");
                            return;
                        }


                    }

                }
            }
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblimc_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultados.Visible=false;
            panel1.Visible =false;
        }

        private void resultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
