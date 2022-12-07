namespace ProjetoAula01
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
            this.Botao1 = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.BackColor = System.Drawing.Color.Black;
            this.Botao1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao1.ForeColor = System.Drawing.Color.White;
            this.Botao1.Location = new System.Drawing.Point(12, 12);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(224, 85);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Clique";
            this.Botao1.UseVisualStyleBackColor = false;
            this.Botao1.Click += new System.EventHandler(this.Botao1_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.AutoSize = true;
            this.mensagem1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem1.ForeColor = System.Drawing.Color.Blue;
            this.mensagem1.Location = new System.Drawing.Point(12, 111);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(128, 42);
            this.mensagem1.TabIndex = 1;
            this.mensagem1.Text = "label1";
            this.mensagem1.Click += new System.EventHandler(this.mensagemClicada);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.Botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.Label mensagem1;
    }
}

