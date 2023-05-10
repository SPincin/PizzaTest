using PizzaTest.BasePizza;
using PizzaTest.Decorator;
using PizzaTest.DoughPizza;
using PizzaTest.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Order
{
    internal class OrderSetUp
    {
        private readonly IFactoryBase _baseFactory;
         

        public OrderSetUp(IFactoryBase baseFactory)
        {
            _baseFactory = baseFactory;
        }

        public IPizza CreatePizzaFromInput(string input)
        {
            string[] parts = input.Split(';');
            if (parts.Length < 2) throw new ArgumentException("Input non valido");

            string pizzaType = parts[0];
            string doughType = parts[1];

            IPizza pizza = _baseFactory.CreatePizza(pizzaType);
            pizza = new PizzaWithDough(pizza, doughType);

            if (parts.Length > 2)
            {
                string[] toppings = parts[2].Split(',');
                foreach (string topping in toppings)
                {
                    switch (topping)
                    {
                        case "Prosciutto Cotto":
                            pizza = new ProsciuttoCrudoDecorator(pizza);
                            break;
                        case "Funghi":
                            pizza = new FunghiDecorator(pizza);
                            break;
                        case "Prosciutto Crudo":
                            pizza = new ProsciuttoCrudoDecorator(pizza);
                            break;
                        case "Ananas":
                            pizza = new AnanasDecorator(pizza);
                            break;
                        default:
                            throw new ArgumentException("Topping non valido");
                    }
                }
            }

            return pizza;
        }
    }

}
