using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on: musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            string travelMethod;
            string vacationDest;

            //Vacation Type
            if (vacationType == "musical")
            {
                vacationDest = "New Orleans.";
            }
            else if (vacationType == "tropical")
            {
                vacationDest = "a beach vacation in Mexico.";
            }
            else
            {
                vacationDest = "go whitewater rafting in the Grand Canyon.";
            }

            Console.WriteLine("How many people are in your group?");
            int groupSize = int.Parse(Console.ReadLine());

            //Group Size
            if (groupSize <= 2)
            {
                travelMethod = "first class flight";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelMethod = "helicopter";
            }
            else
            {
                travelMethod = "charter flight";
            }
            //Result
            string result = "Since you're a group of " + groupSize + " people going on a/an " + vacationType + " vacation, you should take a " + travelMethod + " to " + vacationDest;
            Console.WriteLine(result);
        }
    }
}