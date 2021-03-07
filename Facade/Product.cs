using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Facade
{
    class Product
    {
        public string GetProductDetails()
        {
            return "Fetching the Product Details" + Environment.NewLine;
        }
    }
}
