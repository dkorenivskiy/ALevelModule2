using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    class Starter
    {
        private Logger _logger = Logger.Instance();
        private FileService _fileService = new FileService();

        public void Run()
        {
            var action = new Action();

            var random = new Random(3);
            for (int i = 0; i < 100; i++)
            {
                var x = random.Next(1, 4);

                try
                {
                    switch (x)
                    {
                        case 1:
                            action.InfoMethod();
                            break;
                        case 2:
                            action.WarningMethod();
                            break;
                        case 3:
                        default:
                            action.ErrorMethod();
                            break;
                    }
                }
                catch(BusinessException ex)
                {
                    _logger.Log(LoggerTypes.Warning, $"Action got this custom Exception: {ex.Message}\n");
                }
                catch(Exception ex)
                {
                    _logger.Log(LoggerTypes.Error, $"Action failed by a reason: {ex.Message}\n");
                }
            }

            _fileService.SaveLog();
        }
    }
}
