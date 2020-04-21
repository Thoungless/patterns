using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    class WorkPlace : IObservebable
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

        public void NotifyObserves(string message) 
        {
            foreach (var worker in workers)
            {
                worker.Update(message);
            }
        }
    }
}
