using System;
using System.Windows.Forms;
using CineDBteste.Controller;

namespace CineDBteste.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1Password.UseSystemPasswordChar = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1Entrar_Click(object sender, EventArgs e)
        {
            string mensagem;

            bool ok = Form2Controller.Autenticar(
                textBox1Username.Text.Trim(),
                textBox1Password.Text,
                out mensagem
            );

            MessageBox.Show(mensagem);

            if (ok)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
