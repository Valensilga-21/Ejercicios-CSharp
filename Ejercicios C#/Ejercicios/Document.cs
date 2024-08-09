using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Document : IImprimir
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
        class Program
        {
            static void Main(string[] args)
            {
                Document doc = new Document { Content = "La historia de la programcion" };
                doc.Print();

                Image img = new Image { FilePath = "image(1).jpg" };
                img.Print();
            }
        }
    }

    

}
