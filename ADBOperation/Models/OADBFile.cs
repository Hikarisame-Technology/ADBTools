using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation.Models
{
    internal class OADBFile : BaseADBFile
    {
        public override string _AdbFilePath
        {
            get; set;
        }
        public override string _FbootFilePath { get; set; }

        public OADBFile(string AdbFilePath,string FbootFilePath)
        {
            _AdbFilePath = AdbFilePath;
            _FbootFilePath = FbootFilePath;
        }
    }
}
