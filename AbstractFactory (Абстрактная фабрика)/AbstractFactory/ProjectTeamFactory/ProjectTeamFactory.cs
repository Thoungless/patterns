using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ProjectTeamFactory
{
    interface ProjectTeamFactory
    {
        Developer GetDeveloper(string name);
        ProjectManager GetProjectManager(string name);
        Tester GetTester(string name);
    }
}
