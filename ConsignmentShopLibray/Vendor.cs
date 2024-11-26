using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibray
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commision { get; set; }
        public decimal PaymentDue {  get; set; }    //計算要給vnedors多少錢

        public Vendor()
        {
            Commision = .5;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - {2}", FirstName, LastName, PaymentDue);
            }
        }
    }
}
