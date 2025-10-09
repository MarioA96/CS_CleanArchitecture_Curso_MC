namespace Object_orientedProgramming.Business
{
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
}