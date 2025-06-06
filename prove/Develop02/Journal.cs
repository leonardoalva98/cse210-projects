public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    { _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear(); 

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileString(line);
                _entries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}