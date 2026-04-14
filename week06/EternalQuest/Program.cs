using System;

namespace EternalQuest;

class Program
{
    
    
    static void Main(string[] args)
    {
        Console.Title = "Eternal Quest";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("⚔️  WELCOME TO ETERNAL QUEST!  ⚔️");
        Console.WriteLine("Your journey to self-improvement begins now.\n");
        Console.ResetColor();
        
        GoalManager manager = new GoalManager();
        manager.Start();
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n✨ Thank you for using Eternal Quest! ✨");
        Console.WriteLine("Remember: Every small step brings you closer to your goals!");
        Console.ResetColor();
    }
}