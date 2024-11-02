using System.ComponentModel.Design;

    Console.WriteLine("we are here to help you recognize prime numbers between n and m");
    Console.WriteLine("enter n");
    string nstring = Console.ReadLine();
    int n = int.Parse(nstring);

    Console.WriteLine("enter m");
    string mstring = Console.ReadLine();
    int m = int.Parse(mstring);
    
    if (n > m) 
    {
        Console.WriteLine("dude n must be smaller than m, try again!");
    }
    else

    {
        Console.WriteLine("these are prime numbers between n amd m :");
    }    

    bool isprime = true;

    for (int k = n; k < m; k++)
    {
        for (int i = k - 1; i > 1; i--)
        {
            if (k % i == 0)
                isprime = false;
        }
        if (isprime) Console.WriteLine(k);
        //else console.writeline ( j + " is not prime");
        isprime = true;
    }



