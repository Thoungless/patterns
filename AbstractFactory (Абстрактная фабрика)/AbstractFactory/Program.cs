using AbstractFactory.DesktopProject;
using AbstractFactory.ProjectTeamFactory;
using AbstractFactory.WebsiteProject;
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

            ProjectTeamFactory.ProjectTeamFactory webTeam = new WebTeamProject();
            Developer phpDev = webTeam.GetDeveloper("Ваня");
            ProjectManager webPm = webTeam.GetProjectManager("Дима");
            Tester webTester = webTeam.GetTester("Аркадий");


            Console.WriteLine("desktopTeam");
            dotnetDev.WriteCode();
            pMDesktop.ManageProject();
            qATester.TestCode();
            Console.WriteLine();
            pMDesktop.HastenDeveloper(dotnetDev);
            Console.WriteLine();
            pMDesktop.HastenTester(qATester);

            Console.WriteLine();

            Console.WriteLine("webTeam");
            phpDev.WriteCode();
            webPm.ManageProject();
            webTester.TestCode();
            Console.WriteLine();
            webPm.HastenDeveloper(phpDev);
            Console.WriteLine();
            webPm.HastenTester(webTester);

            Console.ReadKey();
        }
    }
}
