using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)   
    {  
        _entries.Add(newEntry);
        
    }
    public void DisplayAll()
    {
        Console.WriteLine("DisplayAll() method called");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string aFilename)
    {
        Console.WriteLine($"SaveToFile() method called with {aFilename}");
        // using (StreamWriter outputFile = new StreamWriter(aFilename))
        //         {
        //             // You can use the $ and include variables just like with Console.WriteLine
        //             // string color = "Blue";
        //             // outputFile.WriteLine($"My favorite color is {color}");
                    
        //         }
    }

    public void LoadFromFile(string aFilename)
    {
        Console.WriteLine($"LoadFromFile() method called with {aFilename}");
        //string filename = "myFile.txt";
        // string[] lines = System.IO.File.ReadAllLines(aFilename);

        //  Console.WriteLine(reader.ReadToEnd());
        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");

        //     // string date = parts[0];
        //     // string prompt = parts[1];
        //     // string entry = parts[2];
           
        // }
        
    }

    //construct
    public Journal()
    {

    }
}