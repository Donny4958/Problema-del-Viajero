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
            salirToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mapaToolStripMenuItem, búsquedaToolStripMenuItem, informaciónToolStripMenuItem, idiomaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1174, 24);
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
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            idiomaToolStripMenuItem.Size = new Size(56, 20);
            idiomaToolStripMenuItem.Text = "Idioma";
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
            button1.Location = new Point(737, 95);
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
            richTextBox1.Location = new Point(916, 78);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(247, 551);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mochis;
            pictureBox1.Location = new Point(39, 175);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(854, 491);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(398, 95);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(127, 61);
            button2.TabIndex = 5;
            button2.Text = "Zoom+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(570, 95);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(116, 61);
            button3.TabIndex = 6;
            button3.Text = "Zoom out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.MOCHISPLANNER;
            pictureBox2.Location = new Point(39, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 183);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 787);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
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
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
    }
}
