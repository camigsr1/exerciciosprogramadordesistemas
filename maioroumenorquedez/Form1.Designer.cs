
namespace maioroumenorquedez
{
    partial class frmMaiorouMenor
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(153, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "É maior ou menor que 10?";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(157, 96);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(222, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExibir.Location = new System.Drawing.Point(235, 123);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // frmMaiorouMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 226);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMaiorouMenor";
            this.Text = "É maior ou menor que 10?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnExibir;
    }
}

