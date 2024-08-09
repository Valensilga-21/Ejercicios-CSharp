using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{

    //herencia
    public class Animal
    {
        //metodo
        public void Comer()
        {
            Console.WriteLine("El animal come.");
        }
    }

    public class Mamifero : Animal
    {
        //metodo
        public void Caminar()
        {
            Console.WriteLine("El mamifero camina.");
        }
    }

    // Clase derivada
    public class Perro : Mamifero
    {
        public void Ladrar()
        {
            Console.WriteLine("El perro ladra");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Usage
            Perro miPerro = new Perro();
            miPerro.Comer();
            miPerro.Caminar();
            miPerro.Ladrar();
        }
    }

}
