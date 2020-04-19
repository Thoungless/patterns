using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__Одиночка_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();

            comp.Launch("GTX 550TI");

            Console.WriteLine(comp.videoCard.Name);

            Console.WriteLine();

            comp.Launch("AMD HD 7730");

            Console.WriteLine();

            Console.WriteLine(comp.videoCard.Name);

            Console.ReadKey();
        }
    }
}
