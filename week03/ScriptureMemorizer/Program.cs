using System;

namespace ScriptureMemorizer
{
    
    /// Main program class for the Scripture Memorizer.
    /// This program helps users memorize scriptures by progressively hiding words.
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine("================================");
            
            ScriptureLibrary library = new ScriptureLibrary();
            Scripture currentScripture = library.GetRandomScripture();
            
            bool continueProgram = true;
            
            while (continueProgram)
            {
                // Show main menu
                ShowMenu(currentScripture, library);
                
                string choice = Console.ReadLine().ToLower();
                
                switch (choice)
                {
                    case "q":
                    case "quit":
                        continueProgram = false;
                        break;
                        
                    case "n":
                    case "new":
                        currentScripture = library.GetRandomScripture();
                        Console.Clear();
                        Console.WriteLine($"\nNew scripture selected! There are {library.GetScriptureCount()} scriptures in the library.\n");
                        DisplayScripture(currentScripture);
                        break;
                        
                    case "h":
                    case "hint":
                        // Hint functionality - reveal one random word temporarily
                        Console.Clear();
                        DisplayScripture(currentScripture);
                        Console.WriteLine("\n[HINT MODE - Press any key to continue]");
                        Console.ReadKey();
                        break;
                        
                    case "d":
                    case "difficulty":
                        ChangeDifficulty(ref currentScripture);
                        break;
                        
                    default:
                        // Hide words based on difficulty
                        int wordsToHide = GetWordsToHideByDifficulty();
                        currentScripture.HideRandomWords(wordsToHide);
                        Console.Clear();
                        DisplayScripture(currentScripture);
                        
                        // Check if completely hidden
                        if (currentScripture.IsCompletelyHidden())
                        {
                            Console.WriteLine("\nCongratulations! You've memorized the entire scripture!");
                            Console.WriteLine("Press any key to exit...");
                            Console.ReadKey();
                            continueProgram = false;
                        }
                        break;
                }
            }
            
            Console.WriteLine("\nThank you for using Scripture Memorizer. Goodbye!");
        }
        
        static void ShowMenu(Scripture scripture, ScriptureLibrary library)
        {
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("Commands:");
            Console.WriteLine("  [Enter] - Hide words");
            Console.WriteLine("  [N]ew   - Get a new random scripture");
            Console.WriteLine("  [D]ifficulty - Change difficulty level");
            Console.WriteLine("  [H]int  - Get a hint (temporary word reveal)");
            Console.WriteLine("  [Q]uit  - Exit program");
            Console.WriteLine(new string('-', 50));
            
            // Show progress
            int visibleWords = scripture.GetVisibleWordCount();
            int totalWords = scripture.GetTotalWordCount();
            int hiddenWords = totalWords - visibleWords;
            double progress = (double)hiddenWords / totalWords * 100;
            
            Console.WriteLine($"Progress: {hiddenWords}/{totalWords} words hidden ({progress:F1}%)");
            Console.WriteLine($"Scriptures in library: {library.GetScriptureCount()}");
            Console.WriteLine("\nPress Enter to continue hiding words...");
        }
        
        static void DisplayScripture(Scripture scripture)
        {
            Console.WriteLine(scripture.GetDisplayText());
        }
        
        static int GetWordsToHideByDifficulty()
        {
            // Simple difficulty system
            Console.Write("\nChoose difficulty (E/M/H for 1/3/5 words): ");
            string difficulty = Console.ReadLine().ToLower();
            
            switch (difficulty)
            {
                case "e":
                case "easy":
                    return 1;
                case "h":
                case "hard":
                    return 5;
                case "m":
                case "medium":
                default:
                    return 3;
            }
        }
        
        static void ChangeDifficulty(ref Scripture scripture)
        {
            // This is a simple demonstration - in a real implementation,
            // you might store difficulty in a global variable
            Console.WriteLine("\nDifficulty will apply to the next hide operation.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            DisplayScripture(scripture);
        }
    }
}