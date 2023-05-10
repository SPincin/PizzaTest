using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.BasePizza
{
    internal class Bianca : IPizza
    {
        public string GetDescription() => "Bianca";
        
        public int GetPrice() => 5;
        
    }
}
