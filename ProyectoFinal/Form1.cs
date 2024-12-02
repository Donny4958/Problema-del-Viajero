using ProyectoFinal.Model;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte
        private float zoomFactor = 1.0f; // Factor de zoom inicial
        private Bitmap originalImage = new Bitmap(1, 1); // Imagen vacía de 1x1 píxel
        private Bitmap displayedImage = new Bitmap(1, 1); // Imagen vacía de 1x1 píxel

        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo();
            grafota = new Grafo();
            grafoca = new Grafo();
            grafott = new Grafo();
            grafoct = new Grafo();
            llenargrafos();
            originalImage = Properties.Resources.Mochis; // Asignar la imagen del recurso
            displayedImage = ResizeImage(originalImage, pictureBox2.Width, pictureBox2.Height);
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(grafo, grafota, grafoca, grafott, grafoct);
            form2.ShowDialog(); // Ventana de ciudad            

        }


        private void Form1_Load(object sender, EventArgs e)
        { 
            pictureBox2.Image = Properties.Resources.Mochis;
            displayedImage = ResizeImage(originalImage, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = displayedImage;
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
            grafoComoTexto += grafo.ObtenerRepresentacion();
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

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var resized = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resized;
        }













        public void llenargrafos()
        {
            todosagregarNodos("a", 0, 0);
            todosagregarNodos("b", 1, 0);
            todosagregarNodos("c", 2, 0);
            todosagregarNodos("d", 3, 0);

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
        public void todosagregarNodos(string nom,int x, int y)
        {
            grafo.AgregarNodo(nom, x, y);
            grafota.AgregarNodo(nom, x, y);
            grafott.AgregarNodo(nom, x, y);
            grafoca.AgregarNodo(nom, x, y);
            grafoct.AgregarNodo(nom, x, y);

        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.1f;
            ApplyZoom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zoomFactor > 0.1f) // Evitar zoom negativo o extremadamente pequeño
            {
                zoomFactor -= 0.1f;
                ApplyZoom();
            }
        }
        private void ApplyZoom()
        {
            if (originalImage != null)
            {
                int newWidth = (int)(originalImage.Width * zoomFactor);
                int newHeight = (int)(originalImage.Height * zoomFactor);
                displayedImage = ResizeImage(originalImage, newWidth, newHeight);

                // Ajustar la imagen en el PictureBox
                pictureBox2.Image = displayedImage;

                // Ajustar el tamaño del PictureBox si es necesario
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox2.Refresh();
            }
        }
    }

}
