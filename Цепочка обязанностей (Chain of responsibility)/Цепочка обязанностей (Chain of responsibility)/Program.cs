using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей__Chain_of_responsibility_
{
    public enum PRIORITY
    {
        low = 1,
        medium = 2,
        high = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifyer lowNotifyer = new LowNotifyer((int)PRIORITY.low);
            Notifyer mediumNotifyer = new MediumNotifyer((int)PRIORITY.medium);
            Notifyer highNotifyer = new HighNotifyer((int)PRIORITY.high);

            lowNotifyer.SetNextNotifyer(mediumNotifyer);
            mediumNotifyer.SetNextNotifyer(highNotifyer);

            lowNotifyer.NotifyClient("Лоу", (int)PRIORITY.low);

            Console.WriteLine();

            lowNotifyer.NotifyClient("Медиум", (int)PRIORITY.medium);

            Console.WriteLine();

            lowNotifyer.NotifyClient("Хай", (int)PRIORITY.high);

            Console.WriteLine();

            lowNotifyer.NotifyClient("лоу", (int)PRIORITY.low);

            Console.ReadKey();

        }
    }
}
