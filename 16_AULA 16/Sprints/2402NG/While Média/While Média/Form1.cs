using System.Runtime.Serialization;

namespace While_Média
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double soma = 0;
        string notas = "";
        string media_ = "";
        bool continuar = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            while (continuar)
            {
                double numero = Convert.ToDouble(txt_dados.Text);
                notas += numero + ", ";
                soma += numero;
                contador++;
                double media = soma / contador;
                media_ += media + ", ";

                MessageBox.Show("A media foi: " + media);
                break;

            }
        }

        private void txt_dados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ('p') || e.KeyChar == ('P'))
            {
                continuar = false;
                MessageBox.Show("Programa encerrando...", "Encerrando");
                Close();
            }

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            txt_dados.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os notas são: " + notas + "\n As médias são: " + media_);
        }
    }
}
