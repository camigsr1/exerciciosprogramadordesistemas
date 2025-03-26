
namespace maioroumenorquedez
{
    partial class frmMaiorOuMenor
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
            this.txtMaiorOuMenorQue = new System.Windows.Forms.TextBox();
            this.bntVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaiorOuMenorQue
            // 
            this.txtMaiorOuMenorQue.Location = new System.Drawing.Point(113, 64);
            this.txtMaiorOuMenorQue.Name = "txtMaiorOuMenorQue";
            this.txtMaiorOuMenorQue.Size = new System.Drawing.Size(96, 20);
            this.txtMaiorOuMenorQue.TabIndex = 0;
            this.txtMaiorOuMenorQue.Text = "Digite um número";
            this.txtMaiorOuMenorQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntVerificar
            // 
            this.bntVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntVerificar.Location = new System.Drawing.Point(124, 123);
            this.bntVerificar.Name = "bntVerificar";
            this.bntVerificar.Size = new System.Drawing.Size(75, 23);
            this.bntVerificar.TabIndex = 2;
            this.bntVerificar.Text = "Verificar";
            this.bntVerificar.UseVisualStyleBackColor = true;
            this.bntVerificar.Click += new System.EventHandler(this.bntVerificar_Click);
            // 
            // frmMaiorOuMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 209);
            this.Controls.Add(this.bntVerificar);
            this.Controls.Add(this.txtMaiorOuMenorQue);
            this.Name = "frmMaiorOuMenor";
            this.Text = "Maior ou Menor Que Dez?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaiorOuMenorQue;
        private System.Windows.Forms.Button bntVerificar;
    }
}

