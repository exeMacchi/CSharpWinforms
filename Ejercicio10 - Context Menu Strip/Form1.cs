using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm07
{
    public partial class Form1 : Form
    {
        // Este formulario permite abrir un archivo de texto, mostrar el contenido en una
        // ListBox y borrar líneas usando un menú contextual o aprentando la tecla DEL.
        // Luego, se puede guardar el nuevo archivo de texto modificado en una ruta que
        // seleccione el usuario.

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = openFileDialog1.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                ltbxContenido.Items.Clear();

                string ruta = openFileDialog1.FileName;

                if (ruta.EndsWith(".txt"))
                {
                    string[] lineas = File.ReadAllLines(ruta);

                    foreach (string linea in lineas)
                    {
                        ltbxContenido.Items.Add(linea);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo de texto.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guardarNuevoFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult respuesta = saveFileDialog1.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                string[] lineas = new string[ltbxContenido.Items.Count];
                ltbxContenido.Items.CopyTo(lineas, 0);

                string ruta = saveFileDialog1.FileName;
                if (!ruta.Contains(".txt"))
                {
                    ruta += ".txt";
                }

                StreamWriter escritorDeFlujo = File.CreateText(ruta);
                foreach (string linea in lineas)
                {
                    escritorDeFlujo.WriteLine(linea);
                }
                escritorDeFlujo.Close();
            }
        }

        private void borrarLíneaSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltbxContenido.Items.RemoveAt(ltbxContenido.SelectedIndex);
        }

        private void ltbxContenido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                borrarLíneaSeleccionadaToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
