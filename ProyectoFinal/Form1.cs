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
            Form4 form4 = new Form4(grafo);
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
    }
}
