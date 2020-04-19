using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей__Chain_of_responsibility_
{
    class LowNotifyer : Notifyer
    {
        public LowNotifyer(int priority) : base(priority)
        {
            this.priority = priority;
        }
        public override void Messge(string message)
        {
            Console.WriteLine($"Отправляю Email: {message}");
        }
    }
}
