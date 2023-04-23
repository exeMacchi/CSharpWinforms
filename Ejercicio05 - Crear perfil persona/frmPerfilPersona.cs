using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class frmPerfilPersona : Form
    {
        // Constructor
        public frmPerfilPersona()
        {
            InitializeComponent();
            btVerPerfil.Enabled = false;
            btAceptarPerfil.Enabled = false;
            btCancelar.Enabled = false;
        }

        // Propiedades
        public Persona perfilPersona;

        public Persona PerfilPersona 
        { 
            get { return perfilPersona; } 
            set { perfilPersona = value; } 
        }

        // Métodos
        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string chocolate = cbxChocolate.Checked == true 
                               ? "Te gusta el chocolate."
                               : "No te gusta el chocolate";
            string chocolatePersona = cbxChocolate.Checked == true
                               ? "me gusta el chocolate"
                               : "no me gusta el chocolate";
            string genero;
                if (rbtnGMasculino.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (rbtnGFemenino.Checked == true)
                {
                    genero = "Femenino";
                }
                else
                {
                    genero = "Otro";
                }
            string colorFav = combxColorFav.SelectedItem.ToString();

            // ====== //
            lviewElementos.Items.Clear();
            lviewElementos.Items.Add($"Nombre: {nombre}");
            lviewElementos.Items.Add($"Fecha de nacimiento: {fechaNacimiento}");
            lviewElementos.Items.Add(chocolate);
            lviewElementos.Items.Add($"Género: {genero}");
            lviewElementos.Items.Add($"Color favorito: {colorFav}");
            // ====== //

            btAceptarPerfil.Enabled = true;
            btCancelar.Enabled = true;

            Persona persona1 = new Persona(nombre, fechaNacimiento, chocolatePersona, 
                                           genero, colorFav);

            MessageBox.Show(persona1.Presentacion(), "Resumen", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && combxColorFav.Text != "")
            {
                btVerPerfil.Enabled = true;
            }
            else
            {
                btVerPerfil.Enabled = false;
            }
        }

        private void combxColorFav_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && combxColorFav.Text != "")
            {
                btVerPerfil.Enabled = true;
            }
            else
            {
                btVerPerfil.Enabled = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            lviewElementos.Items.Clear();
            btAceptarPerfil.Enabled = false;
            btCancelar.Enabled = false;
            txtNombre.Text = "";
            combxColorFav.SelectedIndex = -1;
        }

        private void btAceptarPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string chocolatePersona = cbxChocolate.Checked == true
                               ? "me gusta el chocolate"
                               : "no me gusta el chocolate";
            string genero;
                if (rbtnGMasculino.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (rbtnGFemenino.Checked == true)
                {
                    genero = "Femenino";
                }
                else
                {
                    genero = "Otro";
                }
            string colorFav = combxColorFav.SelectedItem.ToString();

            Persona persona = new Persona(nombre, fechaNacimiento, chocolatePersona, genero, colorFav);
            PerfilPersona = persona;

            this.Close();
        }
    }
}
