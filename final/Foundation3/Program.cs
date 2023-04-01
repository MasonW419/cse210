using System;

class Program
{
    static void Main(string[] args)
    {
        Address a = new Address("2347 Pinta Rd", "Santa Barbara", "Florida", "USA", "2894");
        Address b = new Address("4958 Bear St", "Jerkey", "Montana", "USA", "3948");
        Address c = new Address("9898 Rockwood Dr", "Amberton", "Utah", "USA", "23948");
        Lecture lecture = new Lecture("Lecture", "BoM Geography", "Learn about how Native American tribes relate to the Book of Mormon", "April 12, 2023", "7:00 pm", a, "Daniel Schmitz", 120);
        Reception reception = new Reception("Reception", "Bill's Reception", "Come join us to celebrate!", "May 15, 2023", "1:00px", b, "@bpratt.yahoo.com");
        Gathering gathering = new Gathering("Gathering", "New Testament Reenactment", "Watch the story of Christ unfold in our outdoors reenactment!", "April 7, 2023", "11:00 am", c, "Sunny", 75);
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine(gathering.GetShortDetails());
    }
}
