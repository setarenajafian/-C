using System;

class Program
{
    
    static bool IsFibonacci(int n)
    {
        int a = 1, b = 1, temp;
        if (n == 1) return true; 

        while (b < n)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return (b == n);
    }

    static void Main()
    {
        Console.WriteLine("Hi, give us a number so we can tell you it's in the fibonacci series or not");
        Console.WriteLine();
        Console.Write("enter a number: ");
        string numstring = Console.ReadLine();
        int num;
        num = Convert.ToInt32(numstring);

        if (IsFibonacci(num))
        {
            Console.WriteLine($"{num} is in the Fibonacci series.");
        }
        else
        {
            Console.WriteLine($"{num} is NOT in the Fibonacci series.");
        }
    }
}

