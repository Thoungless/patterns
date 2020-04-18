using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда__Command_
{
    class Computer
    {
        bool isStarted = false;
        bool HardDriveOpened = false;
        public void On()
        {
            Console.WriteLine("Компьютер включился");
            isStarted = true;
        }
        public void off()
        {
            Console.WriteLine("Компьютер выключился");
            isStarted = false;
        }

        public void OnOff()
        {
            if (isStarted)
            {
                if (HardDriveOpened)
                    Cloce();
                off();
            }
            else
                On();
        }

        public void Open()
        {
            Console.WriteLine("Дисковод открылся");
            HardDriveOpened = true;
        }
        public void Cloce()
        {
            Console.WriteLine("Дисковод закрылся");
            HardDriveOpened = false;
        }

        public void OpenCloce()
        {
            if (isStarted && !HardDriveOpened)
                Open();
            else if (isStarted && HardDriveOpened)
                Cloce();
        }
    }
}
