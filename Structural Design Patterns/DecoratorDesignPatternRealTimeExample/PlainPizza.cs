using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    // Concrete Components provide default implementations of the operations.
    public class PlainPizza : Pizza
    {
        //The following MakePizza method returns the default Pizza
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
