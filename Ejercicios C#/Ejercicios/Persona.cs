using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    //encapsulamiento
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;

        public Persona(string nombre, string apellido, int edad, string genero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
    }

}
