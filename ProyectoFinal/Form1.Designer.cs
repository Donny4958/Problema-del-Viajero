﻿namespace ProyectoFinal
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
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mapaToolStripMenuItem, búsquedaToolStripMenuItem, informaciónToolStripMenuItem, idiomaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(867, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mapaToolStripMenuItem
            // 
            mapaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ciudadToolStripMenuItem, rutaToolStripMenuItem });
            mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            mapaToolStripMenuItem.Size = new Size(73, 29);
            mapaToolStripMenuItem.Text = "Mapa";
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(170, 34);
            ciudadToolStripMenuItem.Text = "Ciudad";
            ciudadToolStripMenuItem.Click += ciudadToolStripMenuItem_Click;
            // 
            // rutaToolStripMenuItem
            // 
            rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            rutaToolStripMenuItem.Size = new Size(170, 34);
            rutaToolStripMenuItem.Text = "Ruta";
            rutaToolStripMenuItem.Click += rutaToolStripMenuItem_Click;
            // 
            // búsquedaToolStripMenuItem
            // 
            búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            búsquedaToolStripMenuItem.Size = new Size(106, 29);
            búsquedaToolStripMenuItem.Text = "Búsqueda";
            búsquedaToolStripMenuItem.Click += búsquedaToolStripMenuItem_Click;
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(124, 29);
            informaciónToolStripMenuItem.Text = "Información";
            informaciónToolStripMenuItem.Click += informaciónToolStripMenuItem_Click;
            // 
            // idiomaToolStripMenuItem
            // 
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            idiomaToolStripMenuItem.Size = new Size(84, 29);
            idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(260, 72);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Nodos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(75, 137);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(780, 276);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 72);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 3;
            label1.Text = "Boton y texto Temporal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 750);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Travel Planner";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label1;
    }
}
