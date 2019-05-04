using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHelper
    {
        internal static void DivisionTest()
        {
            try
            {
                int totalScores = 10;
                int countOfScores = 0;

                double average = totalScores / countOfScores;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Division operation");
            }
        }

        internal static void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    string state = st.ToUpper();
                    break;
                default:
                    CustomException ex = new CustomException("State " + st.ToUpper() + " not part of Atlantic ICW");
                    throw ex;
            }
        }
    }
}
