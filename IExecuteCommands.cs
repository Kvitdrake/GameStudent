using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameStudent
{
    interface IExecuteCommands 
    {
         string GoWalk();
        string GoSleep();
        string Eating();
        string GoStudy();
        string Run();
        string PrintCommand();
        string ShowData();

    }
}
