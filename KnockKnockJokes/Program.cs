using System;
using System.Collections.Generic;
using System.IO;

namespace KnockKnockJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            JokeList jokes = new JokeList();
            Random rand = new Random();
            bool mistake = false;
            bool hearAJoke = true;
            int bananaLoop = rand.Next(3, 7);
            int jokeNumber = rand.Next(0, jokes.opener.Count);

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
            while (hearAJoke)
            { 
                string jokeOpener = jokes.opener[jokeNumber];
                if (jokeOpener == "Banana")
                {
                    jokes.BananaTime(bananaLoop);
                    jokeNumber++;
                }
                else
                {
                    Console.WriteLine("Knock Knock");
                    answer = Console.ReadLine().ToLower();
                    if (!jokes.whosThere.Contains(answer))
                    {
                        mistake = true;
                        Console.WriteLine(" That's not the right response. It's 'Who's there?'. But that's okay, let's continue.");
                    }
                    Console.WriteLine(jokeOpener);
                    string prePunch = Console.ReadLine().ToLower();


                    if (prePunch != jokeOpener.ToLower() + " who" && prePunch != jokeOpener.ToLower() + " who?")
                    {
                        if (mistake)
                        {
                            Console.WriteLine("Wow, you're really bad at knock knock jokes! You're supposed to say '" + jokeOpener + " who?'. Then I say:");
                        }
                        else
                        {
                            Console.WriteLine("That's not right, it's: " + jokeOpener + " who? Then I say:");
                        }
                    }
                }
                Console.WriteLine(jokes.GetPunchline(jokeNumber));
                Console.WriteLine("");
                Console.Write("Would you like to hear another? Y/N: ");
                string contResponse = Console.ReadLine().ToUpper();
                if (contResponse == "Y")
                {
                    hearAJoke = true;
                } else
                {
                    Console.WriteLine("That's a shame!");
                    hearAJoke = false;
                }
            
                Console.Write("Hit any key to exit.");
                Console.ReadLine();
            }

            
        }
    }
}
