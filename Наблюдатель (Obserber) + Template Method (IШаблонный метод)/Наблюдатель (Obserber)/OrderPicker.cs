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

        public override void Update(string mes)
        {
            Console.WriteLine($"Я комплектовщик {name} получил сообщение: {mes}");
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
