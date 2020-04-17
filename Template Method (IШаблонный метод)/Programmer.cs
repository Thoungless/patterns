using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method__IШаблонный_метод_
{
    class Programmer : Worker
    {
        protected override void CloseProgram()
        {
            Console.WriteLine("Закрываю Visual Studio");
        }

        protected override void OpenProgram()
        {
            Console.WriteLine("Открываю Visual Studio");
        }

        protected override void Work()
        {
            Console.WriteLine("Пишу код");
        }
    }
}
