using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBOperation.Services
{
        // This Class Not implement
    internal class NetADBO : BaseADBO
    {
        public NetADBO(BaseADBFile adbFile) : base(adbFile)
        {
        }

        public override string RunCommand(string args, bool t)
        {
            throw new NotImplementedException();
        }
    }
}
