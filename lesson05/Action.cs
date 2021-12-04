using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    class Action : Exception
    {
        private Logger logger = Logger.Instance();


        public bool InfoMethod()
        {
            logger.Log(LoggerTypes.Info, "Start method: InfoMethod\n");

            return true;
        }

        public void WarningMethod()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public void ErrorMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
