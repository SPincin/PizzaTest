using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Decorator
{
    public abstract class ToppingPizzaDecorator : IPizza
    {
        protected readonly IPizza _pizza;

        public ToppingPizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public virtual int GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
