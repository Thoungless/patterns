using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__Одиночка_
{
    class Computer
    {
        public VideoCard videoCard { get; set; }

        public void Launch(string cName)
        {
            videoCard = VideoCard.GetInstance(cName);
        }
    }
}
