namespace Temperatura
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double soma = 0;
        string nomes = "";
        public Form1()
        {
            ;
            InitializeComponent();
        }

        private void btn_temp_Click(object sender, EventArgs e)
        {
            try {
                
                double temperatura = Convert.ToDouble(txt_temp.Text);
                string nome = txt_nome.Text;

                while (true)
                {
                    if (temperatura <= 37.2)
                    {
                        MessageBox.Show(nome + " sua temperatura esta normal!", "Temperatura!");
                        soma += temperatura;
                        nomes += nome + ", ";
                        contador++;
                        txt_temp.Text = "";
                        txt_nome.Text = "";
                        break;
                    }
                    if (temperatura > 37.3 && temperatura < 38)
                    {
                        MessageBox.Show(nome + " esta febril!", "Temperatura!");
                        soma += temperatura;
                        nomes += nome + ", ";
                        contador++;
                        txt_temp.Text = "";
                        txt_nome.Text = "";
                        break;
                    }
                    if (temperatura > 38 && temperatura < 39)
                    {
                        MessageBox.Show(nome + " esta com febre!", "Temperatura!");
                        soma += temperatura;
                        nomes += nome + ", ";
                        contador++;
                        txt_temp.Text = "";
                        txt_nome.Text = "";
                        break;
                    }
                    if (temperatura > 39)
                    {
                        MessageBox.Show(nome + " esta com muita febre!", "Temperatura!");
                        soma += temperatura;
                        nomes += nome + ", ";
                        contador++;
                        txt_temp.Text = "";
                        txt_nome.Text = "";
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dígite algo válido!", "Validação!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Ainda não ocorreu nenhuma medição!");
            }
            if (contador != 0)
            {
                MessageBox.Show("O total de pessoas foram: " + contador + "!" + "\n Média de temperatura: " + (soma / contador) + "!" + "\n Os nomes são: " + nomes);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_temp.Text = "";
            txt_nome.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O numero do hospital é: 192", "Hospital");
        }
    }
}
