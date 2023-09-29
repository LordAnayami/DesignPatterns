using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public class BackEndCourse : ICourse
    {
        public string GetCourseName()
        {
            return "C#, ADO and SQL Server";
        }
        public int GetCourseFee()
        {
            return 1000;
        }
        public string GetCourseDuration()
        {
            return "6 Months";
        }
    }
}
