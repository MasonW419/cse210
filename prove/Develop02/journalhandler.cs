using System;
using System.IO;
using System.Collections.Generic;

public class JournalHandler {
    public JournalHandler() {
    }
    public void saveEntries(string file, List<string> info) {
        using (StreamWriter outputFile = new StreamWriter(file)) {
            foreach(string i in info) {
                outputFile.WriteLine(i);
            }
        }
    }
    public List<string[]> loadEntryContents(string file) {
        List<string[]> contents = new List<string[]>();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines) {
            string[] parts = line.Split(',');
            contents.Add(parts);
        }
        return contents;
    }
}