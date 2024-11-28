using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form4 : Form
    {
        private Grafo grafo;
        public Form4(Grafo grafoa)
        {
            InitializeComponent();
            grafo = grafoa; // Asignamos el grafo pasado como parámetro
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (grafo.ContarNodos() < 2)
            {
                MessageBox.Show("Para operar la ruta, deben existir al menos 2 nodos.", "Error");
                this.Close();  // Cerrar el formulario si no hay suficientes nodos                
            }
            comboBox1.Items.Clear(); // Limpiar ComboBox1
            comboBox2.Items.Clear(); // Limpiar ComboBox2

            var nodos = grafo.ObtenerNodos().Values.ToList();

            // Agregar los nodos disponibles a ComboBox1
            foreach (var nodo in nodos)
            {
                comboBox1.Items.Add(nodo.Nombre);  // O usar nodo.Id o nodo.Nombre si lo prefieres
                comboBox2.Items.Add(nodo.Nombre);
            }

            // Habilitar ComboBox1 y ComboBox2
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cambio de datos (implementación futura)
            MessageBox.Show("Funcionalidad de ruta mas corta no implementada aún.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cambio de datos (implementación futura)
            MessageBox.Show("Funcionalidad de ruta alterna no implementada aún.");
        }
    }
}
