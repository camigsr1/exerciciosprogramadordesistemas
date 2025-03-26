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
    public partial class frmMaiorOuMenor : Form
    {
        public frmMaiorOuMenor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaiorOuMenorQue.Text, out int numero))
            {
                if (numero >= 10)
                {
                    MessageBox.Show("Esse número é maior ou igual a dez","Maior",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Esse número é menor que dez","Menor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}