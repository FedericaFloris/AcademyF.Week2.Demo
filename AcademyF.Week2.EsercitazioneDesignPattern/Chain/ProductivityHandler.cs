using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public class ProductivityHandler : AbstractHandler
    {
        public int Y { get; }
        public int W { get;  }
        

        public ProductivityHandler(int y, int w)
        {
            Y = y;
            W = w;
        }

        public override double HandleRequest(Employee employee)
        {
            if (employee.Age < Y && employee.ProductivityRate > W)
                return 300.0;
            else
                return base.HandleRequest(employee);
        }

        
    }
}