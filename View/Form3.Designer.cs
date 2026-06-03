namespace CineDBteste.View
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.lblNomeFilme = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lblIMDb = new System.Windows.Forms.Label();
            this.txtIMDb = new System.Windows.Forms.TextBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.groupBoxOrcamento = new System.Windows.Forms.GroupBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAnoOrcamento = new System.Windows.Forms.TextBox();
            this.lblValorOrcamento = new System.Windows.Forms.Label();
            this.txtValorOrcamento = new System.Windows.Forms.TextBox();
            this.btnGuardarOrcamento = new System.Windows.Forms.Button();
            this.groupBoxEstatisticas = new System.Windows.Forms.GroupBox();
            this.lblTotalFilmes = new System.Windows.Forms.Label();
            this.lblTotalGasto = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblPrecoMedio = new System.Windows.Forms.Label();
            this.lblMelhorIMDb = new System.Windows.Forms.Label();
            this.lblTopFilmes = new System.Windows.Forms.Label();
            this.lstTopFilmes = new System.Windows.Forms.ListBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lstFilmesPorGenero = new System.Windows.Forms.ListBox();
            this.btnAtualizarEstatisticas = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBoxCompra.SuspendLayout();
            this.groupBoxOrcamento.SuspendLayout();
            this.groupBoxEstatisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.lblNomeFilme);
            this.groupBoxCompra.Controls.Add(this.txtNomeFilme);
            this.groupBoxCompra.Controls.Add(this.lblPreco);
            this.groupBoxCompra.Controls.Add(this.txtPrecoCompra);
            this.groupBoxCompra.Controls.Add(this.lblIMDb);
            this.groupBoxCompra.Controls.Add(this.txtIMDb);
            this.groupBoxCompra.Controls.Add(this.lblDataCompra);
            this.groupBoxCompra.Controls.Add(this.dtpDataCompra);
            this.groupBoxCompra.Controls.Add(this.btnGuardarCompra);
            this.groupBoxCompra.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(400, 160);
            this.groupBoxCompra.TabIndex = 0;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Registar Compra";
            // 
            // lblNomeFilme
            // 
            this.lblNomeFilme.AutoSize = true;
            this.lblNomeFilme.Location = new System.Drawing.Point(10, 25);
            this.lblNomeFilme.Name = "lblNomeFilme";
            this.lblNomeFilme.Size = new System.Drawing.Size(73, 13);
            this.lblNomeFilme.TabIndex = 0;
            this.lblNomeFilme.Text = "Nome do filme:";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(120, 22);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(260, 20);
            this.txtNomeFilme.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(10, 52);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(34, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(120, 49);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(120, 20);
            this.txtPrecoCompra.TabIndex = 3;
            // 
            // lblIMDb
            // 
            this.lblIMDb.AutoSize = true;
            this.lblIMDb.Location = new System.Drawing.Point(10, 79);
            this.lblIMDb.Name = "lblIMDb";
            this.lblIMDb.Size = new System.Drawing.Size(86, 13);
            this.lblIMDb.TabIndex = 4;
            this.lblIMDb.Text = "Classificação IMDb:";
            // 
            // txtIMDb
            // 
            this.txtIMDb.Location = new System.Drawing.Point(120, 76);
            this.txtIMDb.Name = "txtIMDb";
            this.txtIMDb.Size = new System.Drawing.Size(120, 20);
            this.txtIMDb.TabIndex = 5;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(10, 106);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(70, 13);
            this.lblDataCompra.TabIndex = 6;
            this.lblDataCompra.Text = "Data de compra:";
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(120, 103);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(160, 20);
            this.dtpDataCompra.TabIndex = 7;
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.Location = new System.Drawing.Point(290, 100);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(90, 28);
            this.btnGuardarCompra.TabIndex = 8;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // groupBoxOrcamento
            // 
            this.groupBoxOrcamento.Controls.Add(this.lblMes);
            this.groupBoxOrcamento.Controls.Add(this.txtMes);
            this.groupBoxOrcamento.Controls.Add(this.lblAno);
            this.groupBoxOrcamento.Controls.Add(this.txtAnoOrcamento);
            this.groupBoxOrcamento.Controls.Add(this.lblValorOrcamento);
            this.groupBoxOrcamento.Controls.Add(this.txtValorOrcamento);
            this.groupBoxOrcamento.Controls.Add(this.btnGuardarOrcamento);
            this.groupBoxOrcamento.Location = new System.Drawing.Point(430, 12);
            this.groupBoxOrcamento.Name = "groupBoxOrcamento";
            this.groupBoxOrcamento.Size = new System.Drawing.Size(360, 160);
            this.groupBoxOrcamento.TabIndex = 1;
            this.groupBoxOrcamento.TabStop = false;
            this.groupBoxOrcamento.Text = "Orçamento Mensal";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(10, 25);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(31, 13);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mês:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(120, 22);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(80, 20);
            this.txtMes.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(10, 52);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(30, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // txtAnoOrcamento
            // 
            this.txtAnoOrcamento.Location = new System.Drawing.Point(120, 49);
            this.txtAnoOrcamento.Name = "txtAnoOrcamento";
            this.txtAnoOrcamento.Size = new System.Drawing.Size(80, 20);
            this.txtAnoOrcamento.TabIndex = 3;
            // 
            // lblValorOrcamento
            // 
            this.lblValorOrcamento.AutoSize = true;
            this.lblValorOrcamento.Location = new System.Drawing.Point(10, 79);
            this.lblValorOrcamento.Name = "lblValorOrcamento";
            this.lblValorOrcamento.Size = new System.Drawing.Size(98, 13);
            this.lblValorOrcamento.TabIndex = 4;
            this.lblValorOrcamento.Text = "Valor do orçamento:";
            // 
            // txtValorOrcamento
            // 
            this.txtValorOrcamento.Location = new System.Drawing.Point(120, 76);
            this.txtValorOrcamento.Name = "txtValorOrcamento";
            this.txtValorOrcamento.Size = new System.Drawing.Size(120, 20);
            this.txtValorOrcamento.TabIndex = 5;
            // 
            // btnGuardarOrcamento
            // 
            this.btnGuardarOrcamento.Location = new System.Drawing.Point(120, 110);
            this.btnGuardarOrcamento.Name = "btnGuardarOrcamento";
            this.btnGuardarOrcamento.Size = new System.Drawing.Size(120, 28);
            this.btnGuardarOrcamento.TabIndex = 6;
            this.btnGuardarOrcamento.Text = "Guardar Orçamento";
            this.btnGuardarOrcamento.UseVisualStyleBackColor = true;
            this.btnGuardarOrcamento.Click += new System.EventHandler(this.btnGuardarOrcamento_Click);
            // 
            // groupBoxEstatisticas
            // 
            this.groupBoxEstatisticas.Controls.Add(this.lblTotalFilmes);
            this.groupBoxEstatisticas.Controls.Add(this.lblTotalGasto);
            this.groupBoxEstatisticas.Controls.Add(this.lblSaldo);
            this.groupBoxEstatisticas.Controls.Add(this.lblPrecoMedio);
            this.groupBoxEstatisticas.Controls.Add(this.lblMelhorIMDb);
            this.groupBoxEstatisticas.Controls.Add(this.lblTopFilmes);
            this.groupBoxEstatisticas.Controls.Add(this.lstTopFilmes);
            this.groupBoxEstatisticas.Controls.Add(this.lblGenero);
            this.groupBoxEstatisticas.Controls.Add(this.lstFilmesPorGenero);
            this.groupBoxEstatisticas.Controls.Add(this.btnAtualizarEstatisticas);
            this.groupBoxEstatisticas.Location = new System.Drawing.Point(12, 185);
            this.groupBoxEstatisticas.Name = "groupBoxEstatisticas";
            this.groupBoxEstatisticas.Size = new System.Drawing.Size(778, 280);
            this.groupBoxEstatisticas.TabIndex = 2;
            this.groupBoxEstatisticas.TabStop = false;
            this.groupBoxEstatisticas.Text = "Estatísticas";
            // 
            // lblTotalFilmes
            // 
            this.lblTotalFilmes.AutoSize = true;
            this.lblTotalFilmes.Location = new System.Drawing.Point(10, 25);
            this.lblTotalFilmes.Name = "lblTotalFilmes";
            this.lblTotalFilmes.Size = new System.Drawing.Size(100, 13);
            this.lblTotalFilmes.TabIndex = 0;
            this.lblTotalFilmes.Text = "Total de filmes: ---";
            // 
            // lblTotalGasto
            // 
            this.lblTotalGasto.AutoSize = true;
            this.lblTotalGasto.Location = new System.Drawing.Point(10, 48);
            this.lblTotalGasto.Name = "lblTotalGasto";
            this.lblTotalGasto.Size = new System.Drawing.Size(90, 13);
            this.lblTotalGasto.TabIndex = 1;
            this.lblTotalGasto.Text = "Total gasto: ---";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(10, 71);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(100, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo disponível: ---";
            // 
            // lblPrecoMedio
            // 
            this.lblPrecoMedio.AutoSize = true;
            this.lblPrecoMedio.Location = new System.Drawing.Point(10, 94);
            this.lblPrecoMedio.Name = "lblPrecoMedio";
            this.lblPrecoMedio.Size = new System.Drawing.Size(90, 13);
            this.lblPrecoMedio.TabIndex = 3;
            this.lblPrecoMedio.Text = "Preço médio: ---";
            // 
            // lblMelhorIMDb
            // 
            this.lblMelhorIMDb.AutoSize = true;
            this.lblMelhorIMDb.Location = new System.Drawing.Point(10, 117);
            this.lblMelhorIMDb.Name = "lblMelhorIMDb";
            this.lblMelhorIMDb.Size = new System.Drawing.Size(85, 13);
            this.lblMelhorIMDb.TabIndex = 4;
            this.lblMelhorIMDb.Text = "Melhor IMDb: ---";
            // 
            // lblTopFilmes
            // 
            this.lblTopFilmes.AutoSize = true;
            this.lblTopFilmes.Location = new System.Drawing.Point(10, 145);
            this.lblTopFilmes.Name = "lblTopFilmes";
            this.lblTopFilmes.Size = new System.Drawing.Size(100, 13);
            this.lblTopFilmes.TabIndex = 5;
            this.lblTopFilmes.Text = "Top filmes mais vistos:";
            // 
            // lstTopFilmes
            // 
            this.lstTopFilmes.FormattingEnabled = true;
            this.lstTopFilmes.Location = new System.Drawing.Point(10, 162);
            this.lstTopFilmes.Name = "lstTopFilmes";
            this.lstTopFilmes.Size = new System.Drawing.Size(360, 95);
            this.lstTopFilmes.TabIndex = 6;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(390, 145);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(110, 13);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Filmes por género:";
            // 
            // lstFilmesPorGenero
            // 
            this.lstFilmesPorGenero.FormattingEnabled = true;
            this.lstFilmesPorGenero.Location = new System.Drawing.Point(390, 162);
            this.lstFilmesPorGenero.Name = "lstFilmesPorGenero";
            this.lstFilmesPorGenero.Size = new System.Drawing.Size(360, 95);
            this.lstFilmesPorGenero.TabIndex = 8;
            // 
            // btnAtualizarEstatisticas
            // 
            this.btnAtualizarEstatisticas.Location = new System.Drawing.Point(580, 20);
            this.btnAtualizarEstatisticas.Name = "btnAtualizarEstatisticas";
            this.btnAtualizarEstatisticas.Size = new System.Drawing.Size(170, 28);
            this.btnAtualizarEstatisticas.TabIndex = 9;
            this.btnAtualizarEstatisticas.Text = "Atualizar e Exportar CSV";
            this.btnAtualizarEstatisticas.UseVisualStyleBackColor = true;
            this.btnAtualizarEstatisticas.Click += new System.EventHandler(this.btnAtualizarEstatisticas_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(12, 480);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(778, 200);
            this.dgvCompras.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(700, 690);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 28);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 730);
            this.Controls.Add(this.groupBoxCompra);
            this.Controls.Add(this.groupBoxOrcamento);
            this.Controls.Add(this.groupBoxEstatisticas);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(830, 770);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineDB — Compras e Estatísticas";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxCompra.PerformLayout();
            this.groupBoxOrcamento.ResumeLayout(false);
            this.groupBoxOrcamento.PerformLayout();
            this.groupBoxEstatisticas.ResumeLayout(false);
            this.groupBoxEstatisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.Label lblNomeFilme;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label lblIMDb;
        private System.Windows.Forms.TextBox txtIMDb;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.GroupBox groupBoxOrcamento;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAnoOrcamento;
        private System.Windows.Forms.Label lblValorOrcamento;
        private System.Windows.Forms.TextBox txtValorOrcamento;
        private System.Windows.Forms.Button btnGuardarOrcamento;
        private System.Windows.Forms.GroupBox groupBoxEstatisticas;
        private System.Windows.Forms.Label lblTotalFilmes;
        private System.Windows.Forms.Label lblTotalGasto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblPrecoMedio;
        private System.Windows.Forms.Label lblMelhorIMDb;
        private System.Windows.Forms.Label lblTopFilmes;
        private System.Windows.Forms.ListBox lstTopFilmes;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ListBox lstFilmesPorGenero;
        private System.Windows.Forms.Button btnAtualizarEstatisticas;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnFechar;
    }
}
