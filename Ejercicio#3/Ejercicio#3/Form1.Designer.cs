namespace Ejercicio_3
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            labeltext1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(352, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(284, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingresa la palabra que quieres ver en fuente COOPER";
            // 
            // labeltext1
            // 
            labeltext1.AutoSize = true;
            labeltext1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltext1.ForeColor = Color.Green;
            labeltext1.Location = new Point(473, 60);
            labeltext1.Name = "labeltext1";
            labeltext1.Size = new Size(271, 31);
            labeltext1.TabIndex = 3;
            labeltext1.Text = "Previsualizar Aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 144);
            label2.Name = "label2";
            label2.Size = new Size(377, 15);
            label2.TabIndex = 4;
            label2.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 168);
            Controls.Add(label2);
            Controls.Add(labeltext1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ejercicio#3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label labeltext1;
        private Label label2;
    }
}
