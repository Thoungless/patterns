using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ProjectTeamFactory;

namespace AbstractFactory.WebsiteProject
{
    class WebTester : Tester
    {
        public string name { get; private set; }

        public WebTester(string name)
        {
            this.name = name;
        }

        public void TestCode()
        {
            Console.WriteLine("Тестирую веб проект");
        }
    }
}
