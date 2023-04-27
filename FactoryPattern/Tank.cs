using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tank : IVehicle
    {
        public Tank() 
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The tank is trecking through the desert");
            Console.WriteLine("Chekekekekekekekekek *Tank noise*");
        }
    }
}
