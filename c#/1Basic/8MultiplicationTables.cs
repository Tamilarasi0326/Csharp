//8.Write a C# Sharp program that prints the multiplication table of a number as input.
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15....5 * 10 = 50

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program8 
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " * " + " 1 " + " = " + a * 1);
            Console.WriteLine(a + " * " + " 2 " + " = " + a * 2);
            Console.WriteLine(a + " * " + " 3 " + " = " + a * 3);
            Console.WriteLine(a + " * " + " 4 " + " = " + a * 4);
            Console.WriteLine(a + " * " + " 5 " + " = " + a * 5);
            Console.WriteLine(a + " * " + " 6 " + " = " + a * 6);
            Console.WriteLine(a + " * " + " 7 " + " = " + a * 7);
            Console.WriteLine(a + " * " + " 8 " + " = " + a * 8);
            Console.WriteLine(a + " * " + " 9 " + " = " + a * 9);
            Console.WriteLine(a + " * " + " 10 " + " = " + a * 10);
            

        }
    }
}
