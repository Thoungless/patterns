using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда__Command_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            ComputerOnOff pcOnOff = new ComputerOnOff(comp);
            OpenCloseHardDrive openCloseHard = new OpenCloseHardDrive(comp);
            Pult pult = new Pult();

            pult.SetCommand(pcOnOff);

            pult.PressButton();
            pult.PressUndo();
            pult.PressButton();

            pult.SetCommand(openCloseHard);

            pult.PressButton();

            pult.SetCommand(pcOnOff);

            pult.PressButton();



            Console.ReadKey();
        }
    }
}
