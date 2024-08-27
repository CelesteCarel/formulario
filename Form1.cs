using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;
            string genero = "";
            if (rbHombre.Checked) {
                genero = "Hombre";
            }
            else if (rbMujer.Checked) {
                genero = "Mujer";
            }
            string datos = $"Nombre: {nombres}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGénero: {genero}";
            string rutaArchivo = "C:/Users/bogab/Documents/formulario de datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);
            using(StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados con éxito: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
;        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbEdad.Clear();
            tbTelefono.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false; 
        }
    }
}
