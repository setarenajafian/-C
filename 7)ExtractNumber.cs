using System;
using System.Linq;

namespace UserInformation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("welcome");
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}!");


            Console.WriteLine("Please enter your phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("please enter your national code");
            string nationalCode = Console.ReadLine();

            Console.WriteLine("call 012345 to buy an American SIM card");
            Console.WriteLine();

            Console.WriteLine("Please enter your new number:");
            string newNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();

            ValidateAndDisplayNumber("Phone Number", phoneNumber);
            ValidateAndDisplayNumber("National Code", nationalCode);
            ValidateAndDisplayNumber("New Number", newNumber);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void ValidateAndDisplayNumber(string label, string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine($"we will extract your {label} : {number} . ");
            }
            else
            {
                Console.WriteLine($"we can't extract your {label} ");
            }

        }

        static bool IsValidNumber(string number)
        {
            // Check if the number starts with zero
            if (number[0] != '0')
                return false;

            // Check if the number has exactly 10 digits
            if (number.Length != 10)
                return false;

            // Check if the number has at least two different digits
            if (number.Distinct().Count() < 2)
                return false;

            return true;
        }
    }
}

