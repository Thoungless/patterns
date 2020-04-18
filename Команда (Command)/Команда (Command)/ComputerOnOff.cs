using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда__Command_
{
    class ComputerOnOff : ICommand
    {
        Computer comp;

        public ComputerOnOff(Computer compset)
        {
            comp = compset;
        }
        public void Execute()
        {
            comp.OnOff();
        }

        public void Undo()
        {
            comp.OnOff();
        }
    }
}
