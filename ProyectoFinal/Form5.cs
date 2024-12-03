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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.Emit;


namespace ProyectoFinal
{
    public partial class Form5 : Form
    {
        public static int Idioma { get; set; }
        public Form5()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        public void AplicarIdioma()
        {
            label19.Text = Resources.StringResources.lbl19;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Idioma = 0;            
            AplicarIdioma();
        }
    }
}
