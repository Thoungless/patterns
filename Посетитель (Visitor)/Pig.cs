using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    class Pig : IShape
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
