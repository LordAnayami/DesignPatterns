using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternRealTimeExample
{
    //Declaring the Interface for Cache Operations
    //This Interface is going to be Implemented by Singleton Class
    public interface IMyCache
    {
        bool Add(object key, object value);
        bool AddOrUpdate(object key, object value);
        object Get(object key);
        bool Remove(object key);
        void Clear();
    }
}
