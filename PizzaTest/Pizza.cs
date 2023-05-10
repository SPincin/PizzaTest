using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest
{
    internal class Pizza : IPizza
    {
        public string GetDescription() => string.Empty;

        public int GetPrice() => 0;
        
    }
}
