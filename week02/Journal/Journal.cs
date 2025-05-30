public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry):
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter write = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                write.WriteLine(entry.ToCsv());
            }
        }
    }

        public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromCsv(line));
        }
    }
}

