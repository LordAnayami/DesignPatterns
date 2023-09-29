using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public class Offline : ISource
    {
        public string GetSourceName()
        {
            return "Dot Net Tutorials Class Room Training";
        }
    }
}
