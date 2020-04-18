using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_.states
{
    class DepositCreditMoney : IBankUserState
    {
        public void Deposit(IContext context, int money)
        {
            if (context.CreditMoney < 10)
            {
                Console.WriteLine($"Кредитный счёт пополнен на {money} рублей");
                context.CreditMoney += money;
            }
            else
            {
                context.SetState(new DepositMyMoney());
                context.Deposit(money);
            }
        }

        public void WithDraw(IContext context, int money)
        {
            throw new NotImplementedException();
        }
    }
}
