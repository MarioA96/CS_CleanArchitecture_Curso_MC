

namespace Object_orientedProgramming.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }

        public Drink(int quantity)
        {
            this.Quantity = quantity;
        }

        // Here we DO specify the method and the actual behavior, not abstract
        public string GetQuantity()
        {
            return Quantity + " ml";
        }

        // Here we DO ONLY specify the method but not the actual behavior, abstract
        public abstract string GetCategory();
    }
}