using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public Job(string company, string title, int start, int end)
    {
        _company = company;
        _jobTitle = title;
        _startYear = start;
        _endYear = end;
    }
    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}