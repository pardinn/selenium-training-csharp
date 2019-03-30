using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuizP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int outsideRangeCount = 0;
            int nonNumericCount = 0;

            nonNumericCount = GetValues(entries, ref outsideRangeCount);
            DisplayResults(entries, nonNumericCount, outsideRangeCount);
            //Console.ReadKey();
        }

        private static void DisplayResults(int[] entries, int nonNumericCount, int outsideRangeCount)
        {
            int validEntriesCount = 0;

            Console.Clear();
            Console.WriteLine("\tInput Data App\n");
            Console.WriteLine("{0,-12} {1,-6}", "Input Value", "Count");

            for (int x = 0; x <= 10; x++)
            {
                if (entries[x] != 0)
                {
                    validEntriesCount += entries[x];
                    Console.WriteLine("{0,5} {1,10}", x, entries[x]);
                }
            }
            Console.WriteLine("\nNumber of Valid Entries: {0}", validEntriesCount);
            Console.WriteLine("\nNumber of Values Entered Outside Acceptable Range: {0}", outsideRangeCount);
            Console.WriteLine("Number of Non-numeric Values Entered: {0}", nonNumericCount);
            Console.WriteLine("Total Number of Inputs: {0}", validEntriesCount + outsideRangeCount + nonNumericCount);
        }

        private static int GetValues(int[] entries, ref int outsideRangeCount)
        {
            int inValue;
            string stringInput;
            bool moreInput = true;
            int nonNumericCount = 0;

            Console.Clear();
            while (moreInput)
            {
                Console.Write("\nInput any number between 0 an 10 (-1 to stop): ");
                stringInput = Console.ReadLine();

                // Tests to make sure the value entered is an integer
                while (int.TryParse(stringInput, out inValue) == false)
                {
                    Console.Write("\nInvalid data type - value must be numeric between 0 and 10 (-1 to stop): ");
                    stringInput = Console.ReadLine();
                    nonNumericCount++;
                }

                if (inValue == -1)
                {
                    moreInput = false;
                }
                else
                {
                    if (inValue < 0 || inValue > 10)
                    {
                        Console.Write("\nInvalid number");
                        outsideRangeCount++;
                    }
                    else
                    {
                        entries[inValue]++; //use array as accumulator
                    }
                }
            }
            return nonNumericCount;
        }
    }
}
