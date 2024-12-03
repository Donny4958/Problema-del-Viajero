using ProyectoFinal.Model;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Threading;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public static int Idioma { get; set; }

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

        private void AplicarIdioma()
        {
            mapaToolStripMenuItem.Text = Resources.StringResources.menu1;
            rutaToolStripMenuItem.Text = Resources.StringResources.menu2;
            ciudadToolStripMenuItem.Text = Resources.StringResources.menu3;
            búsquedaToolStripMenuItem.Text = Resources.StringResources.menu4;
            informaciónToolStripMenuItem.Text = Resources.StringResources.menu5;
            idiomaToolStripMenuItem.Text = Resources.StringResources.menu6;
            salirToolStripMenuItem.Text = Resources.StringResources.menu7;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Idioma = 0;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-MX");
            AplicarIdioma();

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

        public void todosagregarNodos(string nom, int x, int y)
        {
            grafo.AgregarNodo(nom, x, y);
            grafota.AgregarNodo(nom, x, y);
            grafott.AgregarNodo(nom, x, y);
            grafoca.AgregarNodo(nom, x, y);
            grafoct.AgregarNodo(nom, x, y);
        }
        public void todosagregarAristas(string nom,string fin, int a, int b,int c,int d,int e)
        {
            grafo.AgregarArista(nom,fin, a);
            grafota.AgregarArista(nom, fin, b); //tiempo auto
            grafott.AgregarArista(nom, fin, c); //tiempo transporte
            grafoca.AgregarArista(nom, fin, d); //costo auto
            grafoct.AgregarArista(nom, fin, e); //costo transporte
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
        public void llenargrafos()
        {
            todosagregarNodos("Puente del Trebol", 1150, 400);
            todosagregarNodos("Cerro de la Memoria", 1550, 300);
            todosagregarNodos("Parque Sinaloa", 1400, 500);
            todosagregarNodos("Estadio Emilio Ibarra Almada", 1350, 450);
            todosagregarNodos("Torre San Bernardo", 1280,500);
            todosagregarNodos("Adrian Ledesma", 1300, 600);
            todosagregarNodos("Hospital General", 1250, 550);
            todosagregarNodos("Iglesia Sagrado Corazon de Jesus", 1400, 550);
            todosagregarNodos("Universidad Autonoma de Sinaloa", 1150, 650);
            todosagregarNodos("Casa de Juan Pablo", 9, 0);
            todosagregarNodos("Tacos El Guero", 1300, 700);
            todosagregarNodos("Parque Industrial", 900, 750);
            todosagregarNodos("Estadio Centenario", 1000, 500);
            todosagregarNodos("Plaza Paseo Los Mochis", 1250, 500);
            todosagregarNodos("Tacos del Chavo", 1350, 620);
            todosagregarNodos("Oasis Los Mochis", 950, 650);
            todosagregarNodos("Museo Trapiche", 1300, 560);
            todosagregarNodos("Estatua de Juarez", 1400, 450);
            todosagregarNodos("Autodromo Colina", 800, 300);
            todosagregarNodos("Ciudad Deportiva", 1150, 750);
            todosagregarAristas("Puente del Trebol", "Cerro de la Memoria", 5, 10, 20, 20, 12);
            todosagregarAristas("Cerro de la Memoria", "Parque Sinaloa", 3, 7, 15, 15, 10);
            todosagregarAristas("Parque Sinaloa", "Estadio Emilio Ibarra Almada", 2, 5, 12, 10, 8);
            todosagregarAristas("Estadio Emilio Ibarra Almada", "Torre San Bernardo", 1, 3, 8, 8, 6);
            todosagregarAristas("Torre San Bernardo", "Adrian Ledesma", 2, 5, 10, 10, 7);
            todosagregarAristas("Adrian Ledesma", "Hospital General", 3, 8, 15, 12, 10);
            todosagregarAristas("Hospital General", "Iglesia Sagrado Corazon de Jesus", 2, 5, 12, 10, 8);
            todosagregarAristas("Iglesia Sagrado Corazon de Jesus", "Universidad Autonoma de Sinaloa", 3, 8, 15, 12, 10);
            todosagregarAristas("Universidad Autonoma de Sinaloa", "Tacos El Guero", 4, 10, 18, 15, 10);
            todosagregarAristas("Tacos El Guero", "Parque Industrial", 5, 12, 20, 18, 15);
            todosagregarAristas("Parque Industrial", "Estadio Centenario", 4, 10, 18, 15, 12);
            todosagregarAristas("Estadio Centenario", "Plaza Paseo Los Mochis", 2, 5, 10, 8, 6);
            todosagregarAristas("Plaza Paseo Los Mochis", "Tacos del Chavo", 3, 7, 12, 12, 8);
            todosagregarAristas("Tacos del Chavo", "Oasis Los Mochis", 5, 12, 20, 18, 15);
            todosagregarAristas("Oasis Los Mochis", "Museo Trapiche", 4, 10, 18, 15, 12);
            todosagregarAristas("Museo Trapiche", "Estatua de Juarez", 3, 7, 12, 12, 8);
            todosagregarAristas("Estatua de Juarez", "Autodromo Colina", 6, 15, 25, 20, 15);
            todosagregarAristas("Autodromo Colina", "Ciudad Deportiva", 5, 12, 20, 18, 12);
            /*grafo.AgregarArista("Puente del Trebol", "Autodromo Colinas", 3);
            grafo.AgregarArista("Puente del Trebol", "Universidad Autonoma de Sinaloa", 3);

            //Autodromo Colinas
            grafo.AgregarArista("Autodromo Colinas", "Cerro de la Memoria", 4);

            //Cerro de la Memoria
            grafo.AgregarArista("Cerro de la Memoria", "Emilio Ibarra Almada", 2);
            grafo.AgregarArista("Cerro de la Memoria", "Universidad Autonoma de Sinaloa", 2);

            //Emilio Ibarra Almada
            grafo.AgregarArista("Emilio Ibarra Almada", "Ciudad Deportiva", 1);

            //Adrian Ledesma
            grafo.AgregarArista("Adrian Ledesma", "Hospital General", 8);

            //UAS
            grafo.AgregarArista("Universidad Autonoma de Sinaloa", "Casa de Juan Pablo", 2);
            grafo.AgregarArista("Universidad Autonoma de Sinaloa", "Tacos del Chavo", 3);

            //Tacos del Chavo
            grafo.AgregarArista("Tacos del Chavo", "Tacos el Guero", 1);
            grafo.AgregarArista("Tacos del Chavo", "Casa de Juan Pablo", 4);

            //Casa Jp
            grafo.AgregarArista("Casa de Juan Pablo", "Estadio Centenario", 8);

            //Tacos el guero
            grafo.AgregarArista("Tacos el Guero", "Oasis Los Mochis", 1);

            //Ciudad deportiva
            grafo.AgregarArista("Ciudad Deportiva", "Parque Industrial", 3);
            grafo.AgregarArista("Ciudad Deportiva", "Oasis Los Mochis", 2);

            //Parque Industrial
            grafo.AgregarArista("Parque Industrial", "Hospital General", 4);
            grafo.AgregarArista("Parque Industrial", "Oasis Los Mochis", 4);

            //Oasis
            grafo.AgregarArista("Oasis Los Mochis", "Museo Trapiche", 2);

            //Estadio Centenario
            grafo.AgregarArista("Estadio Centenario", "Iglesia Sagrado Corazon de Jesus", 5);
            grafo.AgregarArista("Estadio Centenario", "Parque Sinaloa", 3);

            //Parque Sinaloa
            grafo.AgregarArista("Parque Sinaloa", "Torre San Bernardo", 0);

            //Iglesia Sagrado Corazon de Jesus
            grafo.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Torre San Bernardo", 1);
            grafo.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Museo Trapiche", 0);
            grafo.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Estatua de Juarez", 2);
            grafo.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Plaza Paseo Los Mochis", 1);

            //Paseo los moshis
            grafo.AgregarArista("Plaza Paseo Los Mochis", "Estatua de Juarez", 2);
            grafo.AgregarArista("Plaza Paseo Los Mochis", "Hospital General", 2);

            //Hospital General
            grafo.AgregarArista("Hospital General", "Estatua de Juarez", 2);


            // Tiempo en carro (grafota)
            grafota.AgregarArista("Puente del Trébol", "Autodromo Colinas", 7);
            grafota.AgregarArista("Puente del Trebol", "Universidad Autonoma de Sinaloa", 7);

            grafota.AgregarArista("Autodromo Colinas", "Cerro de la Memoria", 13);

            grafota.AgregarArista("Cerro de la Memoria", "Emilio Ibarra Almada", 3);
            grafota.AgregarArista("Cerro de la Memoria", "Universidad Autonoma de Sinaloa", 6);

            grafota.AgregarArista("Emilio Ibarra Almada", "Ciudad Deportiva", 2);

            grafota.AgregarArista("Adrian Ledesma", "Hospital General", 14);

            grafota.AgregarArista("Universidad Autonoma de Sinaloa", "Casa de Juan Pablo", 5);
            grafota.AgregarArista("Universidad Autonoma de Sinaloa", "Tacos del Chavo", 6);

            grafota.AgregarArista("Tacos del Chavo", "Tacos el Guero", 3);
            grafota.AgregarArista("Tacos del Chavo", "Casa de Juan Pablo", 8);

            grafota.AgregarArista("Casa de Juan Pablo", "Estadio Centenario", 15);

            grafota.AgregarArista("Tacos el Guero", "Oasis Los Mochis", 1);

            grafota.AgregarArista("Ciudad Deportiva", "Parque Industrial", 5);
            grafota.AgregarArista("Ciudad Deportiva", "Oasis Los Mochis", 5);

            grafota.AgregarArista("Parque Industrial", "Hospital General", 9);
            grafota.AgregarArista("Parque Industrial", "Oasis Los Mochis", 8);

            grafota.AgregarArista("Oasis Los Mochis", "Museo Trapiche", 2);

            grafota.AgregarArista("Estadio Centenario", "Iglesia Sagrado Corazon de Jesus", 10);
            grafota.AgregarArista("Estadio Centenario", "Parque Sinaloa", 9);

            grafota.AgregarArista("Parque Sinaloa", "Torre San Bernardo", 3);

            grafota.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Torre San Bernardo", 2);
            grafota.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Museo Trapiche", 1);
            grafota.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Estatua de Juarez", 3);
            grafota.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Plaza Paseo Los Mochis", 4);

            grafota.AgregarArista("Plaza Paseo Los Mochis", "Estatua de Juarez", 5);
            grafota.AgregarArista("Plaza Paseo Los Mochis", "Hospital General", 7);

            grafota.AgregarArista("Hospital General", "Estatua de Juarez", 5);
            // Tiempo en transporte público (grafott)
            grafott.AgregarArista("Puente del Trébol", "Autodromo Colinas", 56);
            grafott.AgregarArista("Puente del Trebol", "Universidad Autonoma de Sinaloa", 16);

            grafott.AgregarArista("Autodromo Colinas", "Cerro de la Memoria", 19);

            grafott.AgregarArista("Cerro de la Memoria", "Emilio Ibarra Almada", 5);
            grafott.AgregarArista("Cerro de la Memoria", "Universidad Autonoma de Sinaloa", 13);

            grafott.AgregarArista("Emilio Ibarra Almada", "Ciudad Deportiva", 13);

            grafott.AgregarArista("Adrian Ledesma", "Hospital General", 27);

            grafott.AgregarArista("Universidad Autonoma de Sinaloa", "Casa de Juan Pablo", 20);
            grafott.AgregarArista("Universidad Autonoma de Sinaloa", "Tacos del Chavo", 12);

            grafott.AgregarArista("Tacos del Chavo", "Tacos el Guero", 10);
            grafott.AgregarArista("Tacos del Chavo", "Casa de Juan Pablo", 40);

            grafott.AgregarArista("Casa de Juan Pablo", "Estadio Centenario", 27);

            grafott.AgregarArista("Tacos el Guero", "Oasis Los Mochis", 8);

            grafott.AgregarArista("Ciudad Deportiva", "Parque Industrial", 34);
            grafott.AgregarArista("Ciudad Deportiva", "Oasis Los Mochis", 22);

            grafott.AgregarArista("Parque Industrial", "Hospital General", 27);
            grafott.AgregarArista("Parque Industrial", "Oasis Los Mochis", 32);

            grafott.AgregarArista("Oasis Los Mochis", "Museo Trapiche", 13);

            grafott.AgregarArista("Estadio Centenario", "Iglesia Sagrado Corazon de Jesus", 25);
            grafott.AgregarArista("Estadio Centenario", "Parque Sinaloa", 36);

            grafott.AgregarArista("Parque Sinaloa", "Torre San Bernardo", 5);

            grafott.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Torre San Bernardo", 8);
            grafott.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Museo Trapiche", 3);
            grafott.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Estatua de Juarez", 16);
            grafott.AgregarArista("Iglesia Sagrado Corazon de Jesus", "Plaza Paseo Los Mochis", 17);

            grafott.AgregarArista("Plaza Paseo Los Mochis", "Estatua de Juarez", 25);
            grafott.AgregarArista("Plaza Paseo Los Mochis", "Hospital General", 30);

            grafott.AgregarArista("Hospital General", "Estatua de Juarez", 26);
            */
            // Confirmar la operación
            MessageBox.Show("Nodos y conexiones creados exitosamente con pesos variables en todos los grafos.", "Operación exitosa");
        }
        public void agregarAristas(string a, string b, int p1, int p2, int p3, int p4, int p5)
        {
            grafo.AgregarArista(a, b, p1);
            grafota.AgregarArista(a, b, p2);
            grafoca.AgregarArista(a, b, p3);
            grafott.AgregarArista(a, b, p4);
            grafoct.AgregarArista(a, b, p5);
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inglésToolStripMenuItem.Checked = false;
            españolToolStripMenuItem.Checked = true;
            Idioma = 0;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-MX");
            AplicarIdioma();
            MessageBox.Show("Idioma : Español");
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inglésToolStripMenuItem.Checked = true;
            españolToolStripMenuItem.Checked = false;
            Idioma = 1;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("EN-US");
            AplicarIdioma();
            MessageBox.Show("Language : English");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
