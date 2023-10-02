using System;
using System.Runtime.CompilerServices;

public class Word
{
    //Keeps track of a single word and whether it is shown or hidden.
    //holds value for a word from scripture text
    private string _text;
    private string _textSave;
    //holds boolean variable for isHidden
    private bool _isHidden;  //default value is to show word. no longer using this.

    //Constructor gets text value passed in from other classes
    public Word(string word)  //can this just be a word from the scripture and Not the whole scripture?
    {
        _text = word;
        _textSave = _text;  //make a copy for later
        _isHidden = false;
    }

    public Word()
    {
        //constructs an instance with no variables set.  Do I want this? Only if I create a set method
    }

    public void setWord(string word)
    {
        _text = word;
        _textSave = _text;  // make copy for later
        _isHidden = false;
    }
    //will set a Boolean value 
    public void Hide()
    {        
        _isHidden = true;                
        for (int i = 0; i < _text.Length; i++)
        {
            _text = _text.Replace(_text[i], '_');  //single quotes denotes character, double quotes denotes string value        
        }
    }
    
    //unused method. can use later?
    public void Show()
    {
        _isHidden = false;
        _text = _textSave;     //set text back to original   
    }
    //and return string for GetDisplayText() 
    public string GetDisplayText()
    {  
        return _text;        
    }
}   