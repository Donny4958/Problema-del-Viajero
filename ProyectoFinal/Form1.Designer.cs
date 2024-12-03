namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mapaToolStripMenuItem = new ToolStripMenuItem();
            ciudadToolStripMenuItem = new ToolStripMenuItem();
            rutaToolStripMenuItem = new ToolStripMenuItem();
            búsquedaToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
            idiomaToolStripMenuItem = new ToolStripMenuItem();
            españolToolStripMenuItem = new ToolStripMenuItem();
            inglésToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mapaToolStripMenuItem, búsquedaToolStripMenuItem, informaciónToolStripMenuItem, idiomaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1186, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mapaToolStripMenuItem
            // 
            mapaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ciudadToolStripMenuItem, rutaToolStripMenuItem });
            mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            mapaToolStripMenuItem.Size = new Size(49, 20);
            mapaToolStripMenuItem.Text = "Mapa";
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(112, 22);
            ciudadToolStripMenuItem.Text = "Ciudad";
            ciudadToolStripMenuItem.Click += ciudadToolStripMenuItem_Click;
            // 
            // rutaToolStripMenuItem
            // 
            rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            rutaToolStripMenuItem.Size = new Size(112, 22);
            rutaToolStripMenuItem.Text = "Ruta";
            rutaToolStripMenuItem.Click += rutaToolStripMenuItem_Click;
            // 
            // búsquedaToolStripMenuItem
            // 
            búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            búsquedaToolStripMenuItem.Size = new Size(71, 20);
            búsquedaToolStripMenuItem.Text = "Búsqueda";
            búsquedaToolStripMenuItem.Click += búsquedaToolStripMenuItem_Click;
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(84, 20);
            informaciónToolStripMenuItem.Text = "Información";
            informaciónToolStripMenuItem.Click += informaciónToolStripMenuItem_Click;
            // 
            // idiomaToolStripMenuItem
            // 
            idiomaToolStripMenuItem.Checked = true;
            idiomaToolStripMenuItem.CheckState = CheckState.Checked;
            idiomaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { españolToolStripMenuItem, inglésToolStripMenuItem });
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            idiomaToolStripMenuItem.Size = new Size(56, 20);
            idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // españolToolStripMenuItem
            // 
            españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            españolToolStripMenuItem.Size = new Size(115, 22);
            españolToolStripMenuItem.Text = "Español";
            españolToolStripMenuItem.Click += españolToolStripMenuItem_Click;
            // 
            // inglésToolStripMenuItem
            // 
            inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            inglésToolStripMenuItem.Size = new Size(115, 22);
            inglésToolStripMenuItem.Text = "Inglés";
            inglésToolStripMenuItem.Click += inglésToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(119, 209);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 61);
            button1.TabIndex = 1;
            button1.Text = "Nodos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 274);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 322);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mochis2;
            pictureBox1.Location = new Point(2, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.MOCHISPLANNER;
            pictureBox2.Location = new Point(39, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 156);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(401, 27);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 558);
            panel1.TabIndex = 8;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(39, 816);
            trackBar1.Margin = new Padding(2);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(253, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 649);
            Controls.Add(trackBar1);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Travel Planner";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mapaToolStripMenuItem;
        private ToolStripMenuItem ciudadToolStripMenuItem;
        private ToolStripMenuItem rutaToolStripMenuItem;
        private ToolStripMenuItem búsquedaToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button button1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TrackBar trackBar1;
        private ToolStripMenuItem españolToolStripMenuItem;
        private ToolStripMenuItem inglésToolStripMenuItem;
    }
}
