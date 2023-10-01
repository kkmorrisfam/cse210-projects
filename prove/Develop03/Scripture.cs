using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Scripture
{
    //keeps track of the reference and the text of the scripture
    //could use a list of words to store the scripture string. we can change/add to a list
    //could use an array of words to store the scripture string. arrays are immutable/unchanging
    private List<Word> _wordsList;
    private Reference _reference;  //scripture class just holds value, doesn't create it.
    //set count of how many word objects are in the scripture in this object.
    private int _count;

    //I want one list of random numbers per object initialization
    private List<int> _randomIntList = new List<int>();
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
        Random random = new Random();
        int randomInt = -1;
        // int countInt = -1;
        bool containsMatch = false;
        
        
        do //repeat process if random number is in randomIntList  
        {   //get random number between 0 and the length of the scripture array/list
            randomInt = random.Next(0, _count);
            //check to see if random number is in the randomInt List, if not, add it to the list, and hide word.
            
                 //created my own method to check for match
            //containsMatch = IsThereAny(_randomIntList, randomInt); //_randomIntList.Any(randomInt); -mostly works
            containsMatch = _randomIntList.Contains(randomInt);
            if (containsMatch == false)  //number is not in list
            {
                _randomIntList.Add(randomInt);  //add random number to list
                _wordsList[randomInt].Hide();   //hide word at that index                        
            }
        } while (containsMatch == true); 
        
    }  //close method HideRandomWords()

    //is Completely hidden? boolean value;  This will tell you if the scripture is completely hidden and the program can end.
    public bool IsCompletelyHidden()
    {
        bool hidden = false;
        if (_randomIntList.Count >= _count)
        {
            hidden = true;
        }
        return hidden;
    }
    // I am sure there's a built in function that can do this, but I couldn' get what I found to work
    // so I made this.
    //***not working the final round. count is off somewhere but couldn't find it.
    // private bool IsThereAny(List<int> xList, int xInt)
    // {
    //     bool isThereAny = false;

    //     for (int i = 0; i < xList.Count; i++)
    //     {
    //         if (xList[i] == xInt)
    //         {
    //             isThereAny = true;
    //             break;
    //         }
    //     }
    //     return isThereAny;
    // }

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
            //increment count variable to get the number of words in the string.
            _count ++;  
                         
        }  
        
    } 

} //end class