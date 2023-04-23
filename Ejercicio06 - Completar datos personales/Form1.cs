using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm4
{
    public partial class formPrincipal : Form
    {
        private bool apellidotb, nombretb, edadtb, direcciontb;
        public formPrincipal()
        {
            InitializeComponent();
            btAceptar.Enabled = false;
            apellidotb = nombretb = edadtb = direcciontb = false;
            tbApellido.BackColor = tbNombre.BackColor = tbEdad.BackColor = 
                                   tbDireccion.BackColor = Color.IndianRed;
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            if (tbApellido.Text == "")
            {
                tbApellido.BackColor = Color.IndianRed;
                apellidotb = false;
                btAceptar.Enabled = false;
            }
            else
            {
                tbApellido.BackColor = System.Drawing.SystemColors.Window;
                apellidotb = true;

                if (apellidotb && nombretb && edadtb && direcciontb)
                {
                    btAceptar.Enabled = true;
                }
            }
        }
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.IndianRed;
                nombretb = false;
                btAceptar.Enabled = false;
            }
            else
            {
                tbNombre.BackColor = System.Drawing.SystemColors.Window;
                nombretb = true;

                if (apellidotb && nombretb && edadtb && direcciontb)
                {
                    btAceptar.Enabled = true;
                }
            }
        }
        private void tbEdad_TextChanged(object sender, EventArgs e)
        {
            if (tbEdad.Text == "")
            {
                tbEdad.BackColor = Color.IndianRed;
                edadtb = false;
                btAceptar.Enabled = false;
            }
            else
            {
                tbEdad.BackColor = System.Drawing.SystemColors.Window;
                edadtb = true;

                if (apellidotb && nombretb && edadtb && direcciontb)
                {
                    btAceptar.Enabled = true;
                }
            }
        }
        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                tbDireccion.BackColor = Color.IndianRed;
                direcciontb = false;
                btAceptar.Enabled = false;
            }
            else
            {
                tbDireccion.BackColor = System.Drawing.SystemColors.Window;
                direcciontb = true;

                if (apellidotb && nombretb && edadtb && direcciontb)
                {
                    btAceptar.Enabled = true;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = $"Apellido y nombre: {tbApellido.Text}, {tbNombre.Text}\r\n" +
                               $"Edad: {tbEdad.Text}" + "\r\n" + 
                               $"Dirección: {tbDireccion.Text}";                
        }

        private void btCancelar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btAceptar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
