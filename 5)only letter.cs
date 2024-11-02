using System.Linq.Expressions;

class program
{
    static void Main()
    {
        string name = "";
        Console.WriteLine("enter your name");

        while (true)
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey(intercept : true);

            if ( char.IsLetter(KeyInfo.KeyChar) )
            {
                name += KeyInfo.KeyChar;
                Console.Write(KeyInfo.KeyChar);

            }
            else if ( KeyInfo.Key == ConsoleKey.Backspace && name.Length > 0 )
            {
                name = name.Substring(0, name.Length - 1);
                Console.Write("\b \b");
            }
            else if (KeyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }

        }
        Console.WriteLine("\nHi" + " " + name);
    }
}