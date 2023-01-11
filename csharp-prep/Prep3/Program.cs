using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the Magic Number?");
        Random rnd = new Random();
        int magicNum = rnd.Next(0, 100);
        int isFinished = 0;
        while (isFinished == 0) {
            Console.Write("What is your guess?" );
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess > magicNum) {
                Console.WriteLine("Lower ");
            }
            if (guess < magicNum) {
                Console.WriteLine("Higher ");
            }
            if (guess == magicNum) {
                Console.WriteLine("You guessed it! ");
                isFinished = 1;
            }

        }
    }
}