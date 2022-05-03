using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public class AbsenceHandler : AbstractHandler
    {
        public int Y { get; }
        public int Z { get; }
        

        public AbsenceHandler(int y, int z)
        {
            Y = y;
            Z = z;
        }

        public override double HandleRequest(Employee employee)
        {
            if(employee.Age < Y && employee.AbsenceRate < Z)
                return 180;
            return base.HandleRequest(employee);
        }

        
    }
}