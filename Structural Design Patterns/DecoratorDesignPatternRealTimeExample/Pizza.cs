﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    // This is the Base Component interface that defines operations that can be altered by decorators
    public interface Pizza
    {
        string MakePizza();
    }
}
