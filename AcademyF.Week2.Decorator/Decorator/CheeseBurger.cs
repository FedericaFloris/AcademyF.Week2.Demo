using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Decorator.Decorator
{
    public class CheeseBurger : BurgerDecorator
    {
        public string Cheese { get; set; }
        public CheeseBurger(Burger burger, string cheese) : base(burger)
        {
            Name = "Cheeseburger";
            Cheese = cheese;
            Price = BurgerWrapped.Price + 1.0;
        }

        public override string Eat()
        {
            return BurgerWrapped.Eat() + $" con formaggio {Cheese}";
        }

        public bool IsSpicy()
        {
            if (Cheese.Trim().ToLower() == "cheddar")
                return false;
            return true;
        }
    }
}
