using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    //polimorfismo
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Sumar(double a, double b, double c)
        {
            return a + b + c;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(22, 12));
            Console.WriteLine(calculadora.Sumar(22, 12, 3));
            Console.WriteLine(calculadora.Sumar(22, 12, 3));
        }
    }
}
