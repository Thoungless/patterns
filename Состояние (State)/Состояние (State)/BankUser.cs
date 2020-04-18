using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_
{
    class BankUser : IContext
    {

        IBankUserState state;

        public override void Deposit(int money)
        {
            state.Deposit(this, money);
        }

        public override void WithDraw(int money)
        {
            state.WithDraw(this, money);
        }

        public override void SetState(IBankUserState states)
        {
            state = states;
        }
    }
}
