using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    interface IVisitor
    {
        void Visit(Pig pig);
        void Visit(Chiken chiken);
    }
}
