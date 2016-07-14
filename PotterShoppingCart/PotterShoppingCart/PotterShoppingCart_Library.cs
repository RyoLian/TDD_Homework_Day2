using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart_Library
{
    public class PotterShoppingCart
    {
        public int CalTotalPay(int First)
        {
            var TotalPay = 0;
            TotalPay = First * 100;
            return TotalPay;
        }
    }
}