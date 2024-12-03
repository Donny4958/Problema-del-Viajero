namespace ProyectoFinal
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Ciudad donde inicia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 60);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Ciudad donde termina";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(169, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 23);
            comboBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(413, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(153, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medio de transporte";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 58);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(124, 19);
            radioButton2.TabIndex = 25;
            radioButton2.Text = "Transporte publico";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(11, 29);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Carro";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(599, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 111);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Criterio de búsqueda";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(5, 77);
            radioButton5.Margin = new Padding(2, 2, 2, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(56, 19);
            radioButton5.TabIndex = 26;
            radioButton5.Text = "Costo";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(5, 50);
            radioButton4.Margin = new Padding(2, 2, 2, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(66, 19);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tiempo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 29);
            radioButton3.Margin = new Padding(2, 2, 2, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 19);
            radioButton3.TabIndex = 24;
            radioButton3.Text = "Distancia";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(776, 24);
            button1.Name = "button1";
            button1.Size = new Size(123, 50);
            button1.TabIndex = 6;
            button1.Text = "Ruta mas corta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(776, 84);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 7;
            button2.Text = "Ruta alterna";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(413, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 289);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(752, 159);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(77, 289);
            listBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 141);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 14;
            label3.Text = "Medio de transporte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 141);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 15;
            label4.Text = "Camino";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(752, 141);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 19;
            label8.Text = "Parametro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 471);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 20;
            label9.Text = "TOTALES";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(211, 166);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(581, 467);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 25;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 538);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Búsqueda de información";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}