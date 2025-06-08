namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ROJO") 
            {
                BackColor = Color.Red;
            }
            else if (comboBox1.SelectedItem.ToString() == "VERDE") 
            { 
                BackColor = Color.Green;
            }
            else if (comboBox1.SelectedItem.ToString() == "AZUL")
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.Silver;
            }
        }

    
    }
}
