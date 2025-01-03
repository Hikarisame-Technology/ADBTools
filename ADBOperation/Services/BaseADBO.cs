using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation.Services
{
    abstract class BaseADBO
    {
        private BaseADBFile _adbFile;

        protected ProcessStartInfo _adbPSInfo;

        protected ProcessStartInfo _fBootPSInfo;

        protected Process _process = new Process();

        public abstract string RunCommand(string args,bool t);

        public BaseADBO(BaseADBFile adbFile)
        {
            _adbFile = adbFile;
           _adbPSInfo = new ProcessStartInfo
           {
               FileName = adbFile._AdbFilePath,
               RedirectStandardOutput = true,
               RedirectStandardError = true,
               UseShellExecute = false,
               CreateNoWindow = true
           };
            _fBootPSInfo = new ProcessStartInfo
            {
                FileName = adbFile._AdbFilePath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
        }
    }
}
