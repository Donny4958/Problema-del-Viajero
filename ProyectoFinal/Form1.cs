using ProyectoFinal.Model;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte
        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo();
            grafota = new Grafo();
            grafoca = new Grafo();
            grafott = new Grafo();
            grafoct = new Grafo();
            llenargrafos();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Form2 form2 = new Form2(grafo,grafota,grafoca,grafott,grafoct);
            form2.ShowDialog(); // Ventana de ciudad            
    }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(grafo, grafota, grafoca, grafott, grafoct);
            form3.ShowDialog(); // Ventana de ciudad
        }

        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(grafo, grafota, grafoca, grafott, grafoct);
            form4.ShowDialog(); // Ventana de Busqueda
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(); // Venta de informacion
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grafoComoTexto = "Distancia :";// Encabezado
            grafoComoTexto +=grafo.ObtenerRepresentacion();
            grafoComoTexto += "\n\nTiempo Auto :";
            grafoComoTexto += grafota.ObtenerRepresentacion();
            grafoComoTexto += "\n\nCosto Auto :";
            grafoComoTexto += grafoca.ObtenerRepresentacion();
            grafoComoTexto += "\n\nTiempo Trasnporte :";
            grafoComoTexto += grafott.ObtenerRepresentacion();
            grafoComoTexto += "\n\nCosto Transporte :";
            grafoComoTexto += grafoct.ObtenerRepresentacion();
            richTextBox1.Text = grafoComoTexto; // Mostrar en el TextBox
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public void llenargrafos() {
            grafo.AgregarNodo("a", 0, 0);
            grafo.AgregarNodo("b", 1, 0);
            grafo.AgregarNodo("c", 2, 0);
            grafo.AgregarNodo("d", 3, 0);

            grafota.AgregarNodo("a", 0, 0);
            grafota.AgregarNodo("b", 1, 0);
            grafota.AgregarNodo("c", 2, 0);
            grafota.AgregarNodo("d", 3, 0);

            grafoca.AgregarNodo("a", 0, 0);
            grafoca.AgregarNodo("b", 1, 0);
            grafoca.AgregarNodo("c", 2, 0);
            grafoca.AgregarNodo("d", 3, 0);

            grafott.AgregarNodo("a", 0, 0);
            grafott.AgregarNodo("b", 1, 0);
            grafott.AgregarNodo("c", 2, 0);
            grafott.AgregarNodo("d", 3, 0);

            grafoct.AgregarNodo("a", 0, 0);
            grafoct.AgregarNodo("b", 1, 0);
            grafoct.AgregarNodo("c", 2, 0);
            grafoct.AgregarNodo("d", 3, 0);

            grafo.AgregarArista("a", "b", 10);
            grafo.AgregarArista("b", "c", 15);
            grafo.AgregarArista("c", "d", 20);
            grafo.AgregarArista("a", "d", 12);
            grafo.AgregarArista("d", "c", 30);

            // Tiempo en carro (grafota)
            grafota.AgregarArista("a", "b", 8);  // Más rápido que transporte público
            grafota.AgregarArista("b", "c", 12);
            grafota.AgregarArista("c", "d", 18);
            grafota.AgregarArista("a", "d", 22);
            grafota.AgregarArista("d", "c", 27);

            // Costo en carro (grafoca)
            grafoca.AgregarArista("a", "b", 5);  // Ejemplo de costo (en gasolina)
            grafoca.AgregarArista("b", "c", 7);
            grafoca.AgregarArista("c", "d", 10);
            grafoca.AgregarArista("a", "d", 12);
            grafoca.AgregarArista("d", "c", 15);

            // Tiempo en transporte público (grafott)
            grafott.AgregarArista("a", "b", 12); // Más lento que el carro
            grafott.AgregarArista("b", "c", 18);
            grafott.AgregarArista("c", "d", 25);
            grafott.AgregarArista("a", "d", 30);
            grafott.AgregarArista("d", "c", 35);

            // Costo en transporte público (grafoct)
            grafoct.AgregarArista("a", "b", 2);  // Ejemplo de costo menor que el carro
            grafoct.AgregarArista("b", "c", 3);
            grafoct.AgregarArista("c", "d", 4);
            grafoct.AgregarArista("a", "d", 5);
            grafoct.AgregarArista("d", "c", 6);

            // Confirmar la operación
            MessageBox.Show("Nodos y conexiones creados exitosamente con pesos variables en todos los grafos.", "Operación exitosa");
        }

    }
    
}
