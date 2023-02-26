using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }
}
