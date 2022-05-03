using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeParkingCar : EmployeeDecorator
    {
        
        public string ParkingCode { get; set; }

        public EmployeeParkingCar(Employee employee, string code) : base(employee)
        {
            
            ParkingCode = code;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{ParkingCode}";
        }

    }
}