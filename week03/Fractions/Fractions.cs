using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor that initializes the fraction to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor that initializes the fraction with a given numerator and denominator of 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor that initializes the fraction with both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator != 0 ? denominator : 1; // Avoid division by zero
    }

    // Getters and Setters
    public int GetNumerator() => _numerator;
    public int GetDenominator() => _denominator;
    public void SetNumerator(int numerator) => _numerator = numerator;
    public void SetDenominator(int denominator) => _denominator = denominator != 0 ? denominator : 1;

    // Method to return fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
