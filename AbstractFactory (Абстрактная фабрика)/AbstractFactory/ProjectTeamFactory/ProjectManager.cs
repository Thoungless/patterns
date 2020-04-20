using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ProjectTeamFactory
{
    interface ProjectManager
    {
        string name { get; }
        void ManageProject();

        void HastenDeveloper(Developer dev);
        void HastenTester(Tester tester);
    }
}
