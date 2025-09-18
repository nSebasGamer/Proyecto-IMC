using IMC__Login_.Resources;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC__Login_
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            registroimc registroimc = new registroimc();
            registroimc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generarReporte generarReporte = new generarReporte();
            generarReporte.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando Sesion...");
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Existen Problemas bro...");
            MessageBox.Show("Este programa es perfecto");
            secret secret = new secret();
            secret.Show();
        }
    }
}
