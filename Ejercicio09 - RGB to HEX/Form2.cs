using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09___RGB_to_HEX
{
    public partial class frmVentanaRGB : Form
    {
        public frmVentanaRGB()
        {
            InitializeComponent();
            conversion = false;
            btConfirmarRGB.Enabled = false;
            ttMensajeEmergente.SetToolTip(tbRojo, "Escriba un número entre 0 y 255.");
            ttMensajeEmergente.SetToolTip(tbVerde, "Escriba un número entre 0 y 255.");
            ttMensajeEmergente.SetToolTip(tbAzul, "Escriba un número entre 0 y 255.");
        }

        private byte[] rgb = new byte[3];
        private string hexadecimal;
        private bool conversion;
        private char[] hexDigitos = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B',
                                     'C', 'D', 'E', 'F'};

        public string Hexadecimal
        {
            get { return hexadecimal; }
        }

        public bool Conversion
        {
            get { return conversion; }
        }

        private string RGBToHex(int cociente, char[] hexDigitos)
        {
            int resto = cociente % 16;

            if (cociente < 16)
            {
                return hexDigitos[cociente].ToString();
            }
            else
            {
                return RGBToHex(cociente / 16, hexDigitos) + hexDigitos[resto];
            }
        }

        private void btConfirmarRGB_Click(object sender, EventArgs e)
        {
            bool conversionExitosa = false;

            try
            {
                byte rojo = Convert.ToByte(tbRojo.Text);
                byte verde = Convert.ToByte(tbVerde.Text);
                byte azul = Convert.ToByte(tbAzul.Text);

                rgb[0] = rojo;
                rgb[1] = verde;
                rgb[2] = azul;

                conversionExitosa = true;
            }
            catch (FormatException)
            {
                DialogResult respuesta = MessageBox.Show("Error: número no válido",
                                            "Error", MessageBoxButtons.RetryCancel,
                                            MessageBoxIcon.Error);

                if (respuesta == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                DialogResult respuesta = MessageBox.Show($"Error: {ex.Message}",
                        "Error", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                if (respuesta == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

            if (conversionExitosa)
            {
                hexadecimal = RGBToHex(rgb[0], hexDigitos) + 
                              RGBToHex(rgb[1], hexDigitos) + 
                              RGBToHex(rgb[2], hexDigitos);
                conversion = true;
                this.Close();
            }
        }

        private void tbRojo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbVerde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbAzul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbRojo_TextChanged(object sender, EventArgs e)
        {
            if (tbRojo.Text != "" && tbAzul.Text != "" && tbVerde.Text != "")
            {
                btConfirmarRGB.Enabled = true;
            }
            else
            {
                btConfirmarRGB.Enabled = false;
            }
        }

        private void tbVerde_TextChanged(object sender, EventArgs e)
        {
            if (tbRojo.Text != "" && tbAzul.Text != "" && tbVerde.Text != "")
            {
                btConfirmarRGB.Enabled = true;
            }
            else
            {
                btConfirmarRGB.Enabled = false;
            }
        }

        private void tbAzul_TextChanged(object sender, EventArgs e)
        {
            if (tbRojo.Text != "" && tbAzul.Text != "" && tbVerde.Text != "")
            {
                btConfirmarRGB.Enabled = true;
            }
            else
            {
                btConfirmarRGB.Enabled = false;
            }
        }
    }
}
