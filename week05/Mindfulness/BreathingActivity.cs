using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int totalTime = GetDuration();
        int cycleTime = 8;
        int rounds = totalTime / cycleTime;

        for (int i = 0; i < rounds; i++)
        {
            Console.Write("\nBreathe in...");
            PauseWithCountdown(4);
            Console.Write("\nBreathe out...");
            PauseWithCountdown(4);
        }
        DisplayEndingMessage();
    }
}
