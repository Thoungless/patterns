using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние__State_.states
{
    class Blocked : IBankUserState
    {
        public void Deposit(IContext context, int money)
        {
            context.SetState(new DepositCreditMoney());
            context.Deposit(money);
        }

        public void WithDraw(IContext context, int money)
        {
            Console.WriteLine("Ошибка. Ваш счёт заблокирован, для разблокировки пополните его");
        }
    }
}
