using System;
using System.Collections.Generic;

namespace KnockKnockJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> whosThere = 
            Console.Write("Would you like to hear a Knock Knock Joke? Y/N : ");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Console.Write("Great!");

            }
           else if (answer == "N")
            {
                Console.WriteLine("But what's the fun in that? Here's one anyway!");
            }
            else
            {
                Console.WriteLine("I'm not sure what you said, but I think you want to hear one.");
            }
            Console.WriteLine("Knock Knock");
            string response = Console.ReadLine().ToLower();
            if (response != "who's there?")
            {
                Console.WriteLine(" That's not the right response. It's 'Who's there?'. But that's okay, let's continue.");
            } 
            


        }
    }
}
