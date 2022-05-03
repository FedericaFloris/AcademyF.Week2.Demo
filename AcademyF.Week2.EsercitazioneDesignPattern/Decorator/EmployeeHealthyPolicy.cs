using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeHealthyPolicy : EmployeeDecorator
    {
        
        public string Code { get; set; }

        public EmployeeHealthyPolicy(Employee employee, string code) : base(employee)
        {
            
            Code = code;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{Code}";
        }
    }
}