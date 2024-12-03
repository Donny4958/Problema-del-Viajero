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
        private List<string> nodosUsados = new List<string>();
        private List<Tuple<string, string>> rutasUsadas = new List<Tuple<string, string>>();
        public Form4(Grafo grafoa, Grafo grafotaa, Grafo grafocaa, Grafo grafottt, Grafo grafoctt)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ForeColor = Color.White;
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
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
            if (origen == null || destino == null && Checado != null)
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
                    // Almacenar los nodos y las rutas utilizadas
                    nodosUsados = resultado.Ruta;
                    rutasUsadas.Clear();  // Limpiar rutas usadas anteriores

                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        rutasUsadas.Add(Tuple.Create(resultado.Ruta[i], resultado.Ruta[i + 1]));
                    }

                    // Mostrar los nodos en listBox1
                    foreach (var nodo in resultado.Ruta)
                    {
                        pictureBox1.Paint += pictureBox1_Paint;
                        listBox1.Items.Add(nodo);
                    }

                    // Mostrar el peso de las aristas en listBox2
                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        string nodoActual = resultado.Ruta[i];
                        string nodoSiguiente = resultado.Ruta[i + 1];
                        var pesoArista = Checado.ObtenerVecinos(nodoActual)[nodoSiguiente];
                        listBox2.Items.Add(pesoArista);
                    }

                    // Mostrar el peso total en textBox2
                    textBox2.Text = resultado.Distancia.ToString();
                }

                pictureBox1.Invalidate(); // Redibujar el PictureBox para mostrar la ruta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3); // Para las aristas
            SolidBrush brush = new SolidBrush(Color.Blue); // Para los nodos

            // Dibujar las aristas utilizadas
            foreach (var ruta in rutasUsadas)
            {
                var nodoInicio = grafo.ObtenerNodos()[ruta.Item1];
                var nodoFin = grafo.ObtenerNodos()[ruta.Item2];

                // Calcular las coordenadas de los nodos
                float x1 = (float)(nodoInicio.X * pictureBox1.Width / 1920); // Ajustar a la escala
                float y1 = (float)(nodoInicio.Y * pictureBox1.Height / 1080); // Ajustar a la escala
                float x2 = (float)(nodoFin.X * pictureBox1.Width / 1920);    // Ajustar a la escala
                float y2 = (float)(nodoFin.Y * pictureBox1.Height / 1080);    // Ajustar a la escala

                // Dibujar la línea entre los nodos
                g.DrawLine(pen, x1, y1, x2, y2);
            }

            // Dibujar los nodos utilizados
            foreach (var nodoId in nodosUsados)
            {
                var nodo = grafo.ObtenerNodos()[nodoId];

                // Calcular la posición de cada nodo
                float x = (float)(nodo.X * pictureBox1.Width / 1920);
                float y = (float)(nodo.Y * pictureBox1.Height / 1080);

                // Dibujar el nodo
                g.FillEllipse(brush, x - 5, y - 5, 10, 10);  // El nodo es un círculo pequeño
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
                    // Almacenar los nodos y las rutas utilizadas
                    nodosUsados = resultado.Ruta;
                    rutasUsadas.Clear();  // Limpiar rutas usadas anteriores

                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        rutasUsadas.Add(Tuple.Create(resultado.Ruta[i], resultado.Ruta[i + 1]));
                    }

                    // Mostrar los nodos en listBox1
                    foreach (var nodo in resultado.Ruta)
                    {
                        pictureBox1.Paint += pictureBox1_Paint;
                        listBox1.Items.Add(nodo);
                    }

                    // Mostrar el peso de las aristas en listBox2
                    for (int i = 0; i < resultado.Ruta.Count - 1; i++)
                    {
                        string nodoActual = resultado.Ruta[i];
                        string nodoSiguiente = resultado.Ruta[i + 1];
                        var pesoArista = Checado.ObtenerVecinos(nodoActual)[nodoSiguiente];
                        listBox2.Items.Add(pesoArista);
                    }

                    // Mostrar el peso total en textBox2
                    textBox2.Text = resultado.Distancia.ToString();
                }

                pictureBox1.Invalidate(); // Redibujar el PictureBox para mostrar la ruta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
