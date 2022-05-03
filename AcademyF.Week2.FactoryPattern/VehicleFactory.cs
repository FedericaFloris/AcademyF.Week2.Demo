using AcademyF.Week2.FactoryPattern.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(int numWheels)
        {
            IVehicle vehicle = null;
            //controllo dell'input
            if (numWheels == 0)
                return null;
            //eseguo la creazione sulla base del parametro passato
            switch (numWheels)
            {
                case 1:
                    Console.WriteLine("Non posso creare veicoli con una ruota! Non siamo acrobati!");
                    vehicle = null;
                    break;
                case 2:
                    vehicle = new Bike() { NumWheels = numWheels };
                    break;
                case 4:
                    vehicle = new Car() { NumWheels = numWheels };
                    break;
                case 6:
                    vehicle = new Bus() { NumWheels = numWheels };
                    break;
                default:
                    vehicle = null;
                    break;
            }

            return vehicle;
        }

    }
}
