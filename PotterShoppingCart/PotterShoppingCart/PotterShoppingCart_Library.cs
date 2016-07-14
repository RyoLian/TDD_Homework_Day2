namespace PotterShoppingCart_Library
{
    public class PotterShoppingCart
    {
        private int[] _FeeRate = new int[] { 100, 95, 90, 80, 75 };

        public int CalTotalPay(int First, int Second, int third, int forth, int fifth)
        {
            var TotalPay = 0;

            int[] list = { First, Second, third, forth, fifth };
            int kind = 0;
            var TotalCount = First + Second + third + forth + fifth;

            for (int i = 0; i <= list.Length - 1; i++)
            {
                if (list[i] > 0)
                {
                    kind++;
                }
            }
            return TotalPay = TotalCount * _FeeRate[kind - 1];
        }
    }
}