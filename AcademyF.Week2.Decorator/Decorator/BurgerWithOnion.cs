using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Decorator.Decorator
{
    public class BurgerWithOnion : BurgerDecorator
    {
        public string Onion { get; set; }
        public BurgerWithOnion(Burger burger, string onion) : base(burger)
        {
            Onion = onion;
            Price = BurgerWrapped.Price + 0.5;
        }

        public override string Eat()
        {
            return BurgerWrapped.Eat() + $" con {Onion}";
        }
    }
}
