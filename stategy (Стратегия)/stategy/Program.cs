using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker prog = new Worker();
            Worker des = new Worker();

            des.Stat(new Desiner());
            prog.Stat(new Programmer());
            des.Stop(new Desiner());
            prog.Stop(new Programmer());

            Console.ReadKey();
        }
    }
}
