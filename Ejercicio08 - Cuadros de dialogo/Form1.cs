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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace WinForm05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btColorLetra.Enabled = false;
            btFuente.Enabled = false;
            ocLineas = new ObservableCollection<string>();
            ocLineas.CollectionChanged += ocLineas_CollectionChanged;
        }

        private ObservableCollection<string> ocLineas;

        private void btColorLetra_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = cdColorFuente.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                int colorLetra = cdColorFuente.Color.ToArgb();
                lvContenidoFichero.ForeColor = Color.FromArgb(colorLetra);
            }
        }

        private void btFicheroTexto_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = ofdFichero.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                string rutaFichero = ofdFichero.FileName;

                if (rutaFichero.EndsWith(".txt"))
                {
                    string[] lineas = File.ReadAllLines(rutaFichero, Encoding.UTF8);

                    ocLineas.Clear();
                    lvContenidoFichero.Items.Clear();
                    foreach (string linea in lineas)
                    {
                        ocLineas.Add(linea);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo de texto.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btFuente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = fdFuente.ShowDialog();

            if (respuesta != DialogResult.Cancel)
            {
                string fuente = fdFuente.Font.Name;
                float tamanioLetra = fdFuente.Font.Size;

                lvContenidoFichero.Font = new System.Drawing.Font(fuente, tamanioLetra);
            }
        }

        // Evento creado para controlar la cantidad de elementos dentro del ListView.
        private void ocLineas_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (string linea in e.NewItems)
                {
                    lvContenidoFichero.Items.Add(linea);
                }
            }

            if (lvContenidoFichero.Items.Count > 0)
            {
                btColorLetra.Enabled = true;
                btFuente.Enabled = true;
            }
        }
    }
}
