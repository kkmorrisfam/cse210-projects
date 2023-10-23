using System;

class Program
{
    static void Main(string[] args)
    {
        //Add first Video Information and add comment information
        Video video1 = new Video();
        video1._title = "2023 Honda Ridgeline Black Edition - The ULTIMATE Gentleman's Truck";
        video1._author = "Vehicle Visionary";
        video1._length = 1254;
        //Add comment 1
        Comment comment1 = new Comment();
        comment1._name = "@williamabenejr8516";
        comment1._comment = @"One aspect of this truck that is overlooked is how great of a work truck it is. 
        I'm a residential remodeler and am on my 2nd Ridgeline. I plan on getting another.";
        video1._comments.Add(comment1);   //add comment to list
        //Add comment 2
        Comment comment2 = new Comment();
        comment2._name = "@Nicci75";
        comment2._comment = @"I'm very satisfied with my 2021 Black Edition, which is my daily driver and used 
        around a horse farm. On-road performance is better than with 'real trucks', and I get higher mileage than 
        reported.";        
        video1._comments.Add(comment2);   //add comment to list
        //Add comment 3
        Comment comment3 = new Comment();
        comment3._name = "@thornyflower11";
        comment3._comment = @"I've  owned this truck for 3 weeks and I love it. This is the first new vehicle 
        I've purchased in 15 years so the technology is more advanced than my 2007 Civic, although some ppl may 
        think its not techy enough.";
        video1._comments.Add(comment3);   //add comment to list

        //Add Video 2
        Video video2 = new Video();
        video2._title = "Should you Buy a Used Honda Ridgeline? [2nd Generation] Used Honda Ridgeline Review";
        video2._author = "Justin Pritchard";
        video2._length = 494;

        //Add comment 1
        Comment comment4 = new Comment();
        comment4._name = "@bonaanayaga";
        comment4._comment = @"I live in Nigeria and am thinking of getting a used one 2017 model but am scared 
        of the transmission issues. We have extreme rains and mud during the rainy season It will never tow, or carry 
        heavy load just driving from my home to my poultry.";
        video2._comments.Add(comment4);

        //Add comment 2
        Comment comment5 = new Comment();
        comment5._name = "@alichaudhry12";
        comment5._comment = "excellent vid, would love to see more of these";
        video2._comments.Add(comment5);

        //Add comment 3
        Comment comment6 = new Comment();
        comment6._name = "@SteveSmith-uh1ui";
        comment6._comment = @"My 2017 Ridgeline transmission needed replaced at 52,500 miles, symptoms were noticed 
        at 48,908 miles. I lost $10000.00 on trade in value.";
        video2._comments.Add(comment6);

        //Add Video 3
        Video video3 = new Video();
        video3._title = "The 2021 Honda Ridgeline Is the Truck For Non-Truck People";
        video3._author = "Doug DeMuro";
        video3._length = 1297;

        //Add comment 1
        Comment comment7 = new Comment();
        comment7._name = "@MajorOutage";
        comment7._comment = @"It's a real shame they didn't give you a higher trim version to check out. The in-bed
        audio system is a truly interesting quirk/feature. ";
        video3._comments.Add(comment7);

        //Add comment 2
        Comment comment8 = new Comment();
        comment8._name = "@tayzonday";
        comment8._comment = @"I'm always surprised there is not more demand for pickups to hold 4' x 8' plywood/drywall. 
        Wouldn't a minivan like a Chrysler Pacifica or Kia Carnival offer more utility for a lot of 
        home construction contractors? ";
        video3._comments.Add(comment8);

        //Add comment 3
        Comment comment9 = new Comment();
        comment9._name = "@jbird1173";
        comment9._comment = @"I had a 1st gen ridgeline and it really suprised me offroad. The all wheel drive system 
        works incredibly well.  I climbed a few enbankments that my trd tundra 4x4 didnt make it up.  Also drove in bumper deep 
        snow and drove circles around solid axle 4x4 trucks.";
        video3._comments.Add(comment9);

        //put each video into a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //clear screen
        Console.Clear();

        //Display title, author, length, number of comments and list each comment for that video
        foreach(Video vid in videos)
        {
            Console.WriteLine($"{vid._title}");
            Console.WriteLine($"author: {vid._author}  --  {vid._length} seconds  --  {vid.GetNumComments()} comments");
            Console.WriteLine();

            foreach (Comment comm in vid._comments)
            {
                Console.WriteLine($"     {comm._name}");
                Console.WriteLine($"        {comm._comment}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }



    }// end main

}//end program