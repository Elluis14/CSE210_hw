using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1–5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        Prompt = prompt,
                        Response = response
                    };

                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    myJournal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
