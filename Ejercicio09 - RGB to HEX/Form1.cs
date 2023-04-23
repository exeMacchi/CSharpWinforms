using Ejercicio09___RGB_to_HEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm06
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
            ventanaRGB = new frmVentanaRGB();
        }

        private frmVentanaRGB ventanaRGB;

        private void btAbrirVentana_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";

            ventanaRGB.ShowDialog();
            
            if (ventanaRGB.Conversion)
            {
                tbResultado.Text = "#" + ventanaRGB.Hexadecimal;
            }
        }
    }
}
