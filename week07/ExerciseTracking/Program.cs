using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(DateTime.Now, 30, 5.0));   // 5 km in 30 min
        activities.Add(new Cycling(DateTime.Now, 45, 20.0));  // 20 kph for 45 min
        activities.Add(new Swimming(DateTime.Now, 60, 40));   // 40 laps in 60 min

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
