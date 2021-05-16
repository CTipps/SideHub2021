using System;
using System.Collections.Generic;
using System.Text;

namespace KnockKnockJokes
{
    public class JokeList
    {
        public List<string> opener = new List<string>(){
            "Boo",
            "Owls",
            "Woo",
            "Nobel",
            "Tank",
            "Water",
            "To"};

        private List<string> punchline = new List<string>() {
            "Don't cry, it's only a joke!",
            "Exactly!",
            "Wow, you're pretty excited to see me!",
        "Nobel...That's why I knocked!",
        "You're welcome!",
        "Water you doing looking at jokes, don't you have work to do!",
        "Actually it's 'to whom'."};

        public string GetPunchline(int jokeIndex)
        {
            return punchline[jokeIndex];
        }

    }
}
