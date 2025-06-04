namespace Ejercicio_5
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
            OpcPLD = new RadioButton();
            OpcPRM = new RadioButton();
            OpcFP = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            lblmostrar = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // OpcPLD
            // 
            OpcPLD.AutoSize = true;
            OpcPLD.Location = new Point(144, 45);
            OpcPLD.Name = "OpcPLD";
            OpcPLD.Size = new Size(46, 19);
            OpcPLD.TabIndex = 0;
            OpcPLD.TabStop = true;
            OpcPLD.Text = "PLD";
            OpcPLD.UseVisualStyleBackColor = true;
            // 
            // OpcPRM
            // 
            OpcPRM.AutoSize = true;
            OpcPRM.Location = new Point(268, 45);
            OpcPRM.Name = "OpcPRM";
            OpcPRM.Size = new Size(50, 19);
            OpcPRM.TabIndex = 1;
            OpcPRM.TabStop = true;
            OpcPRM.Text = "PRM";
            OpcPRM.UseVisualStyleBackColor = true;
            // 
            // OpcFP
            // 
            OpcFP.AutoSize = true;
            OpcFP.Location = new Point(398, 45);
            OpcFP.Name = "OpcFP";
            OpcFP.Size = new Size(38, 19);
            OpcFP.TabIndex = 2;
            OpcFP.TabStop = true;
            OpcFP.Text = "FP";
            OpcFP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 15);
            label1.TabIndex = 3;
            label1.Text = "¿A cual de estos tres partidos mayoritarios perteneces?";
            // 
            // button1
            // 
            button1.Location = new Point(253, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblmostrar
            // 
            lblmostrar.AutoSize = true;
            lblmostrar.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmostrar.Location = new Point(128, 136);
            lblmostrar.Name = "lblmostrar";
            lblmostrar.Size = new Size(0, 38);
            lblmostrar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 239);
            label3.Name = "label3";
            label3.Size = new Size(377, 15);
            label3.TabIndex = 6;
            label3.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 263);
            Controls.Add(label3);
            Controls.Add(lblmostrar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(OpcFP);
            Controls.Add(OpcPRM);
            Controls.Add(OpcPLD);
            Name = "Form1";
            Text = "Ejercicio#5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton OpcPLD;
        private RadioButton OpcPRM;
        private RadioButton OpcFP;
        private Label label1;
        private Button button1;
        private Label lblmostrar;
        private Label label3;
    }
}
