using PizzaTest.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Toppings
{
    internal class FunghiDecorator:ToppingPizzaDecorator
    {
        public FunghiDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, Prosciutto Cotto";
        }

        public override int GetPrice()
        {
            return _pizza.GetPrice() + 1;
        }
    }
}
