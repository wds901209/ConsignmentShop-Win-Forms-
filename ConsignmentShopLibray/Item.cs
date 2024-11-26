using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibray
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }    //假設商品10元，commision 是 50% 那就要給店家(讓別人寄賣的) 5$; 供應商拿 5$
        public Vendor Owner { get; set; }


        public string Display
        {
            get
            {
                return string.Format("{0} - ${1}", Title, Price);
            }
        }
    }
}
