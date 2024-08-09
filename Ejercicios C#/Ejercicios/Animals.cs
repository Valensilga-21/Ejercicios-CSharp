using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    //Get and Set
    public class Animals
    {
        private string _nombre;
        private string _raza;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Raza
        {
            get => _raza;
            set => _raza = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();

            perro.Nombre = "Max";
            perro.Raza = "Doberman";

            Console.WriteLine("_________________________");
            Console.WriteLine("Nombre: " + perro.Nombre);
            Console.WriteLine("Raza: " + perro.Raza);
            Console.WriteLine("_________________________");

            Animal gato = new Animal();

            gato.Nombre = "Bigotes";
            gato.Raza = "Chartreux";

            Console.WriteLine("Nombre: " + gato.Nombre);
            Console.WriteLine("Raza: " + gato.Raza);
            Console.WriteLine("_________________________");
        }
    }

}
