using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.FactoryPattern.Vehicles
{
    public class Bike : IVehicle
    {
        public int NumWheels { get; set; }

        public void TravelTo(string destination)
        {
            Console.WriteLine($"Corro in bici verso {destination}");
        }
    }
}
