using System;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        double tabuada = 0;
        double numero = 0;
        int acerto = 0;
        int erro = 0;
        bool continuar = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double num = Convert.ToDouble(txt_numero.Text);
                txt_numero.Text = "";
                txt_resultado.Text = "";

                numero += num;
                lbl_conta.Text = tabuada + " X " + num + " = ";
            }
            catch
            {
                MessageBox.Show("Coloque um número válido!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double resultado = Convert.ToDouble(txt_resultado.Text);
                double resolucao = tabuada * numero;
                txt_numero.Text = "";
                txt_resultado.Text = "";

                while (continuar)
                {
                    if (resultado == resolucao)
                    {
                        MessageBox.Show("Acertou!");
                        tabuada++;
                        acerto++;
                        lbl_conta.Text = tabuada + " x " + numero + " = ";
                        break;
                    }
                    if (resultado != resolucao)
                    {
                        MessageBox.Show("Errou!");
                        tabuada++;
                        erro++;
                        lbl_conta.Text = tabuada + " X " + numero + " = ";
                        break;
                    }
                }
                if (tabuada == 10)
                {

                    MessageBox.Show("Você acertou: " + acerto + "\n Você errou: " + erro, "Tabuada finalizada!");
                    tabuada = 0;
                    numero = 0;
                    acerto = 0;
                    erro = 0;
                    lbl_conta.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Coloque um número válido!");
            }
        }

        private void btn_tabuada_Click(object sender, EventArgs e)
        {

        }

        private void btn_tabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == 'a')
                {
                    MessageBox.Show("A tabuada do numero: " + numero + "\n" + "1" + " x " + numero + " = " + (numero * 1) + "\n" + "2" + " x " + numero + " = " + (numero * 2) + "\n" + "3" + " x " + numero + " = " + (numero * 3) + "\n" + "4" + " x " + numero + " = " + (numero * 4) + "\n" + "5" + " x " + numero + " = " + (numero * 5));
                }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}