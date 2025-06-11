namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables para limpieza
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1)
                textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Btn_punto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void Btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void Btn_multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void Btn_division_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void Btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{num1 + num2}";
                    break;
            case "-":
                    textBox1.Text = $"{num1 - num2}";
                    break;
            case "*":
                    textBox1.Text = $"{num1 * num2}";
                    break;
            case "/":
                    textBox1.Text = $"{num1 / num2}";
                    break;
            }
        }
    }
}
