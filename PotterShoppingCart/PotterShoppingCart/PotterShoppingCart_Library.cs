using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart_Library
{
    public class PotterShoppingCart
    {
        public int CalTotalPay(int First, int Second, int third, int forth)
        {
            var TotalPay = 0;
            if (First > 0 && Second > 0 && third > 0)
            {
                TotalPay = (First + Second + third) * 90; // 100*0.9 = 90
            }
            else if (First > 0 && Second > 0 || Second > 0 && third > 0 || First > 0 && third > 0)
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