using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method__IШаблонный_метод_
{
    class Desiner : Worker
    {
        protected override void CloseProgram()
        {
            Console.WriteLine("Закрываю Photoshop");
        }

        protected override void OpenProgram()
        {
            Console.WriteLine("Открываю Photoshop");
        }

        protected override void Work()
        {
            Console.WriteLine("Разрабатываю дизайн");
        }
    }
}
