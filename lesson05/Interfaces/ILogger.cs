using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    interface ILogger
    {
        public void Log(LoggerTypes type, string message);

        public string GetLog();
    }
}
