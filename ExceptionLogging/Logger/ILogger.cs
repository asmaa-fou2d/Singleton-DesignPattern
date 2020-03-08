using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLogging.Logger
{
    public interface ILogger
    {
        void LogException(string exceptionMessage);
    }
}
