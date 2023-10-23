using System;

class Program
{
    static void Main(string[] args)
    {
        //Set up values for events
        Lecture l1 = new Lecture("Youth Fireside", "Be of Good Cheer", "November 2nd, 2023", "6:00 PM", "Hank Smith", 500);
        l1.SetAddress("1450 California Drive", "Somewhere", "CA", "USA");
        Reception r1 = new Reception("Marsh Wedding", "Marriage of Christopher and Juliet", "December 28th, 2023", "5:00 PM", "someemail@gmail.com");
        r1.SetAddress("450 H Street", "Victoria", "BC", "Canada");
        Outdoor o1 = new Outdoor("Ward Picnic", "Yuba City Ward Pioneer Day Picnic", "July 24th, 2024", "3:30 PM", "Sunny and Hot");
        o1.SetAddress("14055 State Highway 49", "Navoo", "Illinois", "USA");

        //create a list and add each event to list
        List<Event> events = new List<Event>();
        events.Add(l1);
        events.Add(r1);
        events.Add(o1);

        //loop through list to print short description available in parent class
        Console.Clear();
        Console.WriteLine("Printing Short Description --");
        Console.WriteLine();
        foreach(Event eve in events)
        {
            //can't call methods that are not in parent class here
            Console.WriteLine(eve.DisplayShortDescription());
            Console.WriteLine();            
        }  

        Console.WriteLine();
        Console.WriteLine("Printing Standard Details message --");
        Console.WriteLine();

        //loop through list to print standard details available in parent class
        foreach(Event eve in events)
        {
            Console.WriteLine(eve.DisplayDetails());
            Console.WriteLine();
        }

        //Print full details with additional details that are not avalable in parent class
        //could have overridden child classes, but that's the next principle in Foundation 4
        Console.WriteLine("Printing Full Marketing Message---");
        Console.WriteLine(l1.DisplayDetails());
        Console.WriteLine(l1.DisplayAdditionalDetails());
        Console.WriteLine();
        Console.WriteLine(r1.DisplayDetails());
        Console.WriteLine(r1.DisplayAdditionalDetails());
        Console.WriteLine();
        Console.WriteLine(o1.DisplayDetails());
        Console.WriteLine(o1.DisplayAdditionalDetails());
    }
}