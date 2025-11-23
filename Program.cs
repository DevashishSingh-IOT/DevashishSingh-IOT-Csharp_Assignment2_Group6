using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment2_Group6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Assignment 2: Custom Methods Demo ===");

            // 1. Calling Name Concatenation Method
            Console.WriteLine("\n-- Full Name Method Output --");

            Console.Write("Enter your first name: ");
            string first = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string last = Console.ReadLine();

            PrintFullName(first, last);

            // 2. Calling Celsius to Fahrenheit
            Console.WriteLine("\n-- Celsius to Fahrenheit Method Output --");
            double c = 25;
            double fResult = ConvertCtoF(c);
            Console.WriteLine(c + " C = " + fResult + " F");

            // 3. Calling Fahrenheit to Celsius
            Console.WriteLine("\n-- Fahrenheit to Celsius Method Output --");
            double f = 77;
            double cResult = ConvertFtoC(f);
            Console.WriteLine(f + " F = " + cResult + " C");

            // 4. Custom method
            Console.WriteLine("\n-- Square Method Output --");
            int number = 6;
            int square = SquareNumber(number);
            Console.WriteLine("Square of " + number + " is " + square);

            Console.WriteLine("\n=== END OF PROGRAM ===");
        }

        // METHOD 1: Concatenate first + last name
        static void PrintFullName(string first, string last)
        {
            string full = first + " " + last;
            Console.WriteLine("Full Name: " + full);
        }

        // METHOD 2: Celsius → Fahrenheit
        static double ConvertCtoF(double c)
        {
            return (c * 9.0 / 5.0) + 32;
        }

        // METHOD 3: Fahrenheit → Celsius
        static double ConvertFtoC(double f)
        {
            return (f - 32) * 5.0 / 9.0;
        }

        // METHOD 4: Custom method (square of a number)
        static int SquareNumber(int num)
        {
            return num * num;
        }
    }
}

