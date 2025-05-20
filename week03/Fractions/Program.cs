using System;

class Program
{
    static void Main()
    {
        // Test Constructors
        Fraction frac1 = new Fraction();  // 1/1
        Fraction frac2 = new Fraction(5); // 5/1
        Fraction frac3 = new Fraction(3, 4); // 3/4
        Fraction frac4 = new Fraction(1, 3); // 1/3

        // Display fraction representations
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

        // Test getters and setters
        frac1.SetNumerator(6);
        frac1.SetDenominator(7);
        Console.WriteLine(frac1.GetFractionString()); // 6/7
        Console.WriteLine(frac1.GetDecimalValue());   // 0.8571...
    }
}
