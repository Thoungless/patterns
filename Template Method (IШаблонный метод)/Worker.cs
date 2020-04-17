using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method__IШаблонный_метод_
{
    abstract class Worker
    {
        public void StartWork()
        {
            OpenProgram();
            Work();
        }

        public void StopWork()
        {
            CloseProgram();
            GoAway();
        }

        private void GoAway()
        {
            Console.WriteLine("Уходит с рабочего места");
        }
        protected abstract void OpenProgram();
        protected abstract void CloseProgram();
        protected abstract void Work();
    }
}
