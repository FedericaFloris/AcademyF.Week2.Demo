using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.FactoryPattern.Vehicles
{
    public interface IVehicle
    {
        int NumWheels { get; set; }
        void TravelTo(string destination);
    }
}
