using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    public string _mood;

    public Entry(string prompt, string entry, string mood)
    {
        _date = DateTime.Now.ToString();
        _prompt = prompt;
        _entry = entry;
        _mood = mood;
    }


    public Entry(string date, string prompt, string entry, string mood)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_entry}|{_mood}";
    }
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}

