using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:");
        string name = (Console.ReadLine());
        bool goOn = true;
        while (goOn == true)
        {
            Console.WriteLine("Hello, " + name + ". Please enter a number between 1 and 100.");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            {
                if (y < 1 || y > 100)
                {
                    Console.WriteLine("Please try again.");
                    break;
                }
                else if (y % 2 == 0 && y > 2 && y < 25)
                {
                    Console.WriteLine(name + ", the number you entered,  " + x + ", is even and less than 25.");
                }
                else if (y % 2 == 0 && y >= 26 && y <= 60)
                {
                    Console.WriteLine(name + ", the number you entered, " + x + ", is even.");
                }
                else if (y % 2 == 0 && y > 60)
                {
                    Console.WriteLine(name + ", the number you entered, " + x + ", is even and greater than 60.");
                }
                else if (y % 2 != 0 && y > 60)
                {
                    Console.WriteLine(name + ", the number you entered, " + x + ", is odd and is greater than 60.");
                }
                else
                {
                    Console.WriteLine(name + ", the number you entered, " + x + ", is odd.");
                }
            }
            string response = "";
            while (response != "y" || response != "n")
            {
                Console.WriteLine("Do you want to continue? y/n");
                response = Console.ReadLine();



                if (response == "y" || response == "Y")
                {
                    break;
                }
                else if (response == "n" || response == "N")
                {
                    goOn = false;
                    Console.WriteLine("Thank you for playing, " + name + "!");
                    break;
                }
            }
        }
    }
}