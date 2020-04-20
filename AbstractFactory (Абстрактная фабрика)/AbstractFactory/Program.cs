using AbstractFactory.DesktopProject;
using AbstractFactory.ProjectTeamFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectTeamFactory.ProjectTeamFactory desktopTeam = new DesktopTeamProject();
            Developer dotnetDev = desktopTeam.GetDeveloper("Миша");
            ProjectManager pMDesktop = desktopTeam.GetProjectManager("Олег");
            Tester qATester = desktopTeam.GetTester("Вася");


            Console.WriteLine("desktop team");
            dotnetDev.WriteCode();
            pMDesktop.ManageProject();
            qATester.TestCode();
            Console.WriteLine();
            pMDesktop.HastenDeveloper(dotnetDev);
            Console.WriteLine();
            pMDesktop.HastenTester(qATester);

            Console.ReadKey();
        }
    }
}
