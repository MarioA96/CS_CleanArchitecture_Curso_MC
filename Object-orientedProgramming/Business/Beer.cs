namespace Object_orientedProgramming.Business
{
    public class Beer : Drink, ISellable, ISend
    {
        private const string Category = "Cerveza";
        public string? Name { get; set; }
        protected decimal Price { get; set; }
        private decimal _alcohol;

        public static int QuantityObjects;

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

        public Beer(
                string name, decimal price, decimal alcohol, // Own class attributes
                int quantity    // Abstract class attributes, Drink
            )
            : base(quantity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
            QuantityObjects++;
        }

        public string SAlcohol
        {
            get { return "Alcohol: " + _alcohol.ToString(); }
        }

        public virtual string GetInfo()
        {
            return "Nombre: " + Name + ", Precio: $" + Price + ", Grados de alcohol: " + Alcohol;
        }

        public string GetInfo(string message)
        {
            return message + " " + GetInfo();
        }
        public string GetInfo(int number)
        {
            return number + ".- " + GetInfo();
        }

        public override string GetCategory()
        {
            return Category;
        }

        public decimal GetPrice() => Price;

        public void Send()
        {
            Console.WriteLine("Se envia por correo: " + GetInfo());
        }
    }
}