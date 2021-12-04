using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    enum LoggerTypes
    {
        Error,
        Info,
        Warning
    }

    class Logger
    {
        private static Logger instance;

        private Logger()
        { }

        public static Logger Instance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        private StringBuilder _log = new StringBuilder();

        public void Log(LoggerTypes type, string message)
        {
            string logMessage = $"{DateTime.Now}:{type}:{message}";
            Console.WriteLine(logMessage);

            _log.AppendLine(logMessage);
        }

        public string GetLog()
        {
            return _log.ToString();
        }
    }
}
