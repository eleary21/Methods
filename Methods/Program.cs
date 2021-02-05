//Author: Ethan leary
//Date: 2/5/2021
//Description: This program uses a method to display the name of the user
//after they type their name and click enter.
using System;

namespace Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Display directions for the user
            Console.WriteLine("Please Write Your Nameand Click Enter");
            //Store what the user types into "input"
            string input = Console.ReadLine();
            //Display the input to create a message for the user
            Console.WriteLine("Hello " + input + "!");
            //Awaits for the user to press a button to end the program
            Console.ReadKey(true);

        }
    }
}
