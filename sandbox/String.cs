using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string myString = "This is a test string.";
        int sLength = myString.Length;
        string var1 = myString.Substring(myString.Length - 1);  //substring becomes last letter in string
        string var2 = myString.Substring(11, 7);  // substring starts at 11 (really 12) and length of 7; index of string starts at 0 prints "est str"

        string[] strSplit = myString.Split(' '); //can also use a count.

        string myNewString1 = myString.Replace("e", "_");  //Replace character; will replace all of the "e"s with an "_" character. 
        string myNewString2 = myString.Replace("is", "__");  //Replace string; will replace first string with second string

        Console.WriteLine($"string length {sLength}");  
        Console.WriteLine($"Substring: {var1}");
        Console.WriteLine($"Substring: {var2}");
        Console.WriteLine($"Split Array {strSplit}");

        for (int i = 0; i < strSplit.Length; i++)
        {
            Console.WriteLine($"Value at index {i} is {strSplit[i]}");
        }

        Console.WriteLine($"Replace1 : {myNewString1}");
        Console.WriteLine($"Replace2 : {myNewString2}");
    }
        //output
        //Hello Develop03 World!
        // string length 22
        // Substring: .
        // Substring: est str
        // Split Array System.String[]
        // Value at index 0 is This
        // Value at index 1 is is
        // Value at index 2 is a
        // Value at index 3 is test
        // Value at index 4 is string.
        // Replace1 : This is a t_st string.
        // Replace2 : Th__ __ a test string.
}

