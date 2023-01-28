using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _entryText;
    public string _prompt;
    public Entry(string prompt, string date, string text) {
        this._prompt = prompt;
        this._date = date;
        this._entryText = text;
    }
    public void DisplayText() {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine("");
    }
    public string getInfo() {
        string info = $"{_prompt},{_date},{_entryText}";
        return info;
    }
}