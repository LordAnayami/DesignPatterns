using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public interface ICourse
    {
        string GetCourseName();
        int GetCourseFee();
        string GetCourseDuration();
    }
}
