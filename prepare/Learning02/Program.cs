using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _company = "Google",
            _jobTitle = "Software Engineer",
            _startYear = 2022,
            _endYear = 2024
        };

        Job job3 = new Job
        {
            _company = "Amazon",
            _jobTitle = "Software Engineer",
            _startYear = 2015,
            _endYear = 2019
        };

        Resume resume = new Resume();
        resume._name = "Luis Vega";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);
        resume.Display();
    }
}