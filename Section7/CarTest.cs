using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            // arrange
            Car myCar = new Car("Red", 2, true);

            // act

            // assert
            Assert.AreEqual("Red", myCar.Color);
        }
    }
}
