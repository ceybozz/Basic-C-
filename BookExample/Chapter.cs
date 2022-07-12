using System;

namespace BookExample
{
    public class Chapter
    {
        public string Name { get; private set; }
        public int Number { get; private set; }

        public Chapter(string name, int num)
        {
            Name = name;
            Number = num;
        }

    }
}
