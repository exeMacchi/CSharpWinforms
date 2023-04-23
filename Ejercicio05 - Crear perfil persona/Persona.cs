using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm2
{
    public class Persona
    {
        public Persona(string nombre, DateTime fechaNacimiento, string chocolate,
                       string genero, string colorFavorito)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.chocolate = chocolate;
            this.genero = genero;
            this.colorFavorito = colorFavorito;
        }

        private string nombre;
        private DateTime fechaNacimiento;
        private string chocolate;
        private string genero;
        private string colorFavorito;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Chocolate
        {
            get { return chocolate; }
            set { chocolate = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string ColorFavorito
        {
            get { return colorFavorito; }
            set { colorFavorito = value; }
        }

        public string Presentacion()
        {
            return ($"Hola, me llamo {nombre}, nací el {fechaNacimiento.ToString("d")}, {chocolate}," +
                $" y mi color favorito es el {colorFavorito.ToLower()}.");
        }
    }
}
