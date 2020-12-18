using System;

namespace Text
{
    /// <summary>Provides methods to work with strings.</summary>
    public class Str
    {
        /// <summary>Checks for the first non-repeating character of a string.</summary>
        /// <returns>The index of the first non-repeating character of a string otherwhise will returns -1.</returns>
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                if (s.IndexOf(letter) == i && s.IndexOf(letter, i + 1) == -1)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }

            return -1;
        }
    }
}
