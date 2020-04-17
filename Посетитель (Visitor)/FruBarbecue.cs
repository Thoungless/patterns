using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    class FruBarbecue : IVisitor
    {
        public void Visit(Pig pig)
        {
            Console.WriteLine("Готовлю шашлык из свинины");
        }

        public void Visit(Chiken chiken)
        {
            Console.WriteLine("Готовлю шашлык из курицы");
        }
    }
}
