namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"Resultado: {imc:F2}";

            if (imc < 18.5)
            {
                lblCategoria.Text = "Categoria: Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                lblCategoria.Text = "Categoria: Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                lblCategoria.Text = "Categoria: Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                lblCategoria.Text = "Categoria: Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 40)
            {
                lblCategoria.Text = "Categoria: Obesidade Grau II";
            }
            else
            {
                lblCategoria.Text = "Categoria: Obesidade Grau III";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
