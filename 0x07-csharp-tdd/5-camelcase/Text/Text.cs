using System;

namespace Text
{
    /// <summary>Provides methods to work with strings</summary>
    public class Str
    {
        /// <summary>Determines how many words are in a string. Each word begins with a capital letter except the first word.</summary>
        /// <returns>The number of words that are in the string</returns>
        public static int CamelCase(string s)
        {
            int count = 0;

            if (s == null || s.Length == 0)
                return 0;

            foreach (var item in s)
            {
                if (Char.IsUpper(item))
                {
                    Console.WriteLine(item);
                    count++;
                }
            }

            return count + 1;
        }
    }
}
