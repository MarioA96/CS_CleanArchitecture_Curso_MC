using Object_orientedProgramming.Business;


Beer erdingerBeer = new Beer("Erdinger", 3, -2);
// {
//     Name = ,
//     Price = 3,
// };

// var coronaBeer = new Beer("Corona", 1.5m);
// coronaBeer.Name = "Corona";
// coronaBeer.Price = 1.5m;

System.Console.WriteLine(erdingerBeer.Name);
// System.Console.WriteLine(coronaBeer.Name + " $ " + coronaBeer.Price);
System.Console.WriteLine(erdingerBeer.GetInfo());
System.Console.WriteLine(erdingerBeer.SAlcohol);

