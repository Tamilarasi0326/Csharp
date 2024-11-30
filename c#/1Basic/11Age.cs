//11.Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
//Test Data:
//Enter your age - 25
//Expected Output:
//You look older than 25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program11 
    { 
        public static void Main(string[] args) 
        {
            Console.Write("Enter Your age : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", a);
        }
    }
}
