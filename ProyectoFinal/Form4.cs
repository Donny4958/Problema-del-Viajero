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
        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte
        //textBox1 Nombre ciudad
        public Form4(Grafo grafoa, Grafo grafotaa, Grafo grafocaa, Grafo grafottt, Grafo grafoctt)
        {
            InitializeComponent();
            grafo = grafoa;
            grafota = grafotaa;
            grafoca = grafocaa;
            grafott = grafottt;
            grafoct = grafoctt;
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox2.Clear();            
            var Checado = revisarRadios();
            var origen = comboBox1.SelectedItem?.ToString();
            var destino = comboBox2.SelectedItem?.ToString();
            if (origen == null || destino == null && Checado!=null)
            {
                MessageBox.Show("Seleccione un nodo de inicio y un nodo final.", "Error");
                return;
            }
            try
            {
                var resultado = Checado.Dijkstra(origen, destino);

                if (resultado.Distancia == int.MaxValue)
                {
                    MessageBox.Show($"No hay ruta entre {origen} y {destino}.");
                }
                else
                {
                    // Mostrar cada nodo en listBox1
                    foreach (var nodo in resultado.Ruta)
                    {
                        listBox1.Items.Add(nodo);
                    }

                    // Mostrar el peso de cada arista en listBox2
                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        string nodoActual = resultado.Ruta[i];
                        string nodoSiguiente = resultado.Ruta[i + 1];

                        // Buscar el peso entre nodoActual y nodoSiguiente
                        var pesoArista = Checado.ObtenerVecinos(nodoActual)[nodoSiguiente];
                        listBox2.Items.Add(pesoArista);
                    }

                    // Mostrar el peso total en textBox2
                    textBox2.Text = resultado.Distancia.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Grafo revisarRadios() {
            if (radioButton3.Checked)
            {
                textBox1.Text = "Distancia";
                label8.Text = "Distancia";
                return grafo;
            }
            else
            {                

                if (radioButton1.Checked)
                {
                    textBox1.Text = "Transporte Publico";
                    if (radioButton4.Checked)
                    { 
                        label8.Text = "Costo";
                        return grafota; }
                    else
                    {
                        label8.Text = "Costo";
                        return grafoca;
                    }
                }
                else
                {
                    textBox1.Text = "Carro";
                    if (radioButton4.Checked)
                    {
                        label8.Text = "Tiempo";
                        return grafott;
                    }
                    else
                    {
                        label8.Text = "Costo";
                        return grafoct;
                    }

                }
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox2.Clear();
            var Checado = revisarRadios();
            var origen = comboBox1.SelectedItem?.ToString();
            var destino = comboBox2.SelectedItem?.ToString();
            if (origen == null || destino == null && Checado != null)
            {
                MessageBox.Show("Seleccione un nodo de inicio y un nodo final.", "Error");
                return;
            }
            try
            {
                var resultado = Checado.EncontrarRuta(origen, destino);

                if (resultado.Distancia == int.MaxValue)
                {
                    MessageBox.Show($"No hay ruta entre {origen} y {destino}.");
                }
                else
                {
                    // Mostrar cada nodo en listBox1
                    foreach (var nodo in resultado.Ruta)
                    {
                        listBox1.Items.Add(nodo);
                    }

                    // Mostrar el peso de cada arista en listBox2
                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        string nodoActual = resultado.Ruta[i];
                        string nodoSiguiente = resultado.Ruta[i + 1];

                        // Buscar el peso entre nodoActual y nodoSiguiente
                        var pesoArista = Checado.ObtenerVecinos(nodoActual)[nodoSiguiente];
                        listBox2.Items.Add(pesoArista);
                    }

                    // Mostrar el peso total en textBox2
                    textBox2.Text = resultado.Distancia.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
