namespace ProyectoFinal
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Ciudad de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 99);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "Ciudad donde termina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 154);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Distancia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(448, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(448, 23);
            comboBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 154);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Kms";
            // 
            // button4
            // 
            button4.Location = new Point(28, 412);
            button4.Name = "button4";
            button4.Size = new Size(159, 69);
            button4.TabIndex = 9;
            button4.Text = "Alta de la ruta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(237, 412);
            button5.Name = "button5";
            button5.Size = new Size(159, 69);
            button5.TabIndex = 10;
            button5.Text = "Baja de la ruta";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(444, 412);
            button6.Name = "button6";
            button6.Size = new Size(159, 69);
            button6.TabIndex = 11;
            button6.Text = "Cambio de dato";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(34, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 81);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos si se utiliza auto rentado";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(224, 52);
            numericUpDown3.Margin = new Padding(2);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(216, 23);
            numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(234, 24);
            numericUpDown2.Margin = new Padding(2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(216, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(456, 56);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 17;
            label11.Text = "pesos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(454, 30);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 16;
            label10.Text = "minutos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 51);
            label7.Name = "label7";
            label7.Size = new Size(190, 15);
            label7.TabIndex = 1;
            label7.Text = "Costo si se recorre en auto rentado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 25);
            label6.Name = "label6";
            label6.Size = new Size(200, 15);
            label6.TabIndex = 0;
            label6.Text = "Tiempo si se recorre en auto rentado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown5);
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(34, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 82);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos si se utiliza transporte público";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(254, 51);
            numericUpDown5.Margin = new Padding(2);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(216, 23);
            numericUpDown5.TabIndex = 20;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(260, 28);
            numericUpDown4.Margin = new Padding(2);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(216, 23);
            numericUpDown4.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(482, 59);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 18;
            label13.Text = "pesos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(482, 32);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 18;
            label12.Text = "minutos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 51);
            label9.Name = "label9";
            label9.Size = new Size(219, 15);
            label9.TabIndex = 3;
            label9.Text = "Costo si se recorre en transporte público";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 27);
            label8.Name = "label8";
            label8.Size = new Size(229, 15);
            label8.TabIndex = 2;
            label8.Text = "Tiempo si se recorre en transporte público";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 154);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 512);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Ruta";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
    }
}