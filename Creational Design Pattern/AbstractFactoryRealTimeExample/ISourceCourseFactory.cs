using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    public interface ISourceCourseFactory
    {
        ISource GetSource();
        ICourse GetCourse();
    }
}
