namespace Ejercicio_4
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
            label1 = new Label();
            labelval1 = new Label();
            labelval2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelresult = new Label();
            btnclick = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 168);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 0;
            label1.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // labelval1
            // 
            labelval1.AutoSize = true;
            labelval1.Location = new Point(34, 27);
            labelval1.Name = "labelval1";
            labelval1.Size = new Size(49, 15);
            labelval1.TabIndex = 1;
            labelval1.Text = "Valor #1";
            // 
            // labelval2
            // 
            labelval2.AutoSize = true;
            labelval2.Location = new Point(34, 85);
            labelval2.Name = "labelval2";
            labelval2.Size = new Size(49, 15);
            labelval2.TabIndex = 2;
            labelval2.Text = "Valor #2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // labelresult
            // 
            labelresult.AutoSize = true;
            labelresult.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelresult.Location = new Point(363, 62);
            labelresult.Name = "labelresult";
            labelresult.Size = new Size(202, 36);
            labelresult.TabIndex = 5;
            labelresult.Text = "Mostrar Aqui";
            // 
            // btnclick
            // 
            btnclick.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnclick.Location = new Point(180, 57);
            btnclick.Name = "btnclick";
            btnclick.Size = new Size(92, 43);
            btnclick.TabIndex = 6;
            btnclick.Text = "Sumar =";
            btnclick.UseVisualStyleBackColor = true;
            btnclick.Click += btnclick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 192);
            Controls.Add(btnclick);
            Controls.Add(labelresult);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelval2);
            Controls.Add(labelval1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio#4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelval1;
        private Label labelval2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelresult;
        private Button btnclick;
    }
}
