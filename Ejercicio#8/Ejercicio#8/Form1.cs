namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int acumulador = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = acumulador.ToString();
            acumulador++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            label3.Text = acumulador.ToString();
        }
    }
}
