using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stategy
{
    class Worker
    {
        public void Stat(IWorker worker)
        {
            if (worker != null)
                worker.StartWork();
        }

        public void Stop(IWorker worker)
        {
            if (worker != null)
                worker.StopWork();
        }
    }
}
