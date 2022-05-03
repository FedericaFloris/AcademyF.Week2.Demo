using AcademyF.Week2.Decorator.Decorator;

//Scelgo un hamburger semplice
Burger burger = new Burger();
burger.Price = 2.5;
Console.WriteLine(burger.Eat());
Console.WriteLine($"Ho speso {burger.Price} euro");

//Scelgo un hamburger con formaggio, cioè un cheesebuger
CheeseBurger cheese = new CheeseBurger(burger, "cheddar");
Console.WriteLine(cheese.Eat());
Console.WriteLine($"Ho speso {cheese.Price} euro");

if (cheese.IsSpicy())
    Console.WriteLine("Molto piccante!");

//Scelgo un cheeseburger con onion
BurgerWithOnion burgerWithOnion = new BurgerWithOnion(cheese, "cipolla di Tropea");
Console.WriteLine(burgerWithOnion.Eat());
Console.WriteLine($"Ho speso {burgerWithOnion.Price} euro");

//Burger semplice con onion
BurgerWithOnion simpleBurgerWithOnion = new BurgerWithOnion(burger, "cipolla rossa");
Console.WriteLine(simpleBurgerWithOnion.Eat()); //Sto mangiando un hamburger con cipolla rossa
Console.WriteLine($"Ho speso {simpleBurgerWithOnion.Price} euro"); //2.5 + 0.5                                               