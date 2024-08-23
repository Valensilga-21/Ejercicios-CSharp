using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Documento : IImprimir
    {
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine("Imprimir documento...");
            Console.WriteLine(Content);
        }
    }

    public class Image : IImprimir
    {
        public string FilePath { get; set; }

        public void Print()
        {
            Console.WriteLine("Imprimir imagen...");
            Console.WriteLine($"File path: {FilePath}");
        }
    }
}
