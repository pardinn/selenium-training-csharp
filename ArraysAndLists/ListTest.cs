using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraysAndLists
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test_Creating_Lists()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add("Today");
            myArray.Add(2);
            myArray.Add(20);
            myArray.Add(20M);

            Console.WriteLine(myArray.Count);
            myArray.RemoveAt(3);
            Console.WriteLine(myArray.Count);

        }

        [TestMethod]
        public void Testing_ArrayList()
        {
            ArrayList scores = new ArrayList();
            FillList(scores);
            int sum = TotalScores(scores);
            Console.WriteLine(sum);
        }

        private int TotalScores(ArrayList scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        private void FillList(ArrayList scores)
        {
            for (int i = 0; i <= 20; i++)
            {
                scores.Add(i);
            }
        }

        [TestMethod]
        public void ArrayList_Practice()
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            list.Add(45);
            list.Add(78);
            list.Add(33);
            list.Add(56);
            list.Add(12);
            list.Add(23);
            list.Add(9);

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);

            Console.Write("Content: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nSorted Content: ");
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
