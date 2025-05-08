using System;

class Program
{
    static void Main()
    {
        // Prompt user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = ""; // Variable to store letter grade
        string sign = "";   // Variable to store grade sign (+ or -)

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine "+" or "-" sign
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")  // No A+ or F+ / F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3) // Handle A-
        {
            sign = "-";
        }

        // Display the final grade
        Console.WriteLine($"Your final grade is {letter}{sign}.");

        // Congratulate or encourage the user based on passing status
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll get it next time.");
        }
    }
}
