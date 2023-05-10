using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.DoughPizza
{
    public class WholeWheatDoughDecorator : IPizza
    {
        private readonly IPizza _pizza;
        private readonly string _doughType;
        private readonly int _doughPrice;

        public WholeWheatDoughDecorator(IPizza pizza)
        {
            _pizza = pizza;
            _doughType = "integrale";
            _doughPrice = 1;
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
