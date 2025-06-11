namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click += async (s, e) => { for (int i = 0; i <= 100; i++) { await Task.Delay(50); progressBar1.Value = i; } };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += (s, e) => progressBar1.Value = 25;

        }
    }
}
