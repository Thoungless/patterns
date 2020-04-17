using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stategy
{
    class Desiner : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Начинаю работу в фотошопе");
        }

        public void StopWork()
        {
            Console.WriteLine("Закрываю фотошоп");
        }
    }
}
