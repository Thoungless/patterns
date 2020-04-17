using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    abstract class WorkPlace : IObservebable
    {
        public List<IObserver> workers;
        private OrdersInfo oi;
        public WorkPlace()
        {
            workers = new List<IObserver>();
            oi = new OrdersInfo();
        }
       
        public void AddObserver(IObserver ob)
        {
            workers.Add(ob);
        }


        public void RemoveObserver(IObserver ob)
        {
            workers.Remove(ob);
        }

        public void NotifyObserves()
        {
            foreach (var worker in workers)
            {
                worker.Update(oi);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            int nxt = rnd.Next(0, 2);
            if (nxt == 1)
                oi.HasOrder = true;
            else
                oi.HasOrder = false;
            NotifyObserves();
        }
    }
}
