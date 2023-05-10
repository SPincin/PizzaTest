using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.DoughPizza
{
    public class PizzaWithDough : IPizza
    {
        private readonly IPizza _pizza;
        private readonly string _doughType;
        private readonly int _doughPrice;

        public PizzaWithDough(IPizza pizza, string doughType)
        {
            _pizza = pizza;
            _doughType = doughType;
            
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
