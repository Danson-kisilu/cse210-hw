using System;

namespace Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        /*
        CREATIVITY AND EXCEEDING REQUIREMENTS:
        1. Added input validation for menu selection and duration
        2. Added smooth spinner animation with backspace character technique
        3. Breathing activity shows different durations for inhale (4 sec) and exhale (6 sec)
        4. Reflection activity randomizes questions and shows spinner during reflection time
        5. Listing activity counts user entries and displays total at the end
        6. Clear screen between activities for better user experience
        7. Each activity shows proper preparation and completion messages
        */
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("==================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an activity (1-4): ");
            
            string choice = Console.ReadLine();
            
            if (choice == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                    
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                    
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    continue;
            }
            
            Console.WriteLine("\nPress enter to return to the menu...");
            Console.ReadLine();
        }
    }
}