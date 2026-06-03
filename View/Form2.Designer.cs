namespace CineDBteste.View
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.textBox1Password = new System.Windows.Forms.TextBox();
            this.button1Entrar = new System.Windows.Forms.Button();
            this.button2Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizador (login):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(130, 37);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(200, 20);
            this.textBox1Username.TabIndex = 2;
            // 
            // textBox1Password
            // 
            this.textBox1Password.Location = new System.Drawing.Point(130, 77);
            this.textBox1Password.Name = "textBox1Password";
            this.textBox1Password.Size = new System.Drawing.Size(200, 20);
            this.textBox1Password.TabIndex = 3;
            // 
            // button1Entrar
            // 
            this.button1Entrar.Location = new System.Drawing.Point(130, 120);
            this.button1Entrar.Name = "button1Entrar";
            this.button1Entrar.Size = new System.Drawing.Size(90, 30);
            this.button1Entrar.TabIndex = 4;
            this.button1Entrar.Text = "Entrar";
            this.button1Entrar.UseVisualStyleBackColor = true;
            this.button1Entrar.Click += new System.EventHandler(this.button1Entrar_Click);
            // 
            // button2Cancelar
            // 
            this.button2Cancelar.Location = new System.Drawing.Point(240, 120);
            this.button2Cancelar.Name = "button2Cancelar";
            this.button2Cancelar.Size = new System.Drawing.Size(90, 30);
            this.button2Cancelar.TabIndex = 5;
            this.button2Cancelar.Text = "Cancelar";
            this.button2Cancelar.UseVisualStyleBackColor = true;
            this.button2Cancelar.Click += new System.EventHandler(this.button2Cancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.textBox1Password);
            this.Controls.Add(this.button1Entrar);
            this.Controls.Add(this.button2Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineDB — Autenticação";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.TextBox textBox1Password;
        private System.Windows.Forms.Button button1Entrar;
        private System.Windows.Forms.Button button2Cancelar;
    }
}
