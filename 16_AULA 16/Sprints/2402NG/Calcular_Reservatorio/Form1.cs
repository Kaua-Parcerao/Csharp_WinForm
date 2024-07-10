namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Capacidade total
                double altura = Convert.ToDouble(textBox1.Text);
                double largura = Convert.ToDouble(textBox2.Text);
                double comprimento = Convert.ToDouble(textBox3.Text);


                //Calcular capacidade total em litros
                double capacidade = (altura * largura * comprimento) / 1000;
                labelCapacidadetotal.Text = "A capacidade total: " + capacidade + " litro(s)";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira n�meros v�lidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Autonomia do reservat�rio em dias


                    double altura = Convert.ToDouble(textBox1.Text);
                    double largura = Convert.ToDouble(textBox2.Text);
                    double comprimento = Convert.ToDouble(textBox3.Text);


                    //Calcular capacidade total em litros
                    double capacidade = (altura * largura * comprimento);
                    double capacidadelitros = (altura * largura * comprimento) / 1000;

                    //autonomia diaria
                    double autonomia = Convert.ToDouble(textBox4.Text);
                    double autonomiadiario = capacidadelitros / autonomia;
                    double autonomiadiario2 = Math.Round(autonomiadiario, 2);

                    labelAutonomia.Text = "A autonomia do reservat�rio: " + autonomiadiario2 + " litros";

                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira n�meros v�lidos");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Classifica��o de consumo


                double altura = Convert.ToDouble(textBox1.Text);
                double largura = Convert.ToDouble(textBox2.Text);
                double comprimento = Convert.ToDouble(textBox3.Text);


                //Calcular capacidade total em litros
                double capacidade = (altura * largura * comprimento);
                double capacidadelitros = (altura * largura * comprimento) / 1000;

                //autonomia diaria
                double autonomia = Convert.ToDouble(textBox4.Text);
                double autonomiadiario = capacidadelitros / autonomia;


                //classifica��o do consumo

                if (autonomiadiario < 2)
                {
                    labelClassificacao.Text = "Consumo elevado ";
                }
                else if (autonomiadiario <= 2 & autonomiadiario >= 7)
                {
                    labelClassificacao.Text = "Consumo moderado ";
                }
                else
                {
                    labelClassificacao.Text = "Consumo reduzido ";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira n�meros v�lidos");
            }
        }
    }
}
