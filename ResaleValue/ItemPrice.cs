using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResaleValue
{
    class ItemPrice
    {
        public decimal WholeSalePrice { get; set; }

        public ItemPrice(decimal price)
        {
            WholeSalePrice = price;
        }
    }
}
