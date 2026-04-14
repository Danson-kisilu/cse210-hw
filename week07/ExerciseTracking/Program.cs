using System;
using System.Collections.Generic;

namespace ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycles cycling = new StationaryBicycles("04 Nov 2022", 45, 15.0);
        Swimming swimming = new Swimming("05 Nov 2022", 40, 30);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Exercise Tracking Log:\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}