using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Tuples
    {
        [TestMethod]
        public void Tuples_Test()
        {
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "cat", true);

            if (myTuple.Item1 == 1)
            {
                Console.WriteLine(myTuple.Item1);
            }
            if (myTuple.Item2 == "dog")
            {
                Console.WriteLine(myTuple.Item2);
            }
            if (myTuple.Item3)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }
    }
}
