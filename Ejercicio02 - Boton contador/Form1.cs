using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        private int presiones = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btPulsar_Click(object sender, EventArgs e)
        {
            presiones++;
            lbPulsar.Text = $"¡Has presionado el botón {presiones} veces!";
            lbPulsar.Left = 25;
        }

        private void lbPulsar_SizeChanged(object sender, EventArgs e)
        {
            Size tamEtiqueta = lbPulsar.Size;
            Size tamFormulario = new Size(tamEtiqueta.Width + 50, ClientSize.Height);
            this.ClientSize = tamFormulario;
        }
    }
}
