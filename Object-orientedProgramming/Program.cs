using Object_orientedProgramming.Business;


Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000); // Using their own class Beer and adding the attribute from the abstract class, Drink
// {
//     Name = ,
//     Price = 3,
// };

// var coronaBeer = new Beer("Corona", 1.5m);
// coronaBeer.Name = "Corona";
// coronaBeer.Price = 1.5m;

Console.WriteLine(erdingerBeer.Name);
// System.Console.WriteLine(coronaBeer.Name + " $ " + coronaBeer.Price);
Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(erdingerBeer.SAlcohol);


// Creation of an object Expiring with inherited class Beer, adding an additional attr from the abstract class impl Drink
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 330);
System.Console.WriteLine(delirium.GetInfo());
System.Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
System.Console.WriteLine(delirium.GetInfo(3));

System.Console.WriteLine("Category: " + delirium.GetCategory());


// We cannot intianted an abstract class but rather impl their inherited impl, limited to to their own methods
// Drink drink = new Drink();
Drink drink = new Beer("Erdinger", 3, -2, 1000); // Using the abstract class, Drink
//It serves a curated list of limited methods, so that only abstracts its functionality
// So we cannot put in use the method from Beer like, drink.getInfo()
Console.WriteLine("Quantity: " + drink.GetQuantity() + ", category: " + drink.GetCategory());

//* Polimorphism with abstract classes
Drink drink2 = new Wine(500);
Show(drink2);
drink2 = new Beer("Corona", 2, 4, 330);
Show(drink2);
Show(erdingerBeer);

void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());

SendSomething(erdingerBeer);

void SendSomething(ISend some)
{
    Console.WriteLine("Se hace algo...");
    some.Send();
    Console.WriteLine("Se hace algo mas...");
}

//* Interfaces
var service = new Service(100, 10);
ISellable[] concepts = [
    erdingerBeer,
    delirium,
    service
];
decimal GetTotal(ISellable[] concepts)
{
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }

    return total;
}
Console.WriteLine(GetTotal(concepts));

//* Generics
var elements = new Collection<int>(3);
elements.Add(100);
elements.Add(150);
elements.Add(160);
elements.Add(170);
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}
var names = new Collection<string>(2);
names.Add("Mario");
names.Add("Juan");
names.Add("Caro");
foreach (var name in names.Get())
{
    Console.WriteLine(name);
}
var beers = new Collection<Beer>(2);
beers.Add(erdingerBeer);
beers.Add(delirium);
foreach (var beer in beers.Get())
{
    Console.WriteLine(beer.GetInfo());
}

//* Static
Console.WriteLine($"Objectos crados: {Beer.QuantityObjects}");
Console.WriteLine(Operations.Add(13, 14));
System.Console.WriteLine(Operations.Mul(10, 20));