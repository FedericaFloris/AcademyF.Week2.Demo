using AcademyF.Week2.EsercitazioneDesignPattern.Chain;
using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Test
{
    public class YearsOfServiceHandler : AbstractHandler
    {
        public int A { get; set; }

        public YearsOfServiceHandler(int a)
        {
            A = a;
        }

        public override double HandleRequest(Employee employee)
        {
            if (employee.YearsOfService > 43)
                return 700.0;
            else
                return base.HandleRequest(employee);
        }


    }
}