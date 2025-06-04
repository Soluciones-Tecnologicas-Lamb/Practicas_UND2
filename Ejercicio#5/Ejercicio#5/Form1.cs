namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpcPLD.Checked)
                lblmostrar.Text = "Eres miembro del PLD";
            else if (OpcPRM.Checked)
                lblmostrar.Text = "Eres miembro del PRM";
            else if (OpcFP.Checked)
                lblmostrar.Text = "Eres miembro de FP";
            else
                lblmostrar.Text = "Por favor, selecciona una opción.";
  
        }
    }
}
