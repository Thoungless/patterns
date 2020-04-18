using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Состояние__State_.states;

namespace Состояние__State_
{
    class Program
    {
        static void Main(string[] args)
        {
            BankUser user = new BankUser();

            user.SetState(new DepositMyMoney());
            user.Deposit(10);
            user.Deposit(6);
            user.WithDraw(4);
            user.WithDraw(10);
            user.Deposit(6);
            user.Deposit(6);
            user.Deposit(11);
            user.WithDraw(10);
            user.WithDraw(10);
            user.WithDraw(10);
            user.WithDraw(10);
            user.Deposit(9);
            user.Deposit(11);

            Console.ReadKey();
        }
    }
}
