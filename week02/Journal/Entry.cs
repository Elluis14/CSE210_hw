public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public override string ToString()
    {
        return $"{Date} - {Prompt}\n{Response}\n";
    }

    public string ToCsv()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split('|');
        return new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] };
    }
}
