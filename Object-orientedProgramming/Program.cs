using Object_orientedProgramming.Business;


Beer erdingerBeer = new Beer("Erdinger", 3, -2);
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


var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01));
System.Console.WriteLine(delirium.GetInfo());
System.Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
System.Console.WriteLine(delirium.GetInfo(3));