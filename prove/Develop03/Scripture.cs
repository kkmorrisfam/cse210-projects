using System;
using System.Collections.Generic;

public class Scripture
{
    //keeps track of the reference and the text of the scripture
    //could use a list of words to store the scripture string. we can change/add to a list
    //could use an array of words to store the scripture string. arrays are immutable/unchanging
    private List<Word> _wordsList;
    private Reference _reference;  //scripture class just holds value, doesn't create it.

    //displays scripture and reference = all words
    public string GetDisplayText()
    {
        string newString = "";
        foreach (Word item in _wordsList) //prints out "word object" + the word for each instance
        {  
            newString += ($"{item.GetDisplayText()} "); 
        }        
        // Console.WriteLine($"Test: {newString}");
        return newString;
    }
    //displays amended scripture string with hidden values


    //hide random words
    public void HideRandomWords()
    {
        
    }
    //is Completely hidden? boolean value;  This will tell you if the scripture is completely hidden and the program can end.
    public bool IsCompletelyHidden()
    {
        return false;
    }

    public Scripture(Reference reference, string scripture)
    {   
        //sets reference attribute in instance
        _reference = reference; 

        //create list of word objects from the scripture string
        //put each word from scripture into a word object 
               
        _wordsList = new List<Word>();
        String[] splitArray = scripture.Split(' ');
        foreach  (string wordInArray in splitArray)
        {
            //create a word object for each word
            Word myWordObject = new Word(wordInArray);
            //add new word into list
            _wordsList.Add(myWordObject);             
        }

        //test code to see if word object holds a different word.  Cannot just print out _wordsList.
        // foreach (Word item in _wordsList) //prints out "word object" + the word for each instance
        // {  
        //     Console.WriteLine($"word object: {item.GetDisplayText()}"); 
        // }
        
    } 

} //end class