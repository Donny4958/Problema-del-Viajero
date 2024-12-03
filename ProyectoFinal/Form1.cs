using ProyectoFinal.Model;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Image originalImage; // Imagen original sin cambios
        private float scaleFactor = 1.0f; // Factor de escala actual
        private Grafo grafo; // Grafo para manejar ciudades y rutas
        private Grafo grafota; // Grafo tiempo/auto
        private Grafo grafoca; // Grafo costo/auto
        private Grafo grafott; // Grafo tiempo/transporte
        private Grafo grafoct; // Grafo costo/transporte        

        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.IndianRed;
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            grafo = new Grafo();
            grafota = new Grafo();
            grafoca = new Grafo();
            grafott = new Grafo();
            grafoct = new Grafo();
            llenargrafos();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 3;
            trackBar1.Value = 1;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox1.Image;
            pictureBox1.Paint += PictureBox1_Paint;

        }
        Image Zoompicture(Image img, Size size)
        {
            Bitmap mp = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics g = Graphics.FromImage(mp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return mp;
        }
        PictureBox org;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                scaleFactor = trackBar1.Value;
                pictureBox1.Image = null;
                pictureBox1.Image = Zoompicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
                pictureBox1.Invalidate(); // Fuerza el repintado del PictureBox
            }

        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(grafo, grafota, grafoca, grafott, grafoct);
            form2.ShowDialog(); // Ventana de ciudad            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                originalImage = pictureBox1.Image;
            }
            else
            {
                MessageBox.Show("Por favor, asigna una imagen a pictureBox1 antes de iniciar.");
            }
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
            pictureBox1.Paint += PictureBox1_Paint;
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


        public void llenargrafos()
        {
            todosagregarNodos("a", 200, 100);
            todosagregarNodos("b", 300, 200);
            todosagregarNodos("c", 400, 300);
            todosagregarNodos("d", 500, 500);

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
        public void todosagregarNodos(string nom, int x, int y)
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
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DibujarNodos(e.Graphics);
            DibujarAristas(e.Graphics); // Llamamos a la función para dibujar las aristas
        }
        private void DibujarNodos(Graphics g)
        {
            // Obtener los nodos del grafo
            var nodos = grafo.ObtenerNodos();

            // Crear un Pen con color negro y un grosor mayor para las aristas
            Pen pen = new Pen(Color.Black, 4); // 3 es el grosor de la línea

            // Dibujar cada arista (línea entre nodos)
            foreach (var nodo in nodos.Values)
            {
                foreach (var adyacente in nodo.Adyacentes)
                {
                    // Ajustar las coordenadas de acuerdo al factor de escala
                    float nodoX1 = nodo.X * scaleFactor;
                    float nodoY1 = nodo.Y * scaleFactor;
                    float nodoX2 = adyacente.Destino.X * scaleFactor;
                    float nodoY2 = adyacente.Destino.Y * scaleFactor;

                    // Dibujar la arista (línea entre nodos)
                    g.DrawLine(pen, nodoX1, nodoY1, nodoX2, nodoY2);
                }
            }

            // Dibujar cada nodo
            foreach (var nodo in nodos.Values)
            {
                // Ajustar las coordenadas de acuerdo al factor de escala
                float nodoX = nodo.X * scaleFactor;
                float nodoY = nodo.Y * scaleFactor;

                // Dibujar un círculo para el nodo
                g.FillEllipse(Brushes.Blue, nodoX - 10, nodoY - 10, 20, 20);

                // Dibujar el nombre del nodo
                g.DrawString(nodo.Nombre, DefaultFont, Brushes.White, nodoX - 10, nodoY - 25);
            }
        }

        private void DibujarAristas(Graphics g)
        {
            // Dibujar las aristas (conexiones entre nodos)
            foreach (var nodo in grafo.ObtenerNodos().Values)
            {
                foreach (var adyacente in nodo.Adyacentes)
                {
                    // Obtener las coordenadas de los nodos origen y destino
                    var nodoOrigen = grafo.ObtenerNodos()[nodo.Nombre];
                    var nodoDestino = adyacente.Destino;

                    // Ajustar las coordenadas de acuerdo al factor de escala
                    float x1 = nodoOrigen.X * scaleFactor;
                    float y1 = nodoOrigen.Y * scaleFactor;
                    float x2 = nodoDestino.X * scaleFactor;
                    float y2 = nodoDestino.Y * scaleFactor;

                    // Dibujar la arista (línea entre nodos)
                    g.DrawLine(Pens.Black, x1, y1, x2, y2);

                    // Dibujar el peso de la arista en el medio de la línea
                    float midX = (x1 + x2) / 2;
                    float midY = (y1 + y2) / 2;
                    g.DrawString(adyacente.Peso.ToString(), DefaultFont, Brushes.Black, midX, midY);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
