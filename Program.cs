using System;
class SUM
{
    static void Main()
    {
        int n;
        Console.WriteLine("enter limit for sum:");
        n=int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i <=n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum={0}",sum);
    }
}