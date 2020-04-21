using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ProjectTeamFactory;

namespace AbstractFactory.WebsiteProject
{
    class WebPM : ProjectManager
    {
        public string name { get; private set; }

        public WebPM(string name)
        {
            this.name = name;
        }
        public void HastenDeveloper(Developer dev)
        {
            Console.WriteLine("Поторопил Пхпшника");
            dev.WriteCode();
        }

        public void HastenTester(Tester tester)
        {
            Console.WriteLine("Поторопил Тестера");
            tester.TestCode();
        }

        public void ManageProject()
        {
            Console.WriteLine("Контролирую веб проект");
        }
    }
}
