using CineDBteste.Controller;
using CineDBteste.Model;
using System;
using System.Windows.Forms;

namespace CineDBteste.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.RowHeadersWidth = 60;
            AtualizarGrelha();
            dataGridView1.ClearSelection();
        }

        private void AtualizarGrelha()
        {
            dataGridView1.DataSource = Form1Controller.ObterFilmes();

            if (dataGridView1.Columns["DataHoraAlteracao"] != null)
            {
                dataGridView1.Columns["DataHoraAlteracao"].HeaderText = "Data / Hora da alteração";
                dataGridView1.Columns["DataHoraAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }

            if (dataGridView1.Columns["AlteradoPor"] != null)
            {
                dataGridView1.Columns["AlteradoPor"].HeaderText = "Alterado por";
            }

            if (dataGridView1.Columns["VezesVisto"] != null)
            {
                dataGridView1.Columns["VezesVisto"].HeaderText = "N. de visualizações";
            }
        }

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dataGridView1.ClearSelection();
        }

        private void button1Adicionar_Click(object sender, EventArgs e)
        {
            int ano;
            int vezesVisto;

            if (!int.TryParse(textBox3.Text, out ano))
            {
                MessageBox.Show("O ano tem de ser numérico.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out vezesVisto))
            {
                MessageBox.Show("O número de visualizações tem de ser numérico.");
                return;
            }

            string mensagem;
            bool ok = Form1Controller.AdicionarFilme(
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                ano,
                textBox6.Text.Trim(),
                vezesVisto,
                out mensagem
            );

            MessageBox.Show(mensagem);

            if (ok)
            {
                AtualizarGrelha();
                LimparCampos();
            }
        }

        private void button1Editar_Click(object sender, EventArgs e)
        {
            int id;
            int ano;
            int vezesVisto;

            if (!int.TryParse(textBox4.Text, out id))
            {
                MessageBox.Show("O ID tem de ser numérico.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out ano))
            {
                MessageBox.Show("O ano tem de ser numérico.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out vezesVisto))
            {
                MessageBox.Show("O número de visualizações tem de ser numérico.");
                return;
            }

            string mensagem;
            bool ok = Form1Controller.AtualizarFilme(
                id,
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                ano,
                textBox6.Text.Trim(),
                vezesVisto,
                out mensagem
            );

            MessageBox.Show(mensagem);

            if (ok)
            {
                AtualizarGrelha();
                LimparCampos();
            }
        }

        private void button1Remover_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(textBox4.Text, out id))
            {
                MessageBox.Show("O ID tem de ser numérico.");
                return;
            }

            string mensagem;
            bool ok = Form1Controller.RemoverFilme(id, out mensagem);

            MessageBox.Show(mensagem);

            if (ok)
            {
                AtualizarGrelha();
                LimparCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Ficheiros CSV (*.csv)|*.csv";
            sfd.Title = "Guardar ficheiro CSV";
            sfd.FileName = "filmes.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form1Controller.ExportarCsv(sfd.FileName);
                MessageBox.Show("Ficheiro CSV exportado com sucesso.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form3 f3 = new Form3())
            {
                f3.ShowDialog();
            }

            AtualizarGrelha();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.DataBoundItem != null)
            {
                Filmecs filme = (Filmecs)dataGridView1.CurrentRow.DataBoundItem;

                textBox4.Text = filme.Id.ToString();
                textBox1.Text = filme.Titulo;
                textBox2.Text = filme.Genero;
                textBox3.Text = filme.Ano.ToString();
                textBox5.Text = filme.VezesVisto.ToString();
                textBox6.Text = filme.Realizador;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numero = (e.RowIndex + 1).ToString();
            dataGridView1.Rows[e.RowIndex].HeaderCell.Value = numero;
        }
    }
}
