using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _start;
    private string _end;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _start = verse;
        _end = "-1";
    }
    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }
    public string DisplayVerseInfo()
    {
        string info;
        if (_end == "-1")
        {
            info = $"{_book} {_chapter}:{_start}";
        }
        else
        {
            info = $"{_book} {_chapter}:{_start}-{_end}";
        }
        return info;
    }
}