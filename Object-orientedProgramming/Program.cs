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