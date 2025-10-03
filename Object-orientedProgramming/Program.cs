
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

public class Beer
{
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    private decimal _alcohol;
    public decimal Alcohol
    {
        get { return _alcohol; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            _alcohol = value;
        }
    }

    public Beer(string name, decimal price, decimal alcohol)
    {
        Name = name;
        Price = price;
        Alcohol = alcohol;
    }

    public string SAlcohol
    {
        get { return "Alcohol: " + _alcohol.ToString(); }
    }

    public string GetInfo()
    {
        return "Nombre: " + Name + ", Precio: $" + Price + ", Grados de alcohol: " + Alcohol;
    }
}