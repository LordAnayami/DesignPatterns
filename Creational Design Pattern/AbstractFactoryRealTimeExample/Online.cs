using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public class Online : ISource
    {
        public string GetSourceName()
        {
            return "Dot Net Tutorials Zoom Classes";
        }
    }
}
