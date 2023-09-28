using System;

public class Reference
{
    //Keeps track of the book, chapter, and verse information.
    //holds values for book, chapter and starting and ending verse
        //gets separate values to store for book, chapter and starting and ending verses
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    //returns reference as a string
    public string GetDisplayText()
    {
        string myString = "";
        if (_endVerse > 0)
        {
            myString = $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
        }
        else
        {
            myString = $"{_book} {_chapter}:{_verse}"; 
        }
        
        return myString; 
    }

    //constructor to set attributes
    //if I create an empty instance, then I will have to create a get and set method.
    // public Reference(string reference)
    // {
    //     //if I pass in a reference just a string, I need to split it into parts
    //     //what do I do about books that start with a number and include a space?
        
    // }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;   
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;  
        Console.WriteLine($"I am in the Reference Constructor. {_book} {_chapter}:{_verse}");  
    }

}