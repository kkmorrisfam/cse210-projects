using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Lecture l1 = new Lecture("Youth Fireside", "Be of Good Cheer", "November 2nd, 2023", "6:00 PM", "Hank Smith", 500);
        l1.GetAddress("1450 California Drive", "Somewhere", "CA", "USA");
        Reception r1 = new Reception("Marsh Wedding", "Come celebrate with us the marriage of Christopher and Juliet", "December 28th, 2023", "5:00 PM", "someemail@gmail.com");
        r1.GetAddress("450 H Street", "Victoria", "BC", "Canada");
        Outdoor o1 = new Outdoor("Ward Picnic", "Yuba City Ward Pioneer Day Picnic", "July 24th, 2024", "3:30 PM", "Sunny and Hot");
        o1.GetAddress("14055 State Highway 49", "Navoo", "Illinois", "USA");
    }
}