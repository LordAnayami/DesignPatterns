using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletoninMVC.Logger
{
    public interface ILog
    {
        void LogException(string message);
    }
}