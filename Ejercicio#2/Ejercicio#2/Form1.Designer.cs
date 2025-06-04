namespace Ejercicio_2
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
            labeltext = new Label();
            btnClick = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labeltext
            // 
            labeltext.AutoSize = true;
            labeltext.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltext.ForeColor = Color.FromArgb(192, 0, 0);
            labeltext.Location = new Point(80, 73);
            labeltext.Name = "labeltext";
            labeltext.Size = new Size(657, 33);
            labeltext.TabIndex = 0;
            labeltext.Text = "Este texto cambiara si presionas el boton";
            // 
            // btnClick
            // 
            btnClick.Location = new Point(336, 23);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(123, 23);
            btnClick.TabIndex = 1;
            btnClick.Text = "Yo soy el Boton";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 130);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 2;
            label1.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 154);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Controls.Add(labeltext);
            Name = "Form1";
            Text = "Ejercicio#2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltext;
        private Button btnClick;
        private Label label1;
    }
}
