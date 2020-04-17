using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    class CookMeat : IVisitor
    {
        public void Visit(Pig pig)
        {
            Console.WriteLine("Варю свинину");
        }

        public void Visit(Chiken chiken)
        {
            Console.WriteLine("Варю курицу");
        }
    }
}
