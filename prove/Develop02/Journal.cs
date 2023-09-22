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
        //Console.WriteLine("DisplayAll() method called");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string aFilename)
    {
        using(StreamWriter outputFile = new StreamWriter(aFilename))
        {
            Console.WriteLine($"SaveToFile() method called with {aFilename}");
            foreach (Entry entry in _entries)
            {
                //save each entry as a new line in the file.
                outputFile.WriteLine($"{entry._date}**{entry._promptText}**{entry._entryText}");
            }

        }
    }

    public void LoadFromFile(string aFilename)
    {
        Console.WriteLine("Reading List from file...");

        //read whole file at once and put into string array
        string[] lines = System.IO.File.ReadAllLines(aFilename);

        //read each line in array              
        foreach (string line in lines)
        {
            // line will be split by ** like: date,prompt,entry           
            string[] partsArray = line.Split("**");

            // to visualize:
            // partsArray[0] = 09/22/2023
            // partsArray[1] = a prompt that is saved
            // partsArray[2] = an entry that is saved

            Entry newEntry = new Entry();
            newEntry._date = partsArray[0];
            newEntry._promptText = partsArray[1];
            newEntry._entryText = partsArray[2];          

            _entries.Add(newEntry);
        }
        //return entryList;
    }

    //construct
    public Journal()
    {

    }
}