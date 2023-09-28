using System;
using System.Runtime.CompilerServices;

public class Word
{
    //Keeps track of a single word and whether it is shown or hidden.
    //holds value for a word from scripture text
    private string _text;
    //holds boolean variable for isHidden
    private bool _isHidden = false;  //default value is to show word

    //Constructor gets text value passed in from other classes
    public Word(string word)  //can this just be a word from the scripture and Not the whole scripture?
    {
        _text = word;
    }

    public Word()
    {
        //constructs an instance with no variables set.  Do I want this?
    }

    //will Hide, Show, set a Boolean value 
    //change a word from the set text to the underscore value for each character in word
    public void Hide()
    {        
        _isHidden = true;        
    }
    public void Show()
    {
        _isHidden = false;
    }
    //and return string for GetDisplayText() 
    public string GetDisplayText()
    {
        
        if (_isHidden == true)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                _text.Replace(_text[i], '_');  //single quotes denotes character, double quotes denotes string value
            }
            // foreach (string text in _text)
            // {
            //     _text.Replace()
            // }                 
        }
        return _text;
       
    }
}   