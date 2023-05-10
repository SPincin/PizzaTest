using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.BasePizza
{
    public class FactoryBase:IFactoryBase
    { 
        public IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Margherita":
                    return new Margherita();
                case "Bianca":
                    return new Bianca();
                case "Napoletana":
                    return new Napoletana();
                default:
                    throw new ArgumentException("Tipo di pizza non valido");
            }
        }
    }
    






}
