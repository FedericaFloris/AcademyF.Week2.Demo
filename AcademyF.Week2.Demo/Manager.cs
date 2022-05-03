using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Demo
{
    public class Manager : Employee
    {
        public int NumEmployees { get; set; }

        public override string ToString()
        {
            return $"Sono un manager responsabile di {NumEmployees}";
        }
    }
}
