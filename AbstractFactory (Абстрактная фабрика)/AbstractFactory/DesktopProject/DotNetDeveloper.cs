using AbstractFactory.ProjectTeamFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesktopProject
{
    class DotNetDeveloper : Developer
    {
        public string name { get; private set; }

        public DotNetDeveloper(string name)
        {
            this.name = name;
        }
        public void WriteCode()
        {
            Console.WriteLine($"Я {name} пишу код на C#");
        }
    }
}
