using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg32
{
    class SportsBike:MotorBike
    {
        // provide implementation of abstract method
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }
    }
}
