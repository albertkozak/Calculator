using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************MENU************");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulus");
            var userSelection = Console.ReadLine();
            if (userSelection == "1")
            {
                Console.WriteLine("You chose Add!");
                Console.WriteLine("Enter first digit");
                var firstDigit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                var secondDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(firstDigit + " + " + secondDigit + " = " + (firstDigit + secondDigit));
            }
            else if (userSelection == "2")
            {
                Console.WriteLine("You chose Subtract!");
                Console.WriteLine("Enter first digit");
                var firstDigit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                var secondDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(firstDigit + " - " + secondDigit + " = " + (firstDigit - secondDigit));
            }
            else if (userSelection == "3")
            {
                Console.WriteLine("You chose Multiply!");
                Console.WriteLine("Enter first digit");
                var firstDigit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                var secondDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(firstDigit + " * " + secondDigit + " = " + (firstDigit * secondDigit));
            }
            else if (userSelection == "4")
            {
                Console.WriteLine("You chose Divide!");
                Console.WriteLine("Enter first digit");
                var firstDigit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                var secondDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(firstDigit + " / " + secondDigit + " = " + (firstDigit / secondDigit));
            }
            else if (userSelection == "5")
            {
                Console.WriteLine("You chose Modulus!");
                Console.WriteLine("Enter first digit");
                var firstDigit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                var secondDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(firstDigit + " % " + secondDigit + " = " + (firstDigit % secondDigit));
            }
            Console.Read();
        }
    }
}



