namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("¡Error no es un numero!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (double.TryParse(textBox1.Text, out _)) 
            {
                MessageBox.Show("¡Este valor es un numero!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Ingresa un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
