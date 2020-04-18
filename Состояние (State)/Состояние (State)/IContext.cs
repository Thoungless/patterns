using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_
{
    abstract class IContext
    {
        public int MyMoney { get;  set; }
        public int CreditMoney { get;  set; }
        public abstract void Deposit(int money);
        public abstract void WithDraw(int money);
        public abstract void SetState(IBankUserState state);
    }
}
