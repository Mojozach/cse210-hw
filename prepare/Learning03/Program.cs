using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        string str;
        double dec;

        str = fraction.GetFractionString();
        Console.WriteLine($"{str}");
        dec = fraction.GetDecimalValue();
        Console.WriteLine($"{dec}");

        str = fraction2.GetFractionString();
        Console.WriteLine($"{str}");
        dec = fraction2.GetDecimalValue();
        Console.WriteLine($"{dec}");

        str = fraction3.GetFractionString();
        Console.WriteLine($"{str}");
        dec = fraction3.GetDecimalValue();
        Console.WriteLine($"{dec}");

        fraction.SetTop(1);
        fraction.SetBottom(3);
        str = fraction.GetFractionString();
        Console.WriteLine($"{str}");
        dec = fraction.GetDecimalValue();
        Console.WriteLine($"{dec}");

    }
}