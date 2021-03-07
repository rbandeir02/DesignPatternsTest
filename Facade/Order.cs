using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Facade
{
    class Order
    {
        public string PlaceOrder()
        {
            string s = "";
            s = s + "Place Order Started" + Environment.NewLine;
            Product product = new Product();
            s = s + product.GetProductDetails();
            Payment payment = new Payment();
            s = s + payment.MakePayment();
            Invoice invoice = new Invoice();
            s = s + invoice.Sendinvoice();
            s = s + "Order Placed Successfully" + Environment.NewLine;
            return s;
        }
    }
}
