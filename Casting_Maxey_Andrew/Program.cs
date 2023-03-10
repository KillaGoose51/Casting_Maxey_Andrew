using System;

namespace Casting_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Telling you to write a whole number
            Console.WriteLine("Put a whole number");
            // Makes the number convert into a whole int
            int whole = Convert.ToInt32(Console.ReadLine());
            // Writes the number you typed and says
            Console.WriteLine(whole + " is your favorite number! Mine is 51!");
            // Makes you type True or False
            Console.WriteLine("Yes or No " + "Please answer in true or false");
            // Asks you a question
            Console.WriteLine("Do you like video games");
            // Converts readline to bool
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("It is " + isTrue + " that I like video games!");
        }
    }
}
