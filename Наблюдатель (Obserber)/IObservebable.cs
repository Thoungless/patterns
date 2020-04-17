using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    interface IObservebable
    {
        void AddObserver(IObserver ob);

        void RemoveObserver(IObserver ob);

        void NotifyObserves();

    }
}
