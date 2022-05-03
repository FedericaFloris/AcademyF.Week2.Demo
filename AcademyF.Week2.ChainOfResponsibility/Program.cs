using AcademyF.Week2.ChainOfResponsibility.Handler;

IHandler lion = new LionHandler();
IHandler tiger = new TigerHandler();
IHandler zebra = new ZebraHandler();

//stabilisco l'ordine in cui verrà gestita la richiesta dall'inizio alla fine
lion.SetNext(zebra).SetNext(tiger);

Console.WriteLine(lion.Handle("Insalata"));

Console.WriteLine(lion.Handle("Pasta"));