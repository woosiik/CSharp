using System;
namespace DivByZeroExceptionApp
{
    class Program
    {
        public static void Main()
        {
            int i = 1, j = 0, k;
            k = i / j;
        }
    }
}
using System;
namespace IndexOutOfRangeApp
{
    class Program
    {
        public static void Main()
        {
            int[] vector = { 1, 2, 3 };
            vector[4] = 4;
        }
    }
}