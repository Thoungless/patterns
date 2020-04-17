using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stategy
{
    class Programmer : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Начинаю писать код");
        }

        public void StopWork()
        {
            Console.WriteLine("Закрываю VisualStudio");
        }
    }
}
