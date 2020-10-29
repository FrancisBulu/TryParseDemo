using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parse
            try
            {
                int intNumber = int.Parse("123");
                Console.WriteLine("Valid number");
            }
            catch (Exception)
            {

                Console.WriteLine("Not a valid number");
            }



            
            //long longNumber = long.Parse("123");
            //bool status = bool.Parse("false");
            //decimal decNumber = decimal.Parse("123.5");

            //Console.WriteLine(intNumber);
            //Console.WriteLine(longNumber);
            //Console.WriteLine(status);
            //Console.WriteLine(decNumber);
            #endregion

            #region TryParse
            //int parsedInt = 0;
            //string input = Console.ReadLine();
            //bool isNumber = int.TryParse(input, out parsedInt); // tryparse returneren altijd een boolean. voor boolean variabel, gebruiken "isVar"

            //if (isNumber)
            //{
            //    Console.WriteLine("The parsing was successfull");
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid number");
            //}
            #endregion
        }
    }
}
