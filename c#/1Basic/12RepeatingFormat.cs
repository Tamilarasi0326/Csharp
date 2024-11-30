//12.Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
//Test Data:
//Enter a digit: 25
//Expected Output:
//25 25 25 25
//25252525
//25 25 25 25
//25252525

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program12 
    { 
        public static void Main(string[] args) 
        {
            Console.Write("Enter a digit : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
        }
    }
}
