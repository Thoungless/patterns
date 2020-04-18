using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_.states
{
    class DepositMyMoney : IBankUserState
    {

        public void Deposit(IContext context, int money)
        {
            if (context.CreditMoney < 10)
            {
                context.SetState(new DepositCreditMoney());
                context.Deposit(money);
                
            }
            else
            {
                Console.WriteLine($"Личный счёт пополнен на {money} рублей");
                context.MyMoney += money;
            }
        }

        public void WithDraw(IContext context, int money)
        {
            if (context.MyMoney > money)
            {
                context.SetState(new WithDrawMyMoney());
                context.WithDraw(money);
            }
        }
    }
}
