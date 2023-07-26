using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg32
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of SportsBike class
            SportsBike s1 = new SportsBike();
            s1.brake();

            // create an object of MountainBike class
            MountainBike m1 = new MountainBike();
            m1.brake();

            Console.ReadLine();
        }
    }
}
