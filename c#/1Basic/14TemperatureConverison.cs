//14.Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
//Test Data:
//Enter the amount of celsius: 30
//Expected Output:
//Kelvin = 303
//Fahrenheit = 86

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class program14 
    { 
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the amount of celsius: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", c + 273);
            Console.WriteLine("Fahrenheit = {0}", c * 18 / 10 + 32);
        } 
    }
}
