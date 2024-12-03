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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.Emit;

namespace ProyectoFinal
{
    public partial class Form6 : Form
    {
        public static int Idioma { get; set; }

        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte
        //textBox1 Nombre ciudad
        public Form6(Grafo grafoa, Grafo grafotaa, Grafo grafocaa, Grafo grafottt, Grafo grafoctt)
        {
            InitializeComponent();
            grafo = grafoa;
            grafota = grafotaa;
            grafoca = grafocaa;
            grafott = grafottt;
            grafoct = grafoctt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreActual = comboBox1.SelectedItem as string;
            string nuevoNombre = textBox1.Text;  // Nombre que se ingresó en el TextBox para el cambio

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Por favor, ingresa un nuevo nombre para el nodo.");
                return;
            }

            if (grafo.CambiarNombreNodo(nombreActual, nuevoNombre))
            {
                grafo.CambiarNombreNodo(nombreActual, nuevoNombre);
                grafota.CambiarNombreNodo(nombreActual, nuevoNombre);
                grafoca.CambiarNombreNodo(nombreActual, nuevoNombre);
                grafott.CambiarNombreNodo(nombreActual, nuevoNombre);
                grafoct.CambiarNombreNodo(nombreActual, nuevoNombre);
                MessageBox.Show($"El nombre del nodo '{nombreActual}' ha sido cambiado a '{nuevoNombre}'.");
            }
            else
            {
                MessageBox.Show("El cambio de nombre no pudo realizarse. Verifica que el nombre no esté en uso.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AplicarIdioma()
        {
            label20.Text = Resources.StringResources.lbl20;
            label21.Text = Resources.StringResources.lbl21;
            button9.Text = Resources.StringResources.btn9;
            button10.Text = Resources.StringResources.btn10;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            AplicarIdioma();

            if (grafo.ContarNodos() < 1)
            {
                MessageBox.Show("Para operar la ruta, deben existir al menos 1 nodo.", "Error");
                this.Close();  // Cerrar el formulario si no hay suficientes nodos                
            }
            comboBox1.Items.Clear(); // Limpiar ComboBox1            

            var nodos = grafo.ObtenerNodos().Values.ToList();

            // Agregar los nodos disponibles a ComboBox1
            foreach (var nodo in nodos)
            {
                comboBox1.Items.Add(nodo.Nombre);  // O usar nodo.Id o nodo.Nombre si lo prefieres                
            }
            // Habilitar ComboBox1 y ComboBox2
            comboBox1.Enabled = true;            
        }
    }
}
