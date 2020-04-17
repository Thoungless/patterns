using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    abstract class Worker : IObserver
    {
        public void StartWorking() 
        {
            CameWorklace();
        }

        public void StopWorking()
        {
            LeftWorkplace();
        }

        protected abstract void LeftWorkplace();
        protected abstract void CameWorklace();

        public abstract void Update(object ob);

    }
}
