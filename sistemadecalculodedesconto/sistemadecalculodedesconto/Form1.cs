using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemadecalculodedesconto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorDeCompra.Text, out int valordecompra) && int.TryParse(txtDesconto.Text, out int descontoPercentual) && descontoPercentual <= 100)
                {

                    decimal desconto = descontoPercentual / 100m;

                    decimal resultado = valordecompra * (1 - desconto);

                    lblResultado.Text = resultado.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }