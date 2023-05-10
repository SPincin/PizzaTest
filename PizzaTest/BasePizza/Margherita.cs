using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.BasePizza
{
    internal class Margherita : IPizza
    {
        public string GetDescription() => "Margherita";

        public int GetPrice() => 7;
    }
}
