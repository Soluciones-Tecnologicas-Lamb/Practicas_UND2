namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Busca el archivo de tu interes";
            openFileDialog1.ShowDialog();
            string Texto = openFileDialog1.FileName;
            textBox1.Text = Texto;
            if (File.Exists(openFileDialog1.FileName))
            {
                

                TextReader Leer = new StreamReader(Texto);
                RTextBox.Text = Leer.ReadToEnd();
                Leer.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar el archivo";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, RTextBox.Text);
                MessageBox.Show("Archivo guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
