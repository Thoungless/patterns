using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ProjectTeamFactory
{
    interface Developer
    {
        string name { get; }
        void WriteCode();
    }
}
