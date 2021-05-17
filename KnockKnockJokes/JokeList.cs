using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KnockKnockJokes
{
    public class JokeList
    {
        int i = 0;
        Random rand = new Random();
        public List<string> opener = new List<string>(){
            "Boo",
            "Owls",
            "Woo",
            "Nobel",
            "Tank",
            "Water",
            "To",
            "Banana",
            "Orange"};

        private List<string> punchline = new List<string>() {
            "Don't cry, it's only a joke!",
            "Exactly!",
            "Wow, you're pretty excited to see me!",
        "Nobel...That's why I knocked!",
        "You're welcome!",
        "Water you doing looking at jokes, don't you have work to do!",
        "Actually it's 'to whom'.",
        "",
        "Orange you glad I didn't say banana!"};

        public List<string> whosThere = new List<string>()
        {
            "Who's there?",
            "Who's there",
            "whos there?",
            "whos there",
        };
        public void BananaTime(int bananaLoop)
        {
            while (i <= bananaLoop)
            {
                 bool mistake = false;
                Console.WriteLine("Knock Knock");
                string answer = Console.ReadLine().ToLower();
                if (!whosThere.Contains(answer))
                {
                    mistake = true;
                    Console.WriteLine(" That's not the right response. It's 'Who's there?'. But that's okay, let's continue.");
                }
                Console.WriteLine("Banana");
                string prePunch = Console.ReadLine().ToLower();


                if (prePunch != "banana who" && prePunch != "banana who?")
                {
                    if (mistake)
                    {
                        Console.WriteLine("Wow, you're really bad at knock knock jokes! You're supposed to say 'Banana who?'. Then I say:");
                    }
                    else
                    {
                        Console.WriteLine("That's not right, it's: Banana who? Then I say:");
                    }
                } i++;
            }
                bool finalMistake = false;
                Console.WriteLine("Knock Knock");
                string finalAnswer = Console.ReadLine().ToLower();
                if (!whosThere.Contains(finalAnswer))
                {
                    finalMistake = true;
                    Console.WriteLine(" That's not the right response. It's 'Who's there?'. But that's okay, let's continue.");
                }
                Console.WriteLine("Orange");
                string finalPrePunch = Console.ReadLine().ToLower();
                if (finalPrePunch != "orange who" && finalPrePunch != "orange who?")
                {
                    if (finalMistake)
                    {
                        Console.WriteLine("Wow, you're really bad at knock knock jokes! You're supposed to say 'Orange who?'. Then I say:");
                    }
                    else
                    {
                        Console.WriteLine("That's not right, it's: Orange who? Then I say:");
                    }
                }
        }
            

        public string GetPunchline(int jokeIndex)
        {
            return punchline[jokeIndex];
        }

    }
}
