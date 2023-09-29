using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public class OnlineSourceCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse()
        {
            return new BackEndCourse();
        }

        public ISource GetSource()
        {
            return new Online();
        }
    }
}
