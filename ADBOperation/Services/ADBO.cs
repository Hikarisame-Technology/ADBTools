using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation.Services
{
    internal class ADBO : BaseADBO
    {
        public ADBO(BaseADBFile adbFile) : base(adbFile)
        {
        }
        public override string RunCommand(string args, bool t)
        {
            string result;
            if (t)
            {
                _adbPSInfo.Arguments = args;
                _process.StartInfo = _adbPSInfo;
                _process.Start();
                using (var reader = _process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
                _process.WaitForExit();
                return result;
            }else
            {
                _fBootPSInfo.Arguments = args;
                _process.StartInfo = _fBootPSInfo;
                using (var reader = _process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
                _process.WaitForExit();
                return result;
            }
        }
    }
}
