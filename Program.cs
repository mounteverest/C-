using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    class Program
    {
        /// <summary>
        /// In a type conversion when there is no loss of data then it is implicit conversion.
        /// but when there is a loss of data,then it is explicit conversion
        /// using Toconvert method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i;
            double f = 294810.38;
            i = Convert.ToInt32(f);
            Console.WriteLine(i);
            //Console.Read();
            int a;
            double x = 654614.0;
            a = Convert.ToInt32(x);
            Console.WriteLine(a);
            String num = "100";
            //Parse is used to covert string to int
            int number = int.Parse(num);
            Console.WriteLine(number);
            Console.Read();

                


        }
    }
}
