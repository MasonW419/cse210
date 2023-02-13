using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _text = new List<Word>();
    private Reference reference;
    private Random rnd = new Random();
    public Scripture(string book, string chapter, string verse, string text)
    {
        reference = new Reference(book, chapter, verse);
        string[] textArray = text.Split(' ');
        foreach(string t in textArray)
        {
            _text.Add(new Word(t));
        }
    }
    public Scripture(string book, string chapter, string start, string end, string text)
    {
        reference = new Reference(book, chapter, start, end);
    }
    public string DisplayRenderedText()
    {
        string concated = reference.DisplayVerseInfo();
        foreach(Word word in _text)
        {
            if(word.GetHidden())
            {
                concated += " ______";
            }
            else
            {
                concated += $" {word.GetWord()}";
            }
        }
        return concated;
    }
    public bool IsAllHidden()
    {
        bool x = true;
        foreach(Word word in _text) 
        {
            if(word.GetHidden())
            {
                x = true;
            }
            else
            {
                x = false;
            }
        }
        return x;
    }
    public void HideWords(int counting)
    {
        List<int> indexList = new List<int>();
        for(int i = 0; i < _text.Count(); i++)
        {
            if(_text[i].GetHidden() == false) 
            {
                indexList.Add(i);
            }
        }
        int length = indexList.Count();
        int total = 0;
        if(length < counting)
        {
            total = length;
        }
        else
        {
            total = counting;
        }
        for(int i = 0; i < total; i++)
        {
            HideWord();
        }
    }
    public void HideWord() 
    {
        List<int> indexList = new List<int>();
        for(int i = 0; i < _text.Count(); i++)
        {
            if(_text[i].GetHidden() == false) 
            {
                indexList.Add(i);
            }
        }
        int length = indexList.Count();
        int randomNum = rnd.Next(0, length-1);
        _text[indexList[randomNum]].Toggle(true);
    }
}
