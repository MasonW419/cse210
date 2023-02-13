using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public string GetWord()
    {
        return _word;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }
    public void Toggle()
    {
        if(_isHidden)
        {
            _isHidden = false;
        }
        else
        {
            _isHidden = true;
        }
    }
    public void Toggle(bool b)
    {
        _isHidden = b;
    }
}