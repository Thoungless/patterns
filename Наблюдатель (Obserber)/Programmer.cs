using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    class Programmer : Worker
    {
        string name;
        IObservebable ob;


        public Programmer(string name, IObservebable obs)
        {
            this.name = name;
            ob = obs;
        }

        public override void Update(object ob)
        {
            OrdersInfo oi = (OrdersInfo)ob;
            if (oi.HasOrder)
            {
                Console.WriteLine($"Програмист {name} свободен и готов принять заявку");
                Random rnd = new Random();
                int nxt = rnd.Next(0, 2);
                if(nxt == 1)
                {
                    Console.WriteLine($"Програмист {name} принял заявку");
                }
                else
                    Console.WriteLine($"Програмист {name} отклонил заявку");
            }
            else
                Console.WriteLine($"Програмист {name} находится в работе и не может сейчас принять заявку");
        }

        protected override void CameWorklace()
        {
            Console.WriteLine($"Програмист {name} сел за компьютер");
            ob.AddObserver(this);
        }

        protected override void LeftWorkplace()
        {
            Console.WriteLine($"Програмист {name} выключил компьютер");
            ob.RemoveObserver(this);
        }
    }
}
