class program
{
    static void Main()
    {
        int pin;
        bool valid = false;

        Console.WriteLine("enter your pin");

        while (!valid)
        {
            pin = 0;
            int digitcount = 0;

            while (digitcount < 4)
            {


                // Read a key without showing it
                var key = Console.ReadKey(true); // true to not show the key

                if (char.IsDigit(key.KeyChar))
                {
                    pin = pin * 10 + (key.KeyChar - '0'); //build the pin
                    Console.Write("*"); 
                    digitcount++;

                }

                else
                {
                    Console.WriteLine("\nInvalid input . please enter numbers only.");
                    Console.WriteLine("enter your four digit pin");
                    digitcount = 0; // Reset digit count 
                    pin = 0; // Reset pin
                    break; // Reset input
                }
            }

            if (digitcount == 4)
            {
                if (pin >= 1000 && pin <= 9999)
                {

                    valid = true;
                    Console.WriteLine("\nPin accepted: " + pin);

                }
                else
                {
                    Console.WriteLine("\nPin must be between 1000 and 9999. try again");

                }
            }
        }
    }
}