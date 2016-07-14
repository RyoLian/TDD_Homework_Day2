using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart_Library
{
    public class PotterShoppingCart
    {
        public int CalTotalPay(int First, int Second)
        {
            var TotalPay = 0;
            if (First > 0 && Second > 0)
            {
                TotalPay = (First + Second) * 95; // 100*0.95 = 95
            }
            else
            {
                TotalPay = (First + Second) * 100;
            }
            return TotalPay;
        }
    }
}