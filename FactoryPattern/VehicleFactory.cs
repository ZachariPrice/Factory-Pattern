﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
       public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 4:
                    return new Car();
                case 16:
                    return new Tank();
                case 6:
                    return new BatMobile();
                default:
                    return new Car();
            }
        }
    }
}
