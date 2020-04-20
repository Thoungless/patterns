using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ProjectTeamFactory;

namespace AbstractFactory.DesktopProject
{
    class QATester : Tester
    {
        public string name { get; private set; }

        public QATester(string name)
        {
            this.name = name;
        }
        public void TestCode()
        {
            Console.WriteLine($"Я {name} тестирую код");
        }
    }
}
