using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    class Starter
    {
        private Logger _logger = Logger.Instance();

        public void Run()
        {
            var action = new Action();

            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var x = random.Next(1, 4);
                Result result;
                switch (x)
                {
                    case 1:
                        result = action.InfoMethod();
                        break;
                    case 2:
                        result = action.WarningMethod();
                        break;
                    case 3:
                    default:
                        result = action.ErrorMethod();
                        break;
                }

                if(result.Status == false)
                {
                    _logger.Log(LoggerTypes.Error, $"Action failed by a reason: {result.Error}");
                }
            }
        }
    }
}
