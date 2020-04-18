using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_
{
    interface IBankUserState
    {
        void Deposit(IContext context, int money);
        void WithDraw(IContext context, int money);
    }
}
