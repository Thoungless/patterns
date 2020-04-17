using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkPlace of = new Offise();
            WorkPlace mg = new Magnit();

            Worker pg1 = new Programmer("Вася", of);
            Worker op1 = new OrderPicker("Миша", mg);

            Worker pg2 = new Programmer("Дима", of);
            Worker op2 = new OrderPicker("Олег", mg);


            pg1.StartWorking();
            of.Market();
            pg2.StartWorking();


            Console.WriteLine();
            of.Market();

            Console.WriteLine();

            pg1.StopWorking();
            of.Market();
            pg2.StopWorking();

            Console.WriteLine();

            of.Market();

            Console.WriteLine();

            op1.StartWorking();
            mg.Market();
            op1.StopWorking();

            op2.StartWorking();

            Console.WriteLine();

            mg.Market();

            Console.ReadKey();

        }
    }
}
