using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public class OfflineSourceCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }

        public ISource GetSource()
        {
            return new Offline();
        }
    }

    public class OnlineSourceFrontEndCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }

        public ISource GetSource()
        {
            return new Online();
        }
    }

    public class OfflineSourceBackEndCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse()
        {
            return new BackEndCourse();
        }

        public ISource GetSource()
        {
            return new Offline();
        }
    }
}
