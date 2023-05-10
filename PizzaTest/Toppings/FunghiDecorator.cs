using PizzaTest.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Toppings
{
    public class FunghiDecorator : ToppingPizzaDecorator
    {
        public FunghiDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, Funghi";
        }

        public override int GetPrice()
        {
            return _pizza.GetPrice() + 2;
        }
    }
}
