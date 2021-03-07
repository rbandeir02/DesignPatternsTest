using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Facade
{
    class Invoice
    {
        public string Sendinvoice()
        {
           return "Invoice Send Successfully" + Environment.NewLine;
        }
    }
}
