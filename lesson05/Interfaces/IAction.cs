using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson05
{
    interface IAction
    {
        public bool InfoMethod();

        public void WarningMethod();

        public void ErrorMethod();
    }
}
