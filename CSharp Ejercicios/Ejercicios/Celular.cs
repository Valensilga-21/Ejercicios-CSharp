using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    //abstraccion
    public abstract class Celular
    {
        public abstract string marca { get; }
        public abstract string ram { get; }
        public abstract string modelo { get; }
        public abstract string almacenamiento { get; }
        public abstract string procesador { get; }

        public abstract void Encender();

        public void mostraInfo()
        {
            Console.WriteLine($"Marca de celular: {marca}");
            Console.WriteLine($"Memoria RAM: {ram}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Almacenamiento: {almacenamiento}");
            Console.WriteLine($"Procesador: {procesador}");
            Console.WriteLine("--------------------------------");
            Encender();
            Console.WriteLine("--------------------------------");
        }
    }

    public class Redmi : Celular
    {
        public override string marca => "Redmi";
        public override string ram => "8 GB";
        public override string modelo => "Note 13 Pro";
        public override string almacenamiento => "256 GB";
        public override string procesador => "Eight core";

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Redmi Note 13 Pro...");
        }
    }

    public class Samsung : Celular
    {
        public override string marca => "Samsung";
        public override string ram => "6 GB";
        public override string modelo => "Galaxy 8";
        public override string almacenamiento => "128 GB";
        public override string procesador => "Cuad core";

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Samsung Galaxy 8...");
        }
    }

    public class Oppo : Celular
    {
        public override string marca => "Oppo";
        public override string ram => "8 GB";
        public override string modelo => "Reno 7";
        public override string almacenamiento => "256 GB";
        public override string procesador => "Eiht core";

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Oppo Reno 7...");
        }
    }
}