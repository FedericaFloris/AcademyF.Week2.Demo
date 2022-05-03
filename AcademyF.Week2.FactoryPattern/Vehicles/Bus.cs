using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.FactoryPattern.Vehicles
{
    public class Bus : IVehicle
    {
        public int NumWheels { get; set; }

        public void TravelTo(string destination)
        {
            Console.WriteLine($"Tratta in autobus fino a {destination}");
        }
    }
}
