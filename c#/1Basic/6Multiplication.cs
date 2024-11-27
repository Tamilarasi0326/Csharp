//6.Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program6 
    {
        public static void Main(string[] args) 
        {
            int a , b , c ;
            Console.Write("Input the First number to multiply: " );
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second number to multiply: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " x " + b + " x " + c + " = " + a*b*c);
        }
    }
}
