﻿using System;
using System.Collections.Generic;

namespace KnockKnockJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            JokeList jokes = new JokeList();
            Random rand = new Random();

            int jokeNumber = rand.Next(0, jokes.opener.Count - 1);

            Console.Write("Would you like to hear a Knock Knock Joke? Y/N : ");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Console.WriteLine("Great!");

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
            if (response != "who's there?" && response != "who's there")
            {
                Console.WriteLine(" That's not the right response. It's 'Who's there?'. But that's okay, let's continue.");
            }
            Console.WriteLine(jokes.opener[jokeNumber]);
            string prePunch = Console.ReadLine().ToLower();
            if (prePunch != jokes.opener[jokeNumber].ToLower() + " who" && prePunch != jokes.opener[jokeNumber].ToLower() + " who?")
            {
                Console.WriteLine("Wow, you're really bad at knock knock jokes! Kinda tired of fixing your mistakes. Have a nice day!");
            }
            else
            {
                Console.WriteLine(jokes.GetPunchline(jokeNumber));
            } Console.Write("Hit any key to exit.");
            Console.ReadLine();


        }
    }
}
