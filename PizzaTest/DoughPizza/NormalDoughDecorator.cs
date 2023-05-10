using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.DoughPizza
{
    public class NormalDoughDecorator : IPizza
    {
        private readonly IPizza _pizza;
        private readonly int _doughPrice;
        private readonly string _doughType;

        public NormalDoughDecorator(IPizza pizza)
        {
            _pizza = pizza;
            _doughPrice = 0;
            _doughType = "normale";
        }

        public string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {_doughType}";
        }

        public int GetPrice()
        {
            return _pizza.GetPrice() + _doughPrice;
        }
    }

}
