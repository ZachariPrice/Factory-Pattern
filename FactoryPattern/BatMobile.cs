using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BatMobile : IVehicle
    {
        public BatMobile() 
        {  
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The BatMobile is ready to drive to crime");
        }
    }
}
