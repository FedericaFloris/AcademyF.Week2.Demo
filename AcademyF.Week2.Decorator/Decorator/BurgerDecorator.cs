using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Decorator.Decorator
{
    public class BurgerDecorator : Burger
    {
        public Burger BurgerWrapped { get; set; }

        public BurgerDecorator(Burger burger)
        {
            BurgerWrapped = burger;
        }

        public override string Eat()
        {
            return base.Eat();
        }

    }
}
