//7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program7
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a+b));
            Console.WriteLine(a + " - " + b + " = " + (a-b));
            Console.WriteLine(a + " * " + b + " = " + a*b);
            Console.WriteLine(a + " / " + b + " = " + a/b);
            Console.WriteLine(a + " mod " + b + " = " + a%b);
        }
    }
}
