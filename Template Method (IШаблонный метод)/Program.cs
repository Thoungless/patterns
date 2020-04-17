using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method__IШаблонный_метод_
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker pg = new Programmer();
            Worker ds = new Desiner();

            Console.WriteLine("Програмист");
            pg.StartWork();

            Console.WriteLine();

            Console.WriteLine("Дизайнер");
            ds.StartWork();

            Console.WriteLine();

            Console.WriteLine("Програмист");
            pg.StopWork();

            Console.WriteLine();

            Console.WriteLine("Дизайнер");
            ds.StopWork();

            Console.ReadKey();
        }
    }
}
