using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class ABigSum
    {
        [TestMethod]
        public void TestMethod1()
        {
            int arCount = 5;

            long[] ar = Array.ConvertAll("1000000001 1000000002 1000000003 1000000004 1000000005".Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(ar);

            Assert.AreEqual(5000000015, result);
        }
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long sum=0;
            foreach (int num in ar)
            {
                if ((0 <= num) && (num <= Math.Pow(10, 10)))
                {
                    sum = sum + num;
                }
            }
            return sum;
        }
    }
}
