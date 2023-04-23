using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
            btSaludar.Enabled = false;
        }

        private void frmVentana_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Le doy la bienvenida a mi primera aplicación.", "Bienvenida");
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;

            MessageBox.Show($"Hola, {nombre}, mucho gusto.", "Saludo");
        }

        private void lbBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un poco más abajo...");
        }

        private void frmVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por haber visto mi aplicación :)", "Despedida");
        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btSaludar.Enabled)
            {
                btSaludar_Click(sender, e);
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                btSaludar.Enabled = true;
            }
            else
            {
                btSaludar.Enabled = false;
            }
        }
    }
}
