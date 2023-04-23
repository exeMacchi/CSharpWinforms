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

namespace WinForm04
{
    public partial class Form1 : Form
    {
        private string[] lineas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool repetir = true;

            do
            {
                // Hace falta agregar la referencia a Microsoft.VisualBasic para utilizar
                // este control.
                string ruta = Microsoft.VisualBasic.Interaction.InputBox
                              ("Escriba el nombre del fichero de texto (ruta predefinida) " +
                              "o una ruta específica.",
                               "Ruta del fichero",
                               "ejemplo.txt");

                if (!ruta.Contains(".txt"))
                {
                    ruta += ".txt";
                }

                if (File.Exists(ruta))
                {
                    repetir = false;
                    lineas = File.ReadAllLines(ruta);

                    foreach (string linea in lineas)
                    {
                        lvFichero.Items.Add(linea);
                    }
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("La ruta introducida no es correcta. " +
                                                             "¿Desea volver a intentarlo?",
                                                             "Error", MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Error);

                    if (respuesta == DialogResult.No)
                    {
                        repetir = false;
                        this.Close();
                    }
                }

            } while (repetir);
        }
    }
}
