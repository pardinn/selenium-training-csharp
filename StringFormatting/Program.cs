using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSandwiches = 5;
            int people = 3;
            int costOfSandwiches = 3;

            //Concatenating strings
            Console.WriteLine("The " + people + " people ate " + numberOfSandwiches + " of the sandwiches");
            //Formatting strings
            Console.WriteLine("The {0} people ate {1} of the sandwiches", people, numberOfSandwiches);
            //Interpolating strings
            Console.WriteLine($"The {people} people ate {numberOfSandwiches} of the sandwiches");
            //Formatting strings with specific type
            Console.WriteLine("The {0} sandwiches cost {1:C} dollars", numberOfSandwiches, costOfSandwiches);

            //Format output as a table
            Console.WriteLine(String.Format("{0,10} {1,10} {2,10}", "Qty", "Unit Price", "Total Price"));
            Console.WriteLine(String.Format("{0,10} {1,10:C} {2,10:C}",
                numberOfSandwiches, costOfSandwiches, numberOfSandwiches * costOfSandwiches));

            decimal price = 15.30m;
            //Storing a formatted string on a variable
            string output = String.Format("The current price is {0:C} per ounce", price);
            Console.WriteLine(output);

            //Verbatim string
            string fileName = @"C:\MyFolder\ASubFolder\MyFile.txt";
            Console.WriteLine(fileName);
        }
    }
}
