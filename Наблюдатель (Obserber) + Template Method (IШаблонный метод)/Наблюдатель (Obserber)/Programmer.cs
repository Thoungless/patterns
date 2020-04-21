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

        public override void Update(string mes)
        {
            Console.WriteLine($"Я програмист {name} получил сообщение: {mes}");
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
