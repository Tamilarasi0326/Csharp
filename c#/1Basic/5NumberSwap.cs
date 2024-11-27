//5.Write a C# Sharp program to swap two numbers.
//Test Data:
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output:
//After Swapping :
//First Number : 6
//Second Number : 5

using System;


namespace Basic
{
    public class program5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping ..........");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
        }
    }
}

