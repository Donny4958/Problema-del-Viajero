namespace ProyectoFinal
{
    partial class Form6
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
            button9 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(29, 229);
            button9.Margin = new Padding(2, 2, 2, 2);
            button9.Name = "button9";
            button9.Size = new Size(164, 20);
            button9.TabIndex = 0;
            button9.Text = "Cambiar de nombre";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(373, 229);
            button10.Margin = new Padding(2, 2, 2, 2);
            button10.Name = "button10";
            button10.Size = new Size(78, 20);
            button10.TabIndex = 1;
            button10.Text = "Cerrar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 89);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(59, 33);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(79, 10);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(91, 15);
            label20.TabIndex = 4;
            label20.Text = "Nombre Actual:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(69, 65);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(92, 15);
            label21.TabIndex = 5;
            label21.Text = "Nombre Nuevo:";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button button10;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label20;
        private Label label21;
    }
}