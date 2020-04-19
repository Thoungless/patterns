using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__Одиночка_
{
    class VideoCard
    {
        private static VideoCard instance;

        public string Name { get; private set; }
        protected VideoCard(string name)
        {
            this.Name = name;
        }

        public static VideoCard GetInstance(string name)
        {
            if (instance == null)
                instance = new VideoCard(name);
            else
                Console.WriteLine("Невозможно поставить 2 видеокарту!");
            return instance;
            
        } 
    }
}
