using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Demo
{
    public class Employee : Person
    {
        public string Company { get; set; }

        public double CalculateSalary()
        {
            return 1000 * DateOfBirth.Year;
        }

        public override string ToString()
        {
            return $"Sono un impiegato della {Company}";
        }
    }
}
