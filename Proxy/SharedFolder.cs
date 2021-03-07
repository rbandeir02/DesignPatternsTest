using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Proxy
{
    class SharedFolder : ISharedFolder
    {
        public string PerformRWOperations()
        {
            return "Performing Read Write operation on the Shared Folder" + Environment.NewLine;
        }
    }
}
