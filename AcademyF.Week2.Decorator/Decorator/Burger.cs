using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Decorator.Decorator
{
    public class Burger
    {
        public string Name { get; set; } = "Hamburger";

        public double Price { get; set; } = 2.5;

        public virtual string Eat()
        {
            return $"Sto mangiando un {Name}";
        }
    }
}
