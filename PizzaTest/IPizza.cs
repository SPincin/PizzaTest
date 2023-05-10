using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest
{
    public interface IPizza
    {
        string GetDescription();
        int GetPrice();
    }
}
