using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_.states
{
    class WithdrowCreditMoney : IBankUserState
    {
        public void Deposit(IContext context, int money)
        {
            context.SetState(new DepositCreditMoney());
            context.Deposit(money);
        }

        public void WithDraw(IContext context, int money)
        {
            if (context.CreditMoney >= money)
            {
                Console.WriteLine($"С кредитного счёта списано {money} рублей");
                context.CreditMoney -= money;
            }
            else
            {
                if (context.CreditMoney < 3)
                {
                    context.SetState(new Blocked());
                    context.WithDraw(money);
                }
            }
        }
    }
}
