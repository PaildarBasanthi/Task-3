using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("The Addition of two numbers :" + c);
            int d = a - b;
            Console.WriteLine("The Subtraction of two numbers :" + d);
            int e = a * b;
            Console.WriteLine("The Multiplication of two numbers :" + e);
            //int f = a / b;
            if (b != 0)
            {
                
                Console.WriteLine($"The Division of two numbers : {a/(double)b}");
                Console.WriteLine($"The Modulus of two numbers : {a%b}");
            }
            else
            {
                Console.WriteLine("Cannot perform dividion by zero ");
            }
        }
    }
}
