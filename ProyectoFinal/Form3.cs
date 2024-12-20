﻿using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Reflection.Emit;

namespace ProyectoFinal
{
    public partial class Form3 : Form
    {
        public static int Idioma { get; set; }

        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte
        //textBox1 Nombre ciudad
        public Form3(Grafo grafoa, Grafo grafotaa, Grafo grafocaa, Grafo grafottt, Grafo grafoctt)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ForeColor = Color.White;
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.Green;
            button5.ForeColor = Color.White;
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.White;
            grafo = grafoa;
            grafota = grafotaa;
            grafoca = grafocaa;
            grafott = grafottt;
            grafoct = grafoctt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void AplicarIdioma()
        {
            label2.Text = Resources.StringResources.lbl2;
            label3.Text = Resources.StringResources.lbl3;
            label4.Text = Resources.StringResources.lbl4;
            label5.Text = Resources.StringResources.lbl5;
            label6.Text = Resources.StringResources.lbl6;
            label7.Text = Resources.StringResources.lbl7;
            label8.Text = Resources.StringResources.lbl8;
            label9.Text = Resources.StringResources.lbl9;
            label10.Text = Resources.StringResources.lbl10;
            label11.Text = Resources.StringResources.lbl11;
            label12.Text = Resources.StringResources.lbl12;
            label13.Text = Resources.StringResources.lbl13;
            button4.Text = Resources.StringResources.btn4;
            button5.Text = Resources.StringResources.btn5;
            button6.Text = Resources.StringResources.btn6;
        }

        private void Form3_Load(object sender, EventArgs e)
        {            
            AplicarIdioma();

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
                comboBox1.Items.Add(nodo.Nombre);  
                comboBox2.Items.Add(nodo.Nombre);
            }

            // Habilitar ComboBox1 y ComboBox2
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); // Limpiar ComboBox2

            // Obtener todos los nodos del grafo
            var nodos = grafo.ObtenerNodos().Values.ToList();

            // Obtener el nodo seleccionado en comboBox1
            var nodoSeleccionado = comboBox1.SelectedItem as string;

            // Agregar los nodos disponibles a comboBox2 que no estén seleccionados en comboBox1
            foreach (var nodo in nodos)
            {
                // Verificar que el nodo no sea el que está seleccionado en comboBox1
                if (nodo.Nombre != nodoSeleccionado)
                {
                    comboBox2.Items.Add(nodo.Nombre);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && numericUpDown1.Value != 0 && numericUpDown2.Value != 0 && numericUpDown3.Value != 0 && numericUpDown4.Value != 0 && numericUpDown5.Value != 0)
            {
                string origen = comboBox1.SelectedItem as string;
                string destino = comboBox2.SelectedItem as string;
                int distancia = Convert.ToInt32(numericUpDown1.Value);
                int tiempoc = Convert.ToInt32(numericUpDown2.Value);
                int tiempoa = Convert.ToInt32(numericUpDown3.Value);
                int costoa = Convert.ToInt32(numericUpDown4.Value);
                int costoc = Convert.ToInt32(numericUpDown5.Value);
                if (origen != destino)
                {
                    if (grafo.Contiene(origen, destino)) { MessageBox.Show("La ruta ya existe."); return; }
                    grafo.AgregarArista(origen, destino, distancia);
                    grafota.AgregarArista(origen, destino, Convert.ToInt32(numericUpDown2.Value));
                    grafoca.AgregarArista(origen, destino, Convert.ToInt32(numericUpDown3.Value));
                    grafott.AgregarArista(origen, destino, Convert.ToInt32(numericUpDown4.Value));
                    grafoct.AgregarArista(origen, destino, Convert.ToInt32(numericUpDown5.Value));
                    MessageBox.Show($"Ruta agregada correctamente.\n Origen: {origen}.\n Destino: {destino}.\n Peso: {distancia}");
                }
            }
            else { 
            MessageBox.Show("Por favor, llene todos los campos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                string origen = comboBox1.SelectedItem as string;
                string destino = comboBox2.SelectedItem as string;
                int num = Convert.ToInt32(numericUpDown1.Value);
                if (origen != destino)
                {
                    if (!grafo.Contiene(origen, destino)) { MessageBox.Show("La ruta no existe."); return; }
                    grafo.EliminarArista(origen, destino);
                    grafota.EliminarArista(origen, destino);
                    grafoca.EliminarArista(origen, destino);
                    grafott.EliminarArista(origen, destino);
                    grafoct.EliminarArista(origen, destino);
                    MessageBox.Show($"Ruta Eliminada correctamente.\n Origen: {origen}.\n Destino: {destino}.");
                }
            }
        }
    }
}
