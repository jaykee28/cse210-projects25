using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class MindfulnessActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private static string logFilePath = "MindfulnessLog.txt";

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        DisplaySpinner();
    }

    protected void DisplaySpinner()
    {
        Console.Write("Loading");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    protected void LogActivity()
    {
        using (StreamWriter writer = File.AppendText(logFilePath))
        {
            writer.WriteLine($"{DateTime.Now}: Completed {_name} activity for {_duration} seconds.");
        }
    }

    public void EndActivity()
    {
        Console.WriteLine($"Well done! You completed the {_name} activity for {_duration} seconds.");
        DisplaySpinner();
        LogActivity();
    }
}
