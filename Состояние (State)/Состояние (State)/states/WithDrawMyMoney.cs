using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_.states
{
    class WithDrawMyMoney : IBankUserState
    {
        public void Deposit(IContext context, int money)
        {
            context.SetState(new DepositCreditMoney());
            context.Deposit(money);
        }

        public void WithDraw(IContext context, int money)
        {
            if (context.MyMoney > money)
            {
                Console.WriteLine($"С личного счёта списано {money} рублей");
                context.MyMoney -= money;
            }
            else
            {                
                    context.SetState(new WithdrowCreditMoney());
                    context.WithDraw(money);
            }
        }
    }
}
