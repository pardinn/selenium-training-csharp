using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MidTermExam
{
    [TestClass]
    public class ReceiptTest
    {
        //Valid values tests
        [TestMethod]
        public void Receipt_Number_Greater_Than_Zero()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(123, myReceipt.ReceiptNumber);
        }

        [TestMethod]
        public void Customer_Number_Greater_Than_Zero()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(1, myReceipt.CustomerNumber);
        }

        [TestMethod]
        public void Item_Number_Between_0_And_9999()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(505, myReceipt.ItemNumber);
        }

        [TestMethod]
        public void Unit_Price_Between_0_And_9999()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(5000M, myReceipt.UnitPrice);
        }

        [TestMethod]
        public void Quantity_Purchased_Greater_Than_Zero()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(2, myReceipt.QuantityPurchased);
        }

        // Invalid values tests
        [TestMethod]
        public void Receipt_Number_Greater_Than_Zero_Invalid()
        {
            Receipt myReceipt = new Receipt(-1, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(0, myReceipt.ReceiptNumber);

        }

        [TestMethod]
        public void Customer_Number_Greater_Than_Zero_Invalid()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", -1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(0, myReceipt.CustomerNumber);
        }

        [TestMethod]
        public void Item_Number_Between_0_And_9999_Invalid()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 10000, "MM JP12", 5000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(0, myReceipt.ItemNumber);
        }

        [TestMethod]
        public void Unit_Price_Between_0_And_9999_Invalid()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 11000M, 2);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(0, myReceipt.UnitPrice);
        }

        [TestMethod]
        public void Quantity_Purchased_Greater_Than_Zero_Invalid()
        {
            Receipt myReceipt = new Receipt(123, "02/03/2019", 1, "Victor", "Moraes", "Damaged St, 5", "55 15 123 456 789", 505, "MM JP12", 5000M, 0);
            Console.WriteLine(myReceipt);
            Assert.AreEqual(0, myReceipt.QuantityPurchased);
        }
    }
}
