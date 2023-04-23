using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm2;

namespace Ejercicio05___Crear_perfil_persona
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
            cantRegistros = 0;
        }

        private int cantRegistros;

        private void btAgregarNuevoPerfil_Click(object sender, EventArgs e)
        {
            frmPerfilPersona nuevoPerfil = new frmPerfilPersona();
            DialogResult respuesta = nuevoPerfil.ShowDialog();

            if (respuesta == DialogResult.OK && nuevoPerfil.PerfilPersona != null)
            {
                cantRegistros++;
                ltvwPersonas.Items.Add($"{cantRegistros}. {nuevoPerfil.PerfilPersona.Nombre}");
            }
        }

        private void nuevoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAgregarNuevoPerfil_Click(sender, e);
        }
    }
}
