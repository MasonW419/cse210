using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public string _currentDate;
    public bool _journalActive;
    public int _optionSelect;
    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();
    public JournalHandler _journalHandler = new JournalHandler();
    public List<Action> _functions = new List<Action>();
    public Journal() {
        this._currentDate = getDate();
        this._journalActive = true;
        this._optionSelect = 0;
        this._functions.Add(() => Write(_prompts));
        this._functions.Add(() => Display(_entries));
        this._functions.Add(() => Load());
        this._functions.Add(() => Save(_entries));
        this._functions.Add(() => Quit());
        this._prompts.Add("Who was the most interesting person I interacted with today?");
        this._prompts.Add("What was the best part of my day?");
        this._prompts.Add("How did I see the hand of the Lord in my life today?");
        this._prompts.Add("What was the strongest emotion I felt today?");
        this._prompts.Add("If I had one thing I could do over today, what would it be?");

        while (_journalActive) {
            MenuDisplay();
            _optionSelect = Convert.ToInt16(Console.ReadLine());
            _functions[_optionSelect - 1]();
        }
    }
    public string getDate() {
        DateTime cur = DateTime.Now;
        string date = cur.ToShortDateString();
        return date;
    }
    public void CreateEntry(List<Entry> entryList, string prompt, string date, string text) {
        entryList.Add(new Entry(prompt, date, text));
    }
    public void Write(List<string> promptList) {
        Random ran = new Random();
        int randomNum = ran.Next(0, promptList.Count - 1);
        string generatedPrompt = promptList[randomNum];
        Console.WriteLine(generatedPrompt);
        Console.Write("> ");
        string userInput = Console.ReadLine();
        CreateEntry(_entries, generatedPrompt, getDate(), userInput);
    }
    public void Display(List<Entry> entryList) {
        if (entryList.Count == 0) {
            Console.WriteLine("No journal entries to display");
            Console.WriteLine("");
        }
        else {
            foreach (Entry e in entryList) {
            e.DisplayText();
            }
        }
    }
    public void Load() {
        string requestedFile = askFileName();
        if(File.Exists(requestedFile)) {
            List<string[]> requestedInfo = _journalHandler.loadEntryContents(requestedFile);
            foreach(string[] s in requestedInfo) {
                CreateEntry(_entries, s[0], s[1], s[2]);
            }
        }
        else {
            Console.WriteLine("File does not exist");
        }
    }
    public void Save(List<Entry> entryList) {
        string requestedFile = askFileName();
        List<string> entryStrings = new List<string>();
        foreach(Entry e in entryList) {
            entryStrings.Add(e.getInfo());
        }
        _journalHandler.saveEntries(requestedFile, entryStrings);
    }
    public void Quit() {
        this._journalActive = false;
    }
    public void MenuDisplay() {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        return ;
    }
    public string askFileName() {
        Console.WriteLine("What is the file name?");
        string userInput = Console.ReadLine();
        return userInput;
    }
}