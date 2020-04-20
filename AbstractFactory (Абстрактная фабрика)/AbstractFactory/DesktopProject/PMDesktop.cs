using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.ProjectTeamFactory;
using System.Threading.Tasks;

namespace AbstractFactory.DesktopProject
{
    class PMDesktop : ProjectManager
    {
        public string name { get; }

        public PMDesktop(string name)
        {
            this.name = name;
        }
        public void HastenDeveloper(Developer dev)
        {
            Console.WriteLine($"Я {name} сказал разработчику {dev.name} написать код");
            dev.WriteCode();
        }

        public void HastenTester(Tester tester)
        {
            Console.WriteLine($"Я {name} сказал тестировщику {tester.name} протестировать код");
            tester.TestCode();
        }

        public void ManageProject()
        {
            Console.WriteLine($"я {name} контролирую Desktop project");
        }
    }
}
