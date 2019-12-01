using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your message?");
        string input = Console.ReadLine();

        input = input.ToUpper();

        int checksum = 0;
        string message = null;
        foreach (char c in input)
        {
            if (message != null)
                message += "-";
            else
                message = "";

            message += c - 64;
            checksum += c;
        }
        Console.WriteLine("Your encoded message is: " + message);
        Console.WriteLine("Your checksum total is: " + checksum);
    }
}