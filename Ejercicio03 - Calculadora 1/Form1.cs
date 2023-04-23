using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btSumar.Enabled = false;
            btRestar.Enabled = false;
            btDividir.Enabled = false;
            btMultiplicar.Enabled = false;
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNumero1.Text);
                double num2 = Convert.ToDouble(tbNumero2.Text);

                double resultado = num1 + num2;

                tbResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número no válido.", "Alerta", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNumero1.Text);
                double num2 = Convert.ToDouble(tbNumero2.Text);

                double resultado = num1 - num2;

                tbResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número no válido.", "Alerta", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNumero1.Text);
                double num2 = Convert.ToDouble(tbNumero2.Text);

                double resultado = num1 * num2;

                tbResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número no válido.", "Alerta", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNumero1.Text);
                double num2 = Convert.ToDouble(tbNumero2.Text);

                if (num2 != 0)
                {
                    double resultado = num2 / num2;

                    tbResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("El divisor no puede ser 0.", "Alerta", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Número no válido.", "Alerta", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbNumero1_TextChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btSumar.Enabled = true;
                btRestar.Enabled = true;
                btMultiplicar.Enabled = true;
                btDividir.Enabled = true;
            }
            else
            {
                btSumar.Enabled = false;
                btRestar.Enabled = false;
                btMultiplicar.Enabled = false;
                btDividir.Enabled = false;
            }
        }

        private void tbNumero2_TextChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btSumar.Enabled = true;
                btRestar.Enabled = true;
                btMultiplicar.Enabled = true;
                btDividir.Enabled = true;
            }
            else
            {
                btSumar.Enabled = false;
                btRestar.Enabled = false;
                btMultiplicar.Enabled = false;
                btDividir.Enabled = false;
            }
        }
    }
}
