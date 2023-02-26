using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class EastCommand:RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (!robot.IsPowered)
            {
                Console.WriteLine("Robot is turned off");
                return;
            }
            robot.X++;
        }
    }
}
