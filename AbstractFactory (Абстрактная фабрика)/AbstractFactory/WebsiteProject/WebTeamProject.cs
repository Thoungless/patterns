using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ProjectTeamFactory;

namespace AbstractFactory.WebsiteProject
{
    class WebTeamProject : ProjectTeamFactory.ProjectTeamFactory
    {
        public Developer GetDeveloper(string name) => new PhpDeveloper(name);

        public ProjectManager GetProjectManager(string name) => new WebPM(name);

        public Tester GetTester(string name) => new WebTester(name);
    }
}
