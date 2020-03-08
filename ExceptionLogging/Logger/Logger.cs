using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionLogging.Logger
{
    public sealed class Logger : ILogger
    {

        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
        public static Logger GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        //private Logger()
        //{

        //}

        public void LogException(string exceptionMessage)
        {
            throw new NotImplementedException();
        }
    }
}