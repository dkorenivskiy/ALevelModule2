using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    class Config
    {
        public DirectoryConfig Directory { get; set; }
    }

    class DirectoryConfig
    {
        public string Path { get; set; }
        public string Name { get; set;  }
    }
}
