using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ProjectTeamFactory;

namespace AbstractFactory.WebsiteProject
{
    class PhpDeveloper : Developer
    {
        public string name { get; private set; }

        public PhpDeveloper(string name)
        {
            this.name = name;
        }
        public void WriteCode()
        {
            Console.WriteLine("Пишу Пхп код");
        }
    }
}
