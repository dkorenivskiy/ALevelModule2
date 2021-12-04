using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    class FileService : IFileService
    {
        private ILogger _logger;

        public FileService(ILogger logger)
        {
            _logger = logger;
        }

        public void SaveLog()
        {
            var configFile = File.ReadAllText("appsettings.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);

            DirectoryInfo directoryInfo = new DirectoryInfo(config.Directory.Path);

            char[] dateTime = DateTime.Now.ToString().ToCharArray();
            for (int i = 0; i < dateTime.Length; i++)
            {
                if (dateTime[i] == '/')
                {
                    dateTime[i] = '.';
                }

                if (dateTime[i] == ':')
                {
                    dateTime[i] = '.';
                }
            }

            string dateTimeNameLog = new string(dateTime);
            File.WriteAllText($"{config.Directory.Path}\\{dateTimeNameLog}.txt", _logger.GetLog());

            if (CheckFilesQuantity(config.Directory.Path))
            {
                return;
            }
            else
            {
                FileInfo[] files = directoryInfo.GetFiles();

                for (int i = 0; i < files.Length - 1; i++)
                {
                    for (int j = 0; j < files.Length; j++)
                    {
                        if (files[i].CreationTime < files[j].CreationTime)
                        {
                            FileInfo buffer = files[i];
                            files[i] = files[j];
                            files[j] = buffer;
                        }
                    }
                }

                files[0].Delete();
            }
        }

        private bool CheckFilesQuantity(string path)
        {
            string[] files = Directory.GetFiles(path);

            if (files.Length == 4)
                return false;
            else
                return true;
        }
    }
}
