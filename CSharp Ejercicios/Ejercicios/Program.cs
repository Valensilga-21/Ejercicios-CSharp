using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals perro = new Animals();

            perro.Nombre = "Max";
            perro.Raza = "Doberman";

            Console.WriteLine("Get and Set");
            Console.WriteLine("_________________________");
            Console.WriteLine("Nombre: " + perro.Nombre);
            Console.WriteLine("Raza: " + perro.Raza);
            Console.WriteLine("_________________________");

            Animals gato = new Animals();

            gato.Nombre = "Bigotes";
            gato.Raza = "Chartreux";

            Console.WriteLine("Nombre: " + gato.Nombre);
            Console.WriteLine("Raza: " + gato.Raza);
            Console.WriteLine("_________________________");

            Console.WriteLine("Herencia");
            Console.WriteLine("_________________________");
            Perro miPerro = new Perro();
            miPerro.Comer();
            miPerro.Caminar();
            miPerro.Ladrar();
            Console.WriteLine("_________________________");

            Console.WriteLine("Polimorfismo");
            Console.WriteLine("_________________________");
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(22, 12));
            Console.WriteLine(calculadora.Sumar(22, 12, 3));
            Console.WriteLine(calculadora.Sumar(22, 12, 3));
            Console.WriteLine("_________________________");

            Console.WriteLine("Herencia");
            Console.WriteLine("_________________________");
            Celular celular1 = new Redmi();
            celular1.mostraInfo();
            Celular celular2 = new Samsung();
            celular2.mostraInfo();
            Celular celular3 = new Oppo();
            celular3.mostraInfo();
            Console.WriteLine("_________________________");

            Console.WriteLine("Interface");
            Console.WriteLine("_________________________");
            Documento doc = new Documento { Content = "La historia de la programcion" };
            doc.Print();

            Image img = new Image { FilePath = "image(1).jpg" };
            img.Print();
            Console.WriteLine("_________________________");

            Console.WriteLine("Encapsulamiento");
            Console.WriteLine("_________________________");
            Persona persona = new Persona("Mario", "Calderón", 35, "Masculino");

            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona.Apellido); 
            Console.WriteLine(persona.Edad);
            Console.WriteLine(persona.Genero); 

            persona.Nombre = "María";
            persona.Apellido = "González";
            persona.Edad = 15;
            persona.Genero = "Femenino";

            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona.Apellido);
            Console.WriteLine(persona.Edad);
            Console.WriteLine(persona.Genero);
        }
    }
}
