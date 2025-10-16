

namespace Object_orientedProgramming.Business
{
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }

        public ExpiringBeer(
                string name, decimal price, decimal alcohol,  // For parent class, Beer
                DateTime expiration, // Own attributes of the class
                int quantity    // For Abstract class, Drink
            )
                : base(
                    name, price, alcohol, // Parent class Beer
                    quantity // Abstract class Drink
                )
        {
            Expiration = expiration;
            var p = Price;
        }

        public override string GetInfo()
        {
            return "Cerveza con caducidad: " + Name + ", "
                    + "Precio: $" + Price + ", Alcohol: " + Alcohol
                    + ", Caducidad: " + Expiration.Date.ToString();
        }
    }
}