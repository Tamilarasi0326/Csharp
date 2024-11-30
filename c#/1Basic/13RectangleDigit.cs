//13.Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
//Test Data:
//Enter a number: 5
//Expected Output:
//555
//5 5
//5 5
//5 5
//555

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program13 
    { 
        public static void Main(string[] args) 
        {
            Console.Write("Enter a digit : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0}{0}{0}", a);
        }
    }
}
