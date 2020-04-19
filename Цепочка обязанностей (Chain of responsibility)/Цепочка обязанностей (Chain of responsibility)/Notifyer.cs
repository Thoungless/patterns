using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей__Chain_of_responsibility_
{
    abstract class Notifyer
    {
        protected int priority;
        private Notifyer nextNorifyer;

        public Notifyer(int priority)
        {
            this.priority = priority;
        }

        public void SetNextNotifyer(Notifyer next)
        {
            nextNorifyer = next;
        }

        public void NotifyClient(string mes, int lvl)
        {
            if (lvl >= priority)
                Messge(mes);
            if(nextNorifyer != null)
            {
                nextNorifyer.NotifyClient(mes, lvl);
            }
                
        }

        public abstract void Messge(string message);
    }
}
