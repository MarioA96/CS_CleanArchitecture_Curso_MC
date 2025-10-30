using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Object_orientedProgramming.Business
{
    public class Wine : Drink
    {
        private const string Category = "Vino";

        public Wine(int quantity) : base(quantity)
        {
        }

        public override string GetCategory() => Category; // Me ahorra las llaves y el return
    }
}