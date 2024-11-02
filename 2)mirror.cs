Console.WriteLine("we are here to help you recognize mirror numbers between n and m");
Console.WriteLine("guidance : n is smaller than m !!");
Console.WriteLine("enter n");
string nstring = Console.ReadLine();
int n = int.Parse(nstring);

Console.WriteLine("enter m");
string mstring = Console.ReadLine();
int m = int.Parse(mstring);

if ( n > m )
{
    int temp = n;
    n = m;
    m = temp;
}
Console.WriteLine("these are mirror numbers between n and m :");

for (int i = n; i <= m; i++)
{
    if (IsMirrorNumber(i))

    {
        Console.WriteLine(i);
    }

}
 static bool IsMirrorNumber(int num)
{
    int reversed = 0;
    int original = num;

    while (num > 0)
    {
        reversed = reversed * 10 + (num % 10);
        num /= 10;

    }

    return original == reversed;
}



