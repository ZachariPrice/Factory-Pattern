using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Hold the brake pedal.");
            Thread.Sleep(1000);
            Console.WriteLine("Push the start car button.");
            Thread.Sleep(1000);

        }
    }
}
