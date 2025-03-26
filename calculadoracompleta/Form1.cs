using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calculadoracompleta
{
    public partial class frmCalculadoraCompleta : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Plus,
            Minus,
            Multiply,
            Division
        }

        public frmCalculadoraCompleta()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmCalculadoraCompleta_KeyDown);
        }

            private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                OperacaoSelecionada = Operacao.Plus;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "+";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                OperacaoSelecionada = Operacao.Minus;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                OperacaoSelecionada = Operacao.Multiply;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "x";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                OperacaoSelecionada = Operacao.Division;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "/";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                decimal segundoValor = Convert.ToDecimal(txtResultado.Text);

                switch (OperacaoSelecionada)
                {
                    case Operacao.Plus:
                        Resultado = Valor + segundoValor;
                        break;
                    case Operacao.Minus:
                        Resultado = Valor - segundoValor;
                        break;
                    case Operacao.Multiply:
                        Resultado = Valor * segundoValor;
                        break;
                    case Operacao.Division:
                        if (segundoValor != 0)
                            Resultado = Valor / segundoValor;
                        else
                            MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                txtResultado.Text = Resultado.ToString();
                Valor = Resultado;
                lblOperacao.Text = "";
            }
            catch (OverflowException)
            {
                MessageBox.Show("O valor inserido é muito grande!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void frmCalculadoraCompleta_KeyDown(object sender, KeyEventArgs e)
        {
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                        btnZero_Click(sender, e);
                        break;
                    case Keys.NumPad1:
                        btnOne_Click(sender, e);
                        break;
                    case Keys.NumPad2:
                        btnTwo_Click(sender, e);
                        break;
                    case Keys.NumPad3:
                        btnThree_Click(sender, e);
                        break;
                    case Keys.NumPad4:
                        btnFour_Click(sender, e);
                        break;
                    case Keys.NumPad5:
                        btnFive_Click(sender, e);
                        break;
                    case Keys.NumPad6:
                        btnSix_Click(sender, e);
                        break;
                    case Keys.NumPad7:
                        btnSeven_Click(sender, e);
                        break;
                    case Keys.NumPad8:
                        btnEight_Click(sender, e);
                        break;
                    case Keys.NumPad9:
                        btnNine_Click(sender, e);
                        break;
                    case Keys.Add:
                        btnPlus_Click(sender, e);
                        break;
                    case Keys.Subtract:
                        btnMinus_Click(sender, e);
                        break;
                    case Keys.Multiply:
                        btnMultiply_Click(sender, e);
                        break;
                    case Keys.Divide:
                        btnDivision_Click(sender, e);
                        break;
                    case Keys.Decimal:
                        btnComma_Click(sender, e);
                        break;
                    case Keys.Enter:
                        btnEqual_Click(sender, e);
                        break;
                }
            }
        }
    }
}
