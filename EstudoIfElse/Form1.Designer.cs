namespace EstudoIfElse
{
    partial class frmIfElse
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
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnVerificarIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade:";
            // 
            // txbIdade
            // 
            this.txbIdade.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdade.Location = new System.Drawing.Point(85, 17);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(65, 26);
            this.txbIdade.TabIndex = 1;
            // 
            // btnVerificarIdade
            // 
            this.btnVerificarIdade.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarIdade.Location = new System.Drawing.Point(165, 14);
            this.btnVerificarIdade.Name = "btnVerificarIdade";
            this.btnVerificarIdade.Size = new System.Drawing.Size(119, 33);
            this.btnVerificarIdade.TabIndex = 2;
            this.btnVerificarIdade.Text = "Verificar";
            this.btnVerificarIdade.UseVisualStyleBackColor = true;
            this.btnVerificarIdade.Click += new System.EventHandler(this.btnVerificarIdade_Click);
            // 
            // frmIfElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 100);
            this.Controls.Add(this.btnVerificarIdade);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label1);
            this.Name = "frmIfElse";
            this.Text = "TreinaWeb - Estudo de IF/ELSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button btnVerificarIdade;
    }
}

