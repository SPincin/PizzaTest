using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.BasePizza
{
    internal class Napoletana : IPizza
    {
        public string GetDescription() => "Napoletana"; 
        public int GetPrice() => 3;
    }
}
