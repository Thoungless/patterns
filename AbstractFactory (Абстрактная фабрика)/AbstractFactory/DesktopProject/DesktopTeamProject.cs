using AbstractFactory.ProjectTeamFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesktopProject
{
    class DesktopTeamProject : ProjectTeamFactory.ProjectTeamFactory
    {
        public Developer GetDeveloper(string name)
        {
            return new DotNetDeveloper(name);
        }

        public ProjectManager GetProjectManager(string name)
        {
            return new PMDesktop(name);
        }

        public Tester GetTester(string name)
        {
            return new QATester(name);
        }
    }
}
