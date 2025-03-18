using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaiorouMenor : Form
    {
        public frmMaiorouMenor()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string letra = txtNum.Text;
            bool sucesso = int.TryParse(letra, out int numero);

            if (sucesso)
            {
                if (numero > 10)
                {
                    MessageBox.Show("Maior que 10");

                }else if (numero < 10)
                {
                    MessageBox.Show("Menor que 10");

                }else
                {
                    MessageBox.Show("É igual a 10");

                }
            }
            else
            {
                MessageBox.Show("ERRO: Você colocou letra ou caractere", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
