using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель__Obserber_
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkPlace office = new WorkPlace();
            WorkPlace magnit = new WorkPlace();

            Worker javaProgrammer = new Programmer("Вася", office);
            Worker orderpicker1 = new OrderPicker("Миша", magnit);

            Worker phpProgrammer = new Programmer("Дима", office);
            Worker orderpicker2 = new OrderPicker("Олег", magnit);


            javaProgrammer.StartWorking();
            office.NotifyObserves("Поступила новая завка от заказчика!");
            phpProgrammer.StartWorking();
            office.NotifyObserves("Завтра у всех выходной! На работу не приходите.");


            Console.WriteLine();

            javaProgrammer.StopWorking();
            phpProgrammer.StopWorking();

            Console.WriteLine();

            orderpicker1.StartWorking();
            magnit.NotifyObserves("Новый заказ");
            orderpicker1.StopWorking();

            magnit.NotifyObserves("Новый заказ");

            orderpicker2.StartWorking();

            magnit.NotifyObserves("Новый заказ");

            Console.ReadKey();

        }
    }
}
