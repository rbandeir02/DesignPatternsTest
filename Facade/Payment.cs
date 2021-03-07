using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Facade
{
    class Payment
    {
        public string MakePayment()
        {
            return "Payment Done Successfully" + Environment.NewLine;
        }
    }
}
