namespace PotterShoppingCart_Library
{
    public class PotterShoppingCart
    {
        private int[] _FeeRate = new int[] { 0, 100, 95, 90, 80, 75 };

        public int CalTotalPay(int First, int Second, int third, int forth, int fifth)
        {
            var TotalPay = 0;
            int[] list = { First, Second, third, forth, fifth };

            return Calculator(ref TotalPay, list);
        }

        private int Calculator(ref int TotalPay, int[] list)
        {
            var kind = 1; //default=1 for 第一次進入迴圈
            while (kind > 0)
            {
                kind = 0;
                for (int i = 0; i <= list.Length - 1; i++)
                {
                    if (list[i] > 0)
                    {
                        kind += 1;
                        list[i] -= 1;
                    }
                }
                TotalPay += kind * _FeeRate[kind];
            }
            return TotalPay;
        }
    }
}