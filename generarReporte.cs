using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC__Login_
{
    public partial class generarReporte : Form
    {
        public generarReporte()
        {
            InitializeComponent();
        }


        private void btnImc_Click(object sender, EventArgs e)
        {
            double Altura, Peso;
            string Nombre;
            Nombre = Convert.ToString(txtNombre.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
            Peso = Convert.ToDouble(txtPeso.Text);
            double imc = Peso / (Altura * Altura);
            MessageBox.Show("Hola " + Nombre + "\nTu Indice de masa corporal es:" + imc.ToString("n2"));
            if (imc < 18.5)
            {
                MessageBox.Show("Estas por debajo de tu peso ideal");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                MessageBox.Show("Estas en tu peso ideal");
            }
            else if (imc >= 25 && imc <= 30)
            {
                MessageBox.Show("Tienes sobrepeso");
            }
            else if (imc >= 30)
            {
                MessageBox.Show("Tienes obesidad");
            }
            else
            {
                MessageBox.Show("Ha habido un error con la introduccion de datos");
            }
        }

        private void btnEnviarCorrero_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double imc = peso / (altura * altura);
                string mensajeIMC;
                if (imc < 18.5)
                {
                    mensajeIMC = $"Tu IMC es {imc:F2} Estas por debajo de tu peso ideal";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    mensajeIMC = $"Tu IMC es {imc:F2} Estas en tu peso ideal";
                }
                else if (imc >= 25 && imc <= 30)
                {
                    mensajeIMC = $"Tu IMC es {imc:F2}. Tienes sobrepeso";
                }
                else if (imc >= 30)
                {
                    mensajeIMC = $"Tu IMC es {imc:F2}. Tienes obesidad";
                }
                else
                {
                    mensajeIMC = "Ha ocurrido un error";
                }

                SmtpClient enviar = new SmtpClient("smtp.gmail.com", 587);
                enviar.EnableSsl = true;
                enviar.UseDefaultCredentials = false;
                enviar.Credentials = new NetworkCredential(
                    "proyectoimc32@gmail.com",
                    "atmqhszvnhlivfuq");

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("proyectoimc32@gmail.com");
                correo.To.Add(txtCorreo.Text);
                correo.Subject = "Reporte de IMC";
                correo.Body = mensajeIMC;

                enviar.Send(correo);

                MessageBox.Show("Se envio el correo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void generarReporte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtPeso.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
