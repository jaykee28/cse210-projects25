using System;

class Program
{
    static void Main()
    {
        // Create job instances
        Job job1 = new Job { _jobTitle = "Software Engineer", _company = "Microsoft", _startYear = 2019, _endYear = 2022 };
        Job job2 = new Job { _jobTitle = "Manager", _company = "Apple", _startYear = 2022, _endYear = 2023 };

        // Create Resume instance
        Resume myResume = new Resume { _name = "Jacqueline" };

        // Add jobs to the Resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the complete resume
        myResume.Display();
    }
}
