using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ResaleValue
{
    [TestClass]
    public class ResaleValue
    {
        [TestMethod]
        public void Display_Retail_Price()
        {
            //call the constructor for the cass and give it the item price
            ItemPrice itemPrice = new ItemPrice(12.99M);

            //header rows for tabular format
            Console.WriteLine("{0,-20} {1,25}", "Item", "Percentage Increase");
            Console.Write("{0,-10}", "Price");

            //create the output in tabular format
            for (decimal percentage = 0.05M; percentage <= 0.10M; percentage += 0.01M)
            {
                Console.Write("{0,12}",percentage);
            }

            //linebreak
            Console.WriteLine();

            Console.Write("{0,-10:C}",itemPrice.WholeSalePrice);

            //Create the output in tabular format
            for (decimal percentage = 0.05M; percentage <= 0.10M; percentage += 0.01M)
            {
                Console.Write("{0,10:C}",(itemPrice.WholeSalePrice + (itemPrice.WholeSalePrice*percentage)));
            }
        }
    }
}
