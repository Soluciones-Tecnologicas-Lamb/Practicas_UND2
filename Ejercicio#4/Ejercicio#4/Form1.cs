using System.Globalization;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnclick_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int resultado = num1 + num2;
            labelresult.Text = resultado.ToString();
        }

        
    }
}
