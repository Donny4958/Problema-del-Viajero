using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class Form2 : Form
    {
        public static int Idioma { get; set; }

        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte                  
        public Form2(Grafo grafoa, Grafo grafotaa, Grafo grafocaa, Grafo grafottt, Grafo grafoctt)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ForeColor = Color.White;
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.White;            
            grafo = grafoa;
            grafota = grafotaa;
            grafoca = grafocaa;
            grafott = grafottt;
            grafoct = grafoctt;            
        }
        public string NombreCiudad { get; private set; } = string.Empty;

        public void AplicarIdioma()
        {
            label1.Text = Resources.StringResources.lbl1;
            button1.Text = Resources.StringResources.btn1;
            button2.Text = Resources.StringResources.btn2;
            button3.Text = Resources.StringResources.btn3;
        }
        private void Form2_Load(object sender, EventArgs e)
        {                        
            AplicarIdioma();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alta de ciudad
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la ciudad.", "Error");
                return;
            }
            //Obtener el valor de numericupdown
            int nomx = Convert.ToInt32(numericUpDown1.Value);
            int nomy = Convert.ToInt32(numericUpDown2.Value);
            NombreCiudad = textBox1.Text;

            if (grafo.Existe(NombreCiudad))
            {
                MessageBox.Show($"Ciudad '{NombreCiudad}' ya existe, intente otro nombre.", "Alta no exitosa");
                return;
            }
            var posiciones = grafo.ObtenerPosiciones();
            if (posiciones.Any(p => p.X == nomx && p.Y == nomy))
            {
                MessageBox.Show($"Ya existe una ciudad en la posición X={nomx}, Y={nomy}.", "Alta no exitosa");
                return;
            }
            else
            {
                MessageBox.Show($"Ciudad '{NombreCiudad}' agregada correctamente.", "Alta exitosa");
                grafo.AgregarNodo(NombreCiudad, nomx, nomy);
                grafota.AgregarNodo(NombreCiudad, nomx, nomy);
                grafoca.AgregarNodo(NombreCiudad, nomx, nomy);
                grafott.AgregarNodo(NombreCiudad, nomx, nomy);
                grafoct.AgregarNodo(NombreCiudad, nomx, nomy);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Baja de ciudad
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la ciudad a eliminar.", "Error");
                return;
            }

            // Obtener el nombre de la ciudad desde el TextBox
            NombreCiudad = textBox1.Text;

            // Intentar eliminar el nodo (ciudad)
            bool eliminado = grafo.EliminarNodo(NombreCiudad); // 'grafo' es el objeto del grafo

            // Mostrar mensaje según si se eliminó o no
            if (eliminado)
            {
                grafota.EliminarNodo(NombreCiudad);
                grafoca.EliminarNodo(NombreCiudad);
                grafott.EliminarNodo(NombreCiudad);
                grafoct.EliminarNodo(NombreCiudad);
                MessageBox.Show($"Ciudad '{NombreCiudad}' eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show($"La ciudad '{NombreCiudad}' no existe en el grafo.");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(grafo, grafota, grafoca, grafott, grafoct);
            form6.ShowDialog(); // Venta de informacion      
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
