namespace CineDBteste.View
{
    partial class Form1
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
            this.label1Titulo = new System.Windows.Forms.Label();
            this.label2Genero = new System.Windows.Forms.Label();
            this.label3Ano = new System.Windows.Forms.Label();
            this.label4Id = new System.Windows.Forms.Label();
            this.label5VezesVisto = new System.Windows.Forms.Label();
            this.label6Realizador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.button1Editar = new System.Windows.Forms.Button();
            this.button1Remover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Titulo
            // 
            this.label1Titulo.AutoSize = true;
            this.label1Titulo.Location = new System.Drawing.Point(12, 15);
            this.label1Titulo.Name = "label1Titulo";
            this.label1Titulo.Size = new System.Drawing.Size(34, 13);
            this.label1Titulo.TabIndex = 0;
            this.label1Titulo.Text = "Título:";
            // 
            // label2Genero
            // 
            this.label2Genero.AutoSize = true;
            this.label2Genero.Location = new System.Drawing.Point(12, 42);
            this.label2Genero.Name = "label2Genero";
            this.label2Genero.Size = new System.Drawing.Size(43, 13);
            this.label2Genero.TabIndex = 1;
            this.label2Genero.Text = "Género:";
            // 
            // label3Ano
            // 
            this.label3Ano.AutoSize = true;
            this.label3Ano.Location = new System.Drawing.Point(12, 69);
            this.label3Ano.Name = "label3Ano";
            this.label3Ano.Size = new System.Drawing.Size(30, 13);
            this.label3Ano.TabIndex = 2;
            this.label3Ano.Text = "Ano:";
            // 
            // label4Id
            // 
            this.label4Id.AutoSize = true;
            this.label4Id.Location = new System.Drawing.Point(12, 96);
            this.label4Id.Name = "label4Id";
            this.label4Id.Size = new System.Drawing.Size(22, 13);
            this.label4Id.TabIndex = 3;
            this.label4Id.Text = "ID:";
            // 
            // label5VezesVisto
            // 
            this.label5VezesVisto.AutoSize = true;
            this.label5VezesVisto.Location = new System.Drawing.Point(12, 123);
            this.label5VezesVisto.Name = "label5VezesVisto";
            this.label5VezesVisto.Size = new System.Drawing.Size(95, 13);
            this.label5VezesVisto.TabIndex = 4;
            this.label5VezesVisto.Text = "Vezes Visto:";
            // 
            // label6Realizador
            // 
            this.label6Realizador.AutoSize = true;
            this.label6Realizador.Location = new System.Drawing.Point(12, 150);
            this.label6Realizador.Name = "label6Realizador";
            this.label6Realizador.Size = new System.Drawing.Size(62, 13);
            this.label6Realizador.TabIndex = 5;
            this.label6Realizador.Text = "Realizador:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 20);
            this.textBox6.TabIndex = 11;
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.Location = new System.Drawing.Point(12, 185);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(80, 28);
            this.button1Adicionar.TabIndex = 12;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = true;
            this.button1Adicionar.Click += new System.EventHandler(this.button1Adicionar_Click);
            // 
            // button1Editar
            // 
            this.button1Editar.Location = new System.Drawing.Point(100, 185);
            this.button1Editar.Name = "button1Editar";
            this.button1Editar.Size = new System.Drawing.Size(80, 28);
            this.button1Editar.TabIndex = 13;
            this.button1Editar.Text = "Editar";
            this.button1Editar.UseVisualStyleBackColor = true;
            this.button1Editar.Click += new System.EventHandler(this.button1Editar_Click);
            // 
            // button1Remover
            // 
            this.button1Remover.Location = new System.Drawing.Point(188, 185);
            this.button1Remover.Name = "button1Remover";
            this.button1Remover.Size = new System.Drawing.Size(80, 28);
            this.button1Remover.TabIndex = 14;
            this.button1Remover.Text = "Remover";
            this.button1Remover.UseVisualStyleBackColor = true;
            this.button1Remover.Click += new System.EventHandler(this.button1Remover_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Exportar CSV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "Compras / Stats";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(960, 330);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.label1Titulo);
            this.Controls.Add(this.label2Genero);
            this.Controls.Add(this.label3Ano);
            this.Controls.Add(this.label4Id);
            this.Controls.Add(this.label5VezesVisto);
            this.Controls.Add(this.label6Realizador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button1Editar);
            this.Controls.Add(this.button1Remover);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1000, 610);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineDB — Gestão de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1Titulo;
        private System.Windows.Forms.Label label2Genero;
        private System.Windows.Forms.Label label3Ano;
        private System.Windows.Forms.Label label4Id;
        private System.Windows.Forms.Label label5VezesVisto;
        private System.Windows.Forms.Label label6Realizador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.Button button1Editar;
        private System.Windows.Forms.Button button1Remover;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
