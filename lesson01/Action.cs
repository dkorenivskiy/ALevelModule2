using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    class Action
    {
        private Logger logger = Logger.Instance();


        public Result InfoMethod()
        {
            logger.Log(LoggerTypes.Info, "Start method: InfoMethod");

            Result result = new Result
            {
                Status = true
            };

            return result;
        }

        public Result WarningMethod()
        {
            logger.Log(LoggerTypes.Warning, "Skipped logic in method: WarningMethod");

            Result result = new Result
            {
                Status = true
            };

            return result;
        }

        public Result ErrorMethod()
        {
            Result result = new Result
            {
                Status = false,
                Error = "I broke a logic"
            };

            return result;
        }
    }
}
