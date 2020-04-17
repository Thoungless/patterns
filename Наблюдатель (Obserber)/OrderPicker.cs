using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    class OrderPicker : Worker
    {
        string name;
        IObservebable ob;

        public OrderPicker(string name, IObservebable obs)
        {
            this.name = name;
            ob = obs;
        }

        public override void Update(object ob)
        {
            OrdersInfo oi = (OrdersInfo)ob;
            if (oi.HasOrder)
            {
                Console.WriteLine($"Комплектовщик {name} свободен и готов принять заявку");
                Random rnd = new Random();
                int nxt = rnd.Next(0, 2);
                if (nxt == 1)
                {
                    Console.WriteLine($"Комплектовщик {name} принял заявку");
                }
                else
                    Console.WriteLine($"Комплектовщик {name} отклонил заявку");
            }
            else
                Console.WriteLine($"Комплектовщик {name} находится в работе и не может сейчас принять заявку");
        }

        protected override void CameWorklace()
        {
            Console.WriteLine($"Комплектовщик {name} пришел на склад");
            ob.AddObserver(this);
        }

        protected override void LeftWorkplace()
        {
            Console.WriteLine($"Комплектовщик {name} покинул на склад");
            ob.RemoveObserver(this);
        }
    }
}
