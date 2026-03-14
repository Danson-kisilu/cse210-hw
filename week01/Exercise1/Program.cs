using System;

class Program
{

    //program asks the user for their first and last name, then prints them in the format "Last, First Last"
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
       

    
    }
}