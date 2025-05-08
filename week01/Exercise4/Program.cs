using System;
using System.Collections.Generic;
using System.Linq; // Used for sorting and finding min/max

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) // Exclude zero
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Compute the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge: Find the smallest positive number
        int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge: Sort and display numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
