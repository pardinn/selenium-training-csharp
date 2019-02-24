using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArraysAndLists
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void Array_Test()
        {
            //14 positions, 0 - 13
            int[] scores = new int[14];

            //put a score in the first position
            scores[0] = 10;
            int score = scores[0];

            int numPositions = 10;
            int[] myArray = new int[numPositions];

        }

        [TestMethod]
        public void ForEach_Loop_Test()
        {
            int[] scores = { 2, 4, 6, 8, 10 };

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        [TestMethod]
        public void Pass_Array_Method()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            int sum = TotalScores(scores);
            Assert.AreEqual(30, sum);
        }

        private int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
