using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation.Models
{
    internal class LocalADBFile : BaseADBFile
    {
        public override string _AdbFilePath
        {
            get; set;
        }
        public override string _FbootFilePath { get; set; }

        public LocalADBFile()
        {
            _AdbFilePath = "./adb/adb.exe";
            _FbootFilePath = "./adb/fastboot.exe";
        }
    }
}
