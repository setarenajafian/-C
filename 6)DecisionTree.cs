using System;

namespace CarExhibitionDecisionTree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi, let's find your ideal car ;) ");
            string carType = MakeDecision();
            Console.WriteLine($"I recommend you: {carType}");
        }

        static string MakeDecision()
        {
            // First decision: Production
            Console.WriteLine("Do you Prefer Foreign Cars or Iranian Cars? (Type 'foreign' or 'iranian')");
            string ProductionPreference = Console.ReadLine();

            if (ProductionPreference == "foreign")
            {
                return ForeignCarDecision();
            }
            else if (ProductionPreference == "iranian")
            {
                return IranianCarDecision();
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'foreign' or 'iranian'.");
                return MakeDecision(); // restart the decision process
            }
        }

        static string ForeignCarDecision()
        {
            // Second decision: Type of Gear
            Console.WriteLine("Do you prefer Automatic gear or Manual gear? (Type 'automatic' or 'manual')");
            string carType = Console.ReadLine();

            if (carType == "automatic")
            {
                return AutomaticDecision();
            }
            else if (carType == "manual")
            {
                return "a KMCT8 ";
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'automatic' or 'manual'.");
                return ForeignCarDecision(); // restart the decision process
            }
        }

        static string AutomaticDecision()
        {
            // Third decision: Type of Driving experience
            Console.WriteLine("What type of driving experience do you prefer? Off-road, Luxury, or Sporty performance? (Type 'off-road', 'luxuary', or 'Performance')");
            string carType = Console.ReadLine();

            if (carType == "off-road")
            {
                return "a Mercedes - Benz G_Klasse";
            }
            else if (carType == "luxuary")
            {
                return "a BMW 730 ";
            }
            else if (carType == "performance")
            {
                return "a Porsche GT3RS";
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'off-road', 'luxuary', or 'performance'.");
                return AutomaticDecision(); // restart the decision process
            }
        }

        static string IranianCarDecision()
        {
            // Second decision: type of car
            Console.WriteLine("Do you want a used car or a new car ? (Type 'used' or 'new')");
            string carType = Console.ReadLine();

            if (carType == "used")
            {
                return "a Peugeot 207";
            }
            else if (carType == "new")
            {
                return "a Tara Automat";
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'used' or 'new'.");
                return IranianCarDecision(); // restart the decision process
            }
        }
    }
}

