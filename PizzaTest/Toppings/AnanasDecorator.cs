using PizzaTest.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Toppings
{
    public class AnanasDecorator : ToppingPizzaDecorator
    {
        public AnanasDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, Ananas";
        }

        public override int GetPrice()
        {
            
            return _pizza.GetPrice() + (_pizza.GetDescription().Contains("Ananas") ? -_pizza.GetPrice() : 0);
        }
    }
}
