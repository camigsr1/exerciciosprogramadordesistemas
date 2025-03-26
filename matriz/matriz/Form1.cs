using System;
using System.Windows.Forms;

namespace matriz
{
    public partial class frmMatriz : Form
    {
        private double[,] TabelaMatriz = new double[3, 3];
        private int i = 0;
        private int j = 0;

        public frmMatriz()
        {
            InitializeComponent();

        }

        private void btnMostrarMatriz_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = "";

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    txtMatriz.Text += TabelaMatriz[i, j].ToString() + "\t";
                }
                txtMatriz.Text += Environment.NewLine + Environment.NewLine;
            }

            i = j = 0; // Reset dos índices
        }

        private void txtValorInserido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Tecla Enter
            {
                if (i >= 3)
                {
                    MessageBox.Show("Matriz já está cheia");
                    return;
                }

                if (!double.TryParse(txtValorInserido.Text, out double valor))
                {
                    MessageBox.Show("Valor inválido");
                    txtValorInserido.SelectAll();
                    return;
                }

                TabelaMatriz[i, j] = valor;
                j++;

                if (j > 2)
                {
                    i++;
                    j = 0;
                }

                txtValorInserido.Clear();
                txtValorInserido.Focus();

                if (i == 3)
                    MessageBox.Show("Matriz preenchida!");
            }
        }

        private void btnMostrarMaior_Click(object sender, EventArgs e)
        {
            double maior = TabelaMatriz[0, 0];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (TabelaMatriz[x, y] > maior)
                        maior = TabelaMatriz[x, y];
                }
            }

            MessageBox.Show($"O maior valor é: {maior}");
        }
    }
}