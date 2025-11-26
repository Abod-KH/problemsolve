using System;

public class Program
{
    public static int Wightcalc(int a, int b)
    {
        int years = 0;
        int limak = a;
        int bob = b;
        while (limak <= bob)
        {
            limak *= 3;
            bob *= 2;
            years++;
        }
        return years;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("enter Wight of limak");
        int a = int.Parse(Console.ReadLine()); 
        Console.WriteLine("enter Wight of Bob");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("need of years is " + Wightcalc(a, b));
    }
}