using AcademyF.Week2.FactoryPattern;
using AcademyF.Week2.FactoryPattern.Vehicles;

Console.WriteLine("========= Factory Pattern ==========");

Console.WriteLine("Quante ruote ha il veicolo");

int.TryParse(Console.ReadLine(), out int numOfWheels);

//SENZA FACTORY
#region SENZA FACTORY
//IVehicle vehicle = null;
////controllo dell'input
//if (numWheels == 0)
//    return null;
////eseguo la creazione sulla base del parametro passato
//switch (numWheels)
//{
//    case 1:
//        Console.WriteLine("Non posso creare veicoli con una ruota! Non siamo acrobati!");
//        vehicle = null;
//        break;
//    case 2:
//        vehicle = new Bike() { NumWheels = numWheels };
//        break;
//    case 4:
//        vehicle = new Car() { NumWheels = numWheels };
//        break;
//    case 6:
//        vehicle = new Bus() { NumWheels = numWheels };
//        break;
//    default:
//        vehicle = null;
//        break;
//}
#endregion

#region FACTORY
VehicleFactory factory = new VehicleFactory();
IVehicle vehicle = factory.GetVehicle(numOfWheels);
if(vehicle != null)
{
    vehicle.TravelTo("Vienna");
}
else
{
    Console.WriteLine("Veicolo non riconosciuto");
}
#endregion