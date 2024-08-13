using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Made by ElytraBlox");
            
            Console.WriteLine("Choose an operation!");

            Console.WriteLine("1 - Addition, 2 - Subtraction, 3 - Multiplication, 4 - Division, 5 - Exponentiation");

            int operation = int.Parse(Console.ReadLine());

            if (operation > 5)
            {
               Console.WriteLine("No operations exist with this number, please reopen the program.");
            }
       
            if (operation == 1)
            {
                Console.WriteLine("Enter your first number");

                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 + n2;

                Console.WriteLine("Adding the numbers " + n1 + " and " + n2 + " is equal to " + result);
            }

            if (operation == 2)
            {
                Console.WriteLine("Enter your first number");

                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 - n2;

                Console.WriteLine("Subtracting the numbers " + n1 + " and " + n2 + " is equal to " + result);
            }

            if (operation == 3)
            {
                Console.WriteLine("Enter your first number");

                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 * n2;

                Console.WriteLine("Multiplying the numbers " + n1 + " and " + n2 + " is equal to " + result);
            }

            if (operation == 4)
            {
                Console.WriteLine("Enter your first number");

                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine("Dividing the numbers " + n1 + " and " + n2 + " is equal to " + result);
            }

            if (operation == 5)
            {
                Console.WriteLine("Enter your base");

                double n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your exponent/power");

                double n2 = int.Parse(Console.ReadLine());

                double result = Math.Pow(n1, n2);

                Console.WriteLine("The number " + n1 + " to the power of " + n2 + " is equal to " + result);
            }

            Console.ReadKey();
        }
    }
}