using System;

class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    public ReflectionActivity(string name, string description)
        : base(name, description)
    {
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
    }
    public void RunActivity(int length)
    {
        bool done = false;
        Console.Clear();
        Console.WriteLine("Get ready...");
        AnimateBar(15);
        SetUpActivity();
        SetEndTime(length);
        while(!done)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            AnimateBar(50);
            done = FinishedActivity();
        }
        ClearQuestions();
        FinishingMessage(length);
    }
    public void SetUpActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
        Console.WriteLine("You may begin in: ");
        Countdown(5);
        PopulateQuestions();
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        Random r = new Random();
        return _reflectionPrompts[r.Next(0, _reflectionPrompts.Count - 1)];
    }
    public string GetRandomQuestion()
    {
        Random r = new Random();
        int next = r.Next(0, _reflectionQuestions.Count - 1);
        string question = _reflectionQuestions[next];
        if(_reflectionQuestions.Count > 1)
        {
            _reflectionQuestions.RemoveAt(next);
        }
        return question;
    }
    public void PopulateQuestions()
    {
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }
    public void ClearQuestions()
    {
        _reflectionQuestions.Clear();
    }
}