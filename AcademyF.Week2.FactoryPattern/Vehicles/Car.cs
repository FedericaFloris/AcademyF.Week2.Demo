using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.FactoryPattern.Vehicles
{
    public class Car : IVehicle
    {
        public int NumWheels { get; set; }

        public void TravelTo(string destination)
        {
            Console.WriteLine($"Viaggio in auto verso {destination}");
        }
    }
}
