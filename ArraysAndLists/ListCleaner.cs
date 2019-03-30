using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraysAndLists
{
    [TestClass]
    public class ListCleaner
    {
        [TestMethod]
        public void List_Cleaner_Test()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            int totalData = Sum(CleanList(dataList));
            Assert.AreEqual(147, totalData);
        }

        private ArrayList CleanList(ArrayList list)
        {
            ArrayList cleanData = new ArrayList();
            foreach(var item in list)
            {
                if(int.TryParse(item.ToString(),out int result))
                {
                    cleanData.Add(result);
                }
            }
            return cleanData;
        }

        private int Sum(ArrayList dataList)
        {
            int sum = 0;
            foreach (int data in dataList)
            {
                sum += data;
            }
            return sum;
        }
    }
}
