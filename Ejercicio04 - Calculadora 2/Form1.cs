using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btCalcular.Enabled = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNumero1.Text);
                double num2 = Convert.ToDouble(tbNumero2.Text);
                double resultado;

                if (rbSumar.Checked)
                {
                    resultado = num1 + num2;
                    tbResultado.Text = resultado.ToString();
                    lvHistorial.Items.Add(resultado.ToString());
                    
                }
                else if (rbRestar.Checked)
                {
                    resultado = num1 - num2;
                    tbResultado.Text = resultado.ToString();
                    lvHistorial.Items.Add(resultado.ToString());
                }
                else if (rbMultiplicar.Checked)
                {
                    resultado = num1 * num2;
                    tbResultado.Text = resultado.ToString();
                    lvHistorial.Items.Add(resultado.ToString());
                }
                else
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        tbResultado.Text = resultado.ToString();
                        lvHistorial.Items.Add(resultado.ToString());
                    }
                    else
                    {
                        MessageBox.Show("El divisor no puede ser 0.", "Alerta", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Número no válido.", "Alerta", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbSumar_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btCalcular.Enabled = true;
            }
            else
            {
                btCalcular.Enabled = false;
            }
        }

        private void rbRestar_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btCalcular.Enabled = true;
            }
            else
            {
                btCalcular.Enabled = false;
            }
        }

        private void rbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btCalcular.Enabled = true;
            }
            else
            {
                btCalcular.Enabled = false;
            }
        }

        private void rbDividir_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNumero1.Text != "" && tbNumero2.Text != "")
            {
                btCalcular.Enabled = true;
            }
            else
            {
                btCalcular.Enabled = false;
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
            if (tbNumero1.Text == "")
            {
                btCalcular.Enabled = false;
            }
            else if (tbNumero1.Text != "" && tbNumero2.Text != "" && (rbSumar.Checked || 
                     rbRestar.Checked || rbDividir.Checked || rbMultiplicar.Checked) )
            {
                btCalcular.Enabled = true;
            }
        }

        private void tbNumero2_TextChanged(object sender, EventArgs e)
        {
            if (tbNumero2.Text == "")
            {
                btCalcular.Enabled = false;
            }
            else if (tbNumero1.Text != "" && tbNumero2.Text != "" && (rbSumar.Checked || 
                     rbRestar.Checked || rbDividir.Checked || rbMultiplicar.Checked) )
            {
                btCalcular.Enabled = true;
            }
        }
    }
}
