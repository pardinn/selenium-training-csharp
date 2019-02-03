using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void Test_Miles_Per_Gallon()
        {
            Trip trip = new Trip("New York", 1200, 120M,40);
            Console.WriteLine(trip.MilesPerGallon());
            Assert.AreEqual(30, trip.MilesPerGallon());
        }

        [TestMethod]
        public void Test_Cost_Per_Mile()
        {
            Trip trip = new Trip("New York", 1200, 120M, 40);
            Console.WriteLine(trip.CostPerMile());
            Assert.AreEqual(0.1M, trip.CostPerMile());
        }

        [TestMethod]
        public void Test_To_String()
        {
            Trip trip = new Trip("New York", 1200, 120M, 40);
            Console.WriteLine(trip);
        }
    }
}
