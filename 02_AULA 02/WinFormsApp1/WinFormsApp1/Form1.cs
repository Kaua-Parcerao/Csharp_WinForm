namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // O texto do label ser� alterado para o texto digitado no textbox
            label1.Text = "Ol�, " + textBox1.Text + "! Seja bem-vindo (a) ao curso de C# :)";
        }
    }
}
