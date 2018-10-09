namespace ListaProdutos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputLista = new System.Windows.Forms.TextBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.removerTudo = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.boxLista = new System.Windows.Forms.ListBox();
            this.dataHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // inputLista
            // 
            this.inputLista.Location = new System.Drawing.Point(75, 54);
            this.inputLista.Name = "inputLista";
            this.inputLista.Size = new System.Drawing.Size(263, 20);
            this.inputLista.TabIndex = 1;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(368, 52);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 2;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(368, 98);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 3;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // removerTudo
            // 
            this.removerTudo.Location = new System.Drawing.Point(368, 142);
            this.removerTudo.Name = "removerTudo";
            this.removerTudo.Size = new System.Drawing.Size(75, 41);
            this.removerTudo.TabIndex = 4;
            this.removerTudo.Text = "Remover tudo";
            this.removerTudo.UseVisualStyleBackColor = true;
            this.removerTudo.Click += new System.EventHandler(this.removerTudo_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(368, 206);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(368, 390);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 6;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // boxLista
            // 
            this.boxLista.FormattingEnabled = true;
            this.boxLista.Location = new System.Drawing.Point(75, 98);
            this.boxLista.Name = "boxLista";
            this.boxLista.Size = new System.Drawing.Size(263, 316);
            this.boxLista.TabIndex = 7;
            // 
            // dataHora
            // 
            this.dataHora.AutoSize = true;
            this.dataHora.Location = new System.Drawing.Point(12, 428);
            this.dataHora.Name = "dataHora";
            this.dataHora.Size = new System.Drawing.Size(30, 13);
            this.dataHora.TabIndex = 8;
            this.dataHora.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.dataHora);
            this.Controls.Add(this.boxLista);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.removerTudo);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.inputLista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLista;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button removerTudo;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.ListBox boxLista;
        private System.Windows.Forms.Label dataHora;
    }
}

