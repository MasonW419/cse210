using System;

class Program
{
    static void Main(string[] args)
    {
        Job joby = new Job("Microsoft", "Software Engineer", 2019, 2021);
        Job jobo = new Job("Apple", "Manage", 2021, 2023);
        Resume resume = new Resume("Robert Scales");
        resume._jobList.Add(joby);
        resume._jobList.Add(jobo);
        resume.Display();
    }
}