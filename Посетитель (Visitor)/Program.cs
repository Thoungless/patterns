using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = new FruBarbecue();
            var cm = new CookMeat();

            Chiken chiken = new Chiken();
            Pig pig = new Pig();

            chiken.Accept(fn);
            pig.Accept(cm);
        }
    }
}
