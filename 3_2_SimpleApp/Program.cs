using System;

namespace _3_2_SimpleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string person = "Chance";
            Console.Write("Welcome to ");
            Console.WriteLine("C#\n Programming!");
            Console.WriteLine($"Welcome to C# Programming, {person}!");

            // 3.6 let's add some ints
            int number1;
            int number2;
            int sum;

            Console.Write($"{person}, enter first integer: "); // prompt user
            // read first number from user
            number1 = int.Parse(Console.ReadLine());

            Console.Write($"{person}, enter second integer: ");
            // read second number from user
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2; // add numbers

            Console.WriteLine($"{person}, the sumb is {sum}");
        }
    }
}