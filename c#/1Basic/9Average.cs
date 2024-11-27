//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int avg = (a + b + c + d)/ 4;
            Console.WriteLine("The average is  {0},{1},{2},{3} is {4}" ,a,b,c,d,avg);
        }
    }
}
