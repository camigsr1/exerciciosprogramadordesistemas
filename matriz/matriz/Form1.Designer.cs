
namespace matriz
{
    partial class frmMatriz
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
            this.lblValoresMatriz = new System.Windows.Forms.Label();
            this.txtValorInserido = new System.Windows.Forms.TextBox();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.btnMostrarMaior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValoresMatriz
            // 
            this.lblValoresMatriz.AutoSize = true;
            this.lblValoresMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoresMatriz.Location = new System.Drawing.Point(46, 22);
            this.lblValoresMatriz.Name = "lblValoresMatriz";
            this.lblValoresMatriz.Size = new System.Drawing.Size(226, 20);
            this.lblValoresMatriz.TabIndex = 0;
            this.lblValoresMatriz.Text = "Entre com os valores da matriz";
            // 
            // txtValorInserido
            // 
            this.txtValorInserido.Location = new System.Drawing.Point(107, 56);
            this.txtValorInserido.Name = "txtValorInserido";
            this.txtValorInserido.Size = new System.Drawing.Size(94, 20);
            this.txtValorInserido.TabIndex = 1;
            this.txtValorInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorInserido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorInserido_KeyPress);
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriz.Location = new System.Drawing.Point(86, 92);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(143, 29);
            this.btnMostrarMatriz.TabIndex = 2;
            this.btnMostrarMatriz.Text = "Mostrar Matriz";
            this.btnMostrarMatriz.UseVisualStyleBackColor = true;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click);
            // 
            // txtMatriz
            // 
            this.txtMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriz.Location = new System.Drawing.Point(50, 194);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(210, 122);
            this.txtMatriz.TabIndex = 3;
            // 
            // btnMostrarMaior
            // 
            this.btnMostrarMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMaior.Location = new System.Drawing.Point(86, 127);
            this.btnMostrarMaior.Name = "btnMostrarMaior";
            this.btnMostrarMaior.Size = new System.Drawing.Size(143, 51);
            this.btnMostrarMaior.TabIndex = 4;
            this.btnMostrarMaior.Text = "Mostrar Maior Valor";
            this.btnMostrarMaior.UseVisualStyleBackColor = true;
            this.btnMostrarMaior.Click += new System.EventHandler(this.btnMostrarMaior_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 364);
            this.Controls.Add(this.btnMostrarMaior);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Controls.Add(this.txtValorInserido);
            this.Controls.Add(this.lblValoresMatriz);
            this.MaximizeBox = false;
            this.Name = "frmMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValoresMatriz;
        private System.Windows.Forms.TextBox txtValorInserido;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button btnMostrarMaior;
    }
}

