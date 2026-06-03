using System;
using System.Windows.Forms;
using CineDBteste.Controller;
using CineDBteste.Model;

namespace CineDBteste.View
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvCompras.AutoGenerateColumns = true;
            txtMes.Text = DateTime.Today.Month.ToString();
            txtAnoOrcamento.Text = DateTime.Today.Year.ToString();

            AtualizarCompras();
            AtualizarEstatisticas();
        }

        private void AtualizarCompras()
        {
            dgvCompras.DataSource = Form3Controller.ObterCompras();
        }

        private void AtualizarEstatisticas()
        {
            int mes;
            int ano;

            if (!int.TryParse(txtMes.Text, out mes))
            {
                mes = DateTime.Today.Month;
            }

            if (!int.TryParse(txtAnoOrcamento.Text, out ano))
            {
                ano = DateTime.Today.Year;
            }

            ResumoEstatisticas resumo = Form3Controller.ObterEstatisticas(mes, ano);

            lblTotalFilmes.Text = "Total de filmes: " + resumo.TotalFilmes;
            lblTotalGasto.Text = "Total gasto: " + resumo.TotalGasto.ToString("0.00") + " €";
            lblSaldo.Text = "Saldo disponível: " + resumo.Saldo.ToString("0.00") + " €";
            lblPrecoMedio.Text = "Preço médio: " + resumo.PrecoMedio.ToString("0.00") + " €";
            lblMelhorIMDb.Text = "Melhor IMDb: " + resumo.MelhorIMDbTexto;

            lstTopFilmes.Items.Clear();
            foreach (string item in resumo.TopFilmes)
            {
                lstTopFilmes.Items.Add(item);
            }

            lstFilmesPorGenero.Items.Clear();
            foreach (string item in resumo.FilmesPorGenero)
            {
                lstFilmesPorGenero.Items.Add(item);
            }
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            decimal preco;
            decimal nota;

            if (!decimal.TryParse(txtPrecoCompra.Text, out preco))
            {
                MessageBox.Show("O preço tem de ser numérico.");
                return;
            }

            if (!decimal.TryParse(txtIMDb.Text, out nota))
            {
                MessageBox.Show("A classificação IMDb tem de ser numérica.");
                return;
            }

            string mensagem;
            bool ok = Form3Controller.RegistarCompra(
                txtNomeFilme.Text.Trim(),
                preco,
                nota,
                dtpDataCompra.Value.Date,
                out mensagem
            );

            MessageBox.Show(mensagem);

            if (ok)
            {
                AtualizarCompras();
                AtualizarEstatisticas();
                txtNomeFilme.Text = "";
                txtPrecoCompra.Text = "";
                txtIMDb.Text = "";
            }
        }

        private void btnGuardarOrcamento_Click(object sender, EventArgs e)
        {
            int mes;
            int ano;
            decimal valor;

            if (!int.TryParse(txtMes.Text, out mes))
            {
                MessageBox.Show("O mês tem de ser numérico.");
                return;
            }

            if (!int.TryParse(txtAnoOrcamento.Text, out ano))
            {
                MessageBox.Show("O ano tem de ser numérico.");
                return;
            }

            if (!decimal.TryParse(txtValorOrcamento.Text, out valor))
            {
                MessageBox.Show("O valor do orçamento tem de ser numérico.");
                return;
            }

            string mensagem;
            bool ok = Form3Controller.GuardarOrcamento(mes, ano, valor, out mensagem);

            MessageBox.Show(mensagem);

            if (ok)
            {
                AtualizarEstatisticas();
            }
        }

        private void btnAtualizarEstatisticas_Click(object sender, EventArgs e)
        {
            int mes;
            int ano;

            if (!int.TryParse(txtMes.Text, out mes))
            {
                mes = DateTime.Today.Month;
            }

            if (!int.TryParse(txtAnoOrcamento.Text, out ano))
            {
                ano = DateTime.Today.Year;
            }

            AtualizarEstatisticas();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Ficheiros CSV (*.csv)|*.csv";
            sfd.Title = "Guardar estatísticas em CSV";
            sfd.FileName = "estatisticas_filmes.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form3Controller.ExportarEstatisticasCsv(sfd.FileName, mes, ano);
                MessageBox.Show("Estatísticas exportadas com sucesso.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
