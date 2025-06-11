namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int numero);
            int fahrenheit = (numero * 9 / 5) + 32;
            
            label2.Text = fahrenheit.ToString();
        }
    }
}
