﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class NorthCommand:IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (!robot.IsPowered)
            {
                Console.WriteLine("Robot is turned off");
                return;
            }
            robot.Y++;
        }
    }
}
