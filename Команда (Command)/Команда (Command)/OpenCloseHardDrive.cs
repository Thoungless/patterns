using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда__Command_
{
    class OpenCloseHardDrive : ICommand
    {
        Computer comp;

        public OpenCloseHardDrive(Computer copmset)
        {
            comp = copmset;
        }
        public void Execute()
        {
            comp.OpenCloce();
        }

        public void Undo()
        {
            comp.OpenCloce();
        }
    }
}
