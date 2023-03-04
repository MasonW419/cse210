using System;

class Program
{
    static void Main(string[] args)
    {
        
        BreathingActivity ba = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity ra = new ReflectionActivity("ReflectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity la = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        bool program = true;
        int length = 0;
        while (program)
        {
            DisplayMainMenu();
            int userInput = Convert.ToInt16(Console.ReadLine());
            if(userInput == 1)
            {   
                ba.WelcomeMessage();
                length = ActivityLength();
                ba.RunActivity(length);
            }
            if(userInput == 2)
            {
                ra.WelcomeMessage();
                length = ActivityLength();
                ra.RunActivity(length);
            }
            if(userInput == 3)
            {
                la.WelcomeMessage();
                length = ActivityLength();
                la.RunActivity(length);
            }
            if(userInput == 4)
            {
                program = false;
            }
        }
        static void DisplayMainMenu()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
        }
        static int ActivityLength()
        {
            Console.WriteLine("How long, in seconds, would you like your session? ");
            int input = Convert.ToInt16(Console.ReadLine());
            return input;
        }
    }
}