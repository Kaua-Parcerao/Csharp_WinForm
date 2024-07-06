namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bdm_IMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pares = textBoxDados.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string resultados = "";
                for (int i = 0; i < pares.Length; i++)
                {
                    string[] valores = pares[i].Split(',');
                    if (valores.Length != 2)
                    {
                        MessageBox.Show("Por favor, insira pares de peso e altura váidos.");
                        return;
                    }
                    double peso = Convert.ToDouble(valores[0]);
                    double altura = Convert.ToDouble(valores[1]);

                    double imc = (peso / (altura * altura)) * 10 * 10 * 10;

                    //Categoria
                    string categoria = "";

                    if (imc <= 18.5)
                    {
                        categoria = "Abaixo do peso";
                    }
                    else if (imc > 18.5 && imc <= 24.9)
                    {
                        categoria = "Peso normal";
                    }
                    else if (imc >= 25.0 && imc <= 29.9)
                    {
                        categoria = "Sobre peso";
                    }
                    else if (imc >= 30.0 && imc <= 34.9)
                    {
                        categoria = "Obsidade grau I";
                    }
                    else if (imc >= 35.0 && imc <= 39.9)
                    {
                        categoria = "Obsidade grau II";
                    }
                    else
                    {
                        categoria = "Obsidade grau III";
                    }
                    resultados += $"Par {i + 1}: IMC = {imc:F2} Categoria = {categoria}\n";

                }
                lbl_resultado.Text = "Resultado do IMC:\n" + resultados;
                MessageBox.Show(resultados, "Resultados do IMC");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor informe um numero válido.");
            }
        }

        private void resetar_Click(object sender, EventArgs e)
        {
            textBoxDados.Text = " ";
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}