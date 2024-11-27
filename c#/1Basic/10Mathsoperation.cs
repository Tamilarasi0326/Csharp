//10.Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
//Test Data:
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int result1 = (a + b) * c;
            int result2 = (a*b) + (b*c) ;
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, ({0} + {1}).{2} is {3} and {0}.{1} + {1}.{2} is {4}" ,a,b,c,result1,result2 );
        }
    } 
}
