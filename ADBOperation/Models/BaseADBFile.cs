using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation
{
    abstract class BaseADBFile
    {
        public abstract string _AdbFilePath { get; set; }
        public abstract string _FbootFilePath { get; set; }

    }
}
