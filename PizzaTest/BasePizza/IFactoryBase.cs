using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.BasePizza
{
    internal interface IFactoryBase
    {
        IPizza CreatePizza(string type);
    }
}
